using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieMonitoring
{
    public partial class Popup_MoldManager : CustomPopUp
    {
        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion

        #region .. code for Flucuring ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

        MonitoringForm parentdata;
        public static string selectedMoldCode = null;
        public Dictionary<string, string> moldDic = null;

        public Popup_MoldManager(MonitoringForm parent)
        {
            InitializeComponent();

            parentdata = parent;
            lbl_FormName.Text = "금형관리";
            //lb_Moldlist DB를 통한 새로고침
            DataConnector con = new DataConnector();
            moldDic = con.monitoring_MoldList_R10();

            foreach (var item in moldDic.Values)
            {
                lb_MoldList.Items.Add(item);
            }

        }

        private void Popup_Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentdata.modalisOpen = false;
        }

        private void Popup_Setting_Load(object sender, EventArgs e)
        {
            parentdata.modalisOpen = true;
        }

        private void lb_MoldList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lb_MoldList.SelectedItem != null)
            {
                parentdata.lbl_MoldName.Text = lb_MoldList.SelectedItem.ToString();
                selectedMoldCode = moldDic.FirstOrDefault(x => x.Value == lb_MoldList.SelectedItem.ToString()).Key;

                DataConnector con = new DataConnector();
                con.monitoring_MoldList_U10(selectedMoldCode);

                this.Close();
            }
        
        }
    }
}
