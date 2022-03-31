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
    public partial class uc_OuterData : UserControl
    {
        public uc_OuterData()
        {
            InitializeComponent();

            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item.GetType() == typeof(Label))
                {
                    ((Label)item).Font = Program.Normalfont;

                }
            }
            lbl_bar.Font = Program.Normalfont;
            lbl_Temp.Font = Program.Normalfont;
            lbl_bartext.Font = Program.Normalfont;
            lbl_Temptext.Font = Program.Normalfont;

        }
        /// <summary>
        /// 하나만 지정해서 보낼 경우. bool 타입은 True는 온도, False는 습도
        /// </summary>
        /// <param name="IsTemp">True is Temp, False is Humid</param>
        /// <param name="value">just decimal</param>
        public void ChangeData(bool IsTemp, decimal value)
        {
            if (IsTemp)
            {
                lbl_Temp.Text = value.ToString()+ "℃";

            }
            else
            {
                lbl_bar.Text = value.ToString() + "bar";

            }
        }
        public void ChangeData(string Temp, string bar)
        {
            lbl_Temp.Text = Temp + "℃";
            lbl_bar.Text = bar + "bar";
        }

        public void ChangeData(decimal Temp, decimal bar)
        {
            lbl_Temp.Text = Temp.ToString() + "℃";
            lbl_bar.Text = bar.ToString() + "bar";
        }
    }
}
