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
    public partial class Popup_Setting : CustomPopUp
    {
        uc_OptionButton parentdata;
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
        public Popup_Setting(uc_OptionButton parent)
        {
            InitializeComponent();

            parentdata = parent;
            lbl_FormName.Text = "옵션설정";

            DataTable sensor_mst;
            try
            {
                DataConnector con = new DataConnector();
                sensor_mst = con.monitoring_Graph_R10();
                for (int i = 0; i < sensor_mst.Rows.Count; i++)
                {
                    cb_SensorList.Items.Add($"{sensor_mst.Rows[i]["gr"].ToString()}-{sensor_mst.Rows[i]["rsc"].ToString()}");
                }
            }
            catch (Exception)
            {

                throw;

            }

        }

        private void Popup_Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentdata.modalIsOpen = false;
        }

        private void Popup_Setting_Load(object sender, EventArgs e)
        {
            parentdata.modalIsOpen = true;
        }
    }
}
