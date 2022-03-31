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
        private int TotalPressCnt = 0;
        private int TodayPressCnt = 0;
        public uc_PressCount()
        {
            InitializeComponent();

            foreach (var item in tlp_Today.Controls)
            {
                if (item.GetType() == typeof(Label))
                {
                    ((Label)item).Font = Program.TitleFont;

                }
            }

            foreach (var item in tlp_Total.Controls)
            {
                if (item.GetType() == typeof(Label))
                {
                    ((Label)item).Font = Program.TitleFont;

                }
            }
        }

        public void PressCountUp()
        {
            TodayPressCnt++;
            TotalPressCnt++;
            lblTodayCnt.Text = TodayPressCnt.ToString().PadLeft(5, '0');
            lblTotalCnt.Text = TotalPressCnt.ToString().PadLeft(5, '0');
        }

        public void PressCntLoad(int TotalCnt, int TodayCnt)
        {
            TotalPressCnt = TotalCnt;
            TodayPressCnt = TodayCnt;
            lblTodayCnt.Text = TodayPressCnt.ToString().PadLeft(5, '0');
            lblTotalCnt.Text = TotalPressCnt.ToString().PadLeft(5, '0');
        }
    }
}
