
using System;
using System.Data;
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
            _tmrMinuteTimer = new System.Threading.Timer(_tmrNowTime_Callback, null,0, 60000);
        }


        private void _tmrNowTime_Callback(object state)
        {
            CSafeSetText(lblDate, DateTime.Now.ToString("yyyy. MM. dd"));
            CSafeSetText(lblTime, DateTime.Now.ToString("tt hh:mm:ss"));
            try
            {

                DataConnector con = new DataConnector();
                DataTable dt = con.monitoring_sensor_R20();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    uc_InnerTemp1.ChangeData((dt.Rows[i]["rsc"].ToString() == "12") ? true : false, dt.Rows[i]["vl"].ToString());
                }
            }
            catch (Exception)
            {

            }
        }



        private void ExitAction_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Application.Exit();
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
