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
    public partial class uc_PressCount : UserControl
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
        public uc_PressCount()
        {
            InitializeComponent();

        }


        public void PressCntLoad(int TotalCnt, int TodayCnt)
        {
            CSafeSetText(lblTodayCnt, TodayCnt.ToString("#,##0"));
            CSafeSetText(lblTotalCnt, TotalCnt.ToString("#,##0"));
        }
        public void PressCntLoad(string TotalCnt, string TodayCnt)
        {
            CSafeSetText(lblTodayCnt, Convert.ToInt32(TodayCnt).ToString("#,##0"));
            CSafeSetText(lblTotalCnt, Convert.ToInt32(TotalCnt).ToString("#,##0"));

        }


        delegate void CrossThreadSafetySetText(Control ctl, string text);
        private void CSafeSetText(Control ctl, string text)
        {
            if (ctl.InvokeRequired)
                ctl.Invoke(new CrossThreadSafetySetText(CSafeSetText), ctl, text);
            else
            {
                if (ctl.Text != text)
                {
                    ctl.Text = text;
                }
            }
        }


    }
}
