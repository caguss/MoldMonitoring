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
    public partial class uc_InnerTemp : UserControl
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

        public uc_InnerTemp()
        {
            InitializeComponent();

            //foreach (var item in tableLayoutPanel1.Controls)
            //{
            //    if (item.GetType() == typeof(Label))
            //    {
            //        ((Label)item).Font = Program.Normalfont;

            //    }
            //}
            //lbl_Humid.Font = Program.Normalfont;
            //lbl_Temp.Font = Program.Normalfont;

        }
        /// <summary>
        /// 하나만 지정해서 보낼 경우. bool 타입은 True는 온도, False는 습도
        /// </summary>
        /// <param name="IsTemp">True is Temp, False is Humid</param>
        /// <param name="value">just decimal</param>
        public void ChangeData(bool IsTemp, decimal value)
        {
            if (IsTemp)
                CSafeSetText(lbl_Temp, string.Format("{0:F1}", Convert.ToDouble(value.ToString())));
            else
                CSafeSetText(lbl_Humid, string.Format("{0:F1}", Convert.ToDouble(value.ToString())));
        }
        public void ChangeData(bool IsTemp, string value)
        {
            if (IsTemp)
                CSafeSetText(lbl_Temp, string.Format("{0:F1}", Convert.ToDouble(value.ToString())));
            else
                CSafeSetText(lbl_Humid, string.Format("{0:F1}", Convert.ToDouble(value.ToString())));
        }
        public void ChangeData(string Temp, string Humid)
        {
                CSafeSetText(lbl_Temp, string.Format("{0:F1}", Convert.ToDouble(Temp.ToString())));
                CSafeSetText(lbl_Humid, string.Format("{0:F1}", Convert.ToDouble(Humid.ToString())));
        }

        public void ChangeData(decimal Temp, decimal Humid)
        {
            CSafeSetText(lbl_Temp, string.Format("{0:F1}", Convert.ToDouble(Temp.ToString())));
            CSafeSetText(lbl_Humid, string.Format("{0:F1}", Convert.ToDouble(Humid.ToString())));
        }

        delegate void CrossThreadSafetySetText(Control ctl, String text);
        private void CSafeSetText(Control ctl, String text)
        {
            if (ctl.InvokeRequired)
                ctl.Invoke(new CrossThreadSafetySetText(CSafeSetText), ctl, text);
            else
            {
                if (ctl.Text != text) // 입력된 텍스트가 기존 텍스트와 다를 경우만 변경 ( 깜빡임 문제 )
                {
                    ctl.Text = text;
                }
            }
        }
    }
}
