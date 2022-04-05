
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DieMonitoring
{
    public partial class uc_ProgramTimer : UserControl
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


        System.Threading.Timer _tmrMinuteTimer = null;

        public uc_ProgramTimer()
        {
            InitializeComponent();
            //foreach (var item in tableLayoutPanel1.Controls)
            //{
            //    if (item.GetType() == typeof(Label))
            //    {
            //        ((Label)item).Font = Program.DescriptionFont;

            //    }
            //}
            //lblDate.Font = Program.Normalfont;
            //lblTime.Font = Program.TitleFont;
            //lbl_Title.Font = Program.TitleFont;
            _tmrMinuteTimer = new System.Threading.Timer(_tmrNowTime_Callback, null,0, 60000);
        }


        delegate void CrossThreadSafetySetText(Control ctl, String text);
        private void _tmrNowTime_Callback(object state)
        {
            CSafeSetText(lblDate, DateTime.Now.ToString("yyyy. MM. dd"));
            CSafeSetText(lblTime, DateTime.Now.ToString("tt hh:mm:ss"));

            //온습도 procedure 추가
        }



        private void ExitAction_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Application.Exit();
        }


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
