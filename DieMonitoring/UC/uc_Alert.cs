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

        public bool modalIsOpen = false;
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
        }

        public void AlertLoad(string cnt)
        {
            if (cnt == "0")
            {
                lbl_AlarmCnt.Invoke((MethodInvoker)delegate ()
                {
                    lbl_AlarmCnt.Text = cnt;
                });
                GreanAlarm();
                return;
            }
            else if (Convert.ToInt32(cnt) > 999)
            {
                lbl_AlarmCnt.Invoke((MethodInvoker)delegate ()
                {
                    lbl_AlarmCnt.Text = "999+";
                });
            }
            else
            {
                lbl_AlarmCnt.Invoke((MethodInvoker)delegate ()
                {
                    lbl_AlarmCnt.Text = cnt;
                });
            }
            RedAlarm();
        }
        public void AlertClear()
        {
            //lbl_AlarmCnt.Invoke((MethodInvoker)delegate ()
            //{
                lbl_AlarmCnt.Text = 0.ToString();
            //});
            GreanAlarm();
        }
        //public void AlertCreate()
        //{
        //    lbl_AlarmCnt.Text = (++AlarmCount).ToString();
        //    RedAlarm();
        //}

        private void RedAlarm()
        {
            pic_Alert.Invoke((MethodInvoker)delegate ()
            {
                pic_Alert.Image = DieMonitoring.Properties.Resources.red_alert;
            });

            CSafeSetColor(lbl_AlarmCnt, AlertColor);
            CSafeSetColor(label1, AlertColor);
            CSafeSetColor(label2, AlertColor);
        }

        private void GreanAlarm()
        {
            pic_Alert.Image = DieMonitoring.Properties.Resources.green_check;
            CSafeSetColor(lbl_AlarmCnt, ClearColor);
            CSafeSetColor(label1, ClearColor);
            CSafeSetColor(label2, ClearColor);
        }
        delegate void CrossThreadSafetySetForeColor(Control ctl, Color setcolor);
        private void CSafeSetColor(Control ctl, Color setcolor)
        {
            if (ctl.InvokeRequired)
                ctl.Invoke(new CrossThreadSafetySetForeColor(CSafeSetColor), ctl, setcolor);
            else
            {
                if (ctl.ForeColor != setcolor) 
                {
                    ctl.ForeColor = setcolor;
                }
            }
        }
        /// <summary>
        /// test method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_AlarmCnt_Click(object sender, EventArgs e)
        {
            //alarmHistory Popup을 생성하지만 checkYN은 N, useyn은 N인 알람만 불러오도록

            Popup_AlertHistory modal = new Popup_AlertHistory(this);
            modal.Show();
        }
    }
}
