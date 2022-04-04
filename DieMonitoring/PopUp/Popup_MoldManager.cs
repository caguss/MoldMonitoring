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
        public Popup_MoldManager(MonitoringForm parent)
        {
            InitializeComponent();

            parentdata = parent;
            lbl_FormName.Text = "금형관리";
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
            parentdata.lbl_MoldName.Text = lb_MoldList.SelectedItem.ToString();
            this.Close();
        }
    }
}
