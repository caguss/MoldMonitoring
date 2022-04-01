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
    public partial class uc_AlarmHistory : UserControl
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
        public bool modalIsOpen = false;
        public uc_AlarmHistory()
        {
            InitializeComponent();

            //lbl_AlarmHistory.Font = Program.Normalfont;
        }

        private void lbl_AlarmHistory_Click(object sender, EventArgs e)
        {
            if (!modalIsOpen)
            {
                Popup_AlertHistory modal = new Popup_AlertHistory(this); //현재 켜져있는지 확인하기 위해 this 던짐
                modal.Show();
            }
        }
    }
}
