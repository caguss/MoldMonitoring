using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieMonitoring
{
    public partial class uc_Alert : UserControl
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
        private int AlarmCount = 0;
        private Color ClearColor = Color.Green;
        private Color AlertColor = Color.Red;
        public uc_Alert()
        {
            InitializeComponent();
            //foreach (var item in tableLayoutPanel1.Controls)
            //{
            //    if (item.GetType() == typeof(Label))
            //    {
            //        ((Label)item).Font = Program.TitleFont;

            //    }
            //}
            AlertClear();
            AlertCreate();
        }


        public void AlertCreate()
        {

            pic_Alert.Image = DieMonitoring.Properties.Resources.red_alert;

            lbl_AlarmCnt.Text = (++AlarmCount).ToString();
            lbl_AlarmCnt.ForeColor = AlertColor;
            label1.ForeColor = AlertColor;
            label2.ForeColor = AlertColor;
        }
        public void AlertClear()
        {

            pic_Alert.Image = DieMonitoring.Properties.Resources.green_check;

            lbl_AlarmCnt.Text = 0.ToString();
            lbl_AlarmCnt.ForeColor = ClearColor;
            label1.ForeColor = ClearColor;
            label2.ForeColor = ClearColor;
        }

        /// <summary>
        /// test method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_AlarmCnt_Click(object sender, EventArgs e)
        {
            AlertClear();
        }
    }
}
