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

        private int TotalPressCnt = 10000;
        private int TodayPressCnt = 10000;
        public uc_PressCount()
        {
            InitializeComponent();

        }

        public void PressCountUp()
        {
            TodayPressCnt++;
            TotalPressCnt++;
            lblTodayCnt.Text = TodayPressCnt.ToString("#,##0");
            lblTotalCnt.Text = TotalPressCnt.ToString("#,##0");
        }

        public void PressCntLoad(int TotalCnt, int TodayCnt)
        {
            TotalPressCnt = TotalCnt;
            TodayPressCnt = TodayCnt;
            lblTodayCnt.Text = TodayPressCnt.ToString("#,##0");
            lblTotalCnt.Text = TotalPressCnt.ToString("#,##0");
        }

        private void lblTodayCnt_Click(object sender, EventArgs e)
        {
            PressCountUp();
        }
    }
}
