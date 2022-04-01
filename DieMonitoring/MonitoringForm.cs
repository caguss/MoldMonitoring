using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieMonitoring
{
    public partial class MonitoringForm : Form
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
        public bool frontisRed = false;
        public bool backisRed = false;

        System.Threading.Timer _tmrSecondTimer = null;
        public int frontsecondcnt = 0; // 안들어온 초를 세기위한 함수 --DB상 센서카운트 14개가 안된다면 cnt 올림?? 구상 필요
        public int backsecondcnt = 0; // 안들어온 초를 세기위한 함수 --DB상 센서카운트 14개가 안된다면 cnt 올림?? 구상 필요


        public int maxcnt = 10; // secondcnt와의 비교하기 위한 함수. 해당 함수의 수만큼 데이터가 들어오지 않을경우 빨간색 점멸

        public MonitoringForm()
        {
            InitializeComponent();
            _tmrSecondTimer = new System.Threading.Timer(_tmrConnectionError_Callback, null, 1000, 1000);

            //lbl_MoldName.Font = Program.BigFont;
            //lblback.Font = Program.TitleFont;
            //lblfront.Font = Program.TitleFont;
        }
        private void _tmrConnectionError_Callback(object state)
        {
            if (frontsecondcnt >= maxcnt)
            {
                if (!frontisRed)
                {

                    lblfront.Invoke((MethodInvoker)delegate () {
                        lblfront.ForeColor = Color.Red;
                    });
                    frontisRed = true;
                }
                else
                {
                    lblfront.Invoke((MethodInvoker)delegate () {
                        lblfront.ForeColor = Color.White;
                    });
                    frontisRed = false;
                }
            }
            if (backsecondcnt >= maxcnt)
            {
                if (!backisRed)
                {
                    lblback.Invoke((MethodInvoker)delegate () {
                        lblback.ForeColor = Color.Red;
                    });
                    backisRed = true;
                }
                else
                {
                    lblback.Invoke((MethodInvoker)delegate () {
                        lblback.ForeColor = Color.White;
                    });
                    backisRed = false;
                }
            }
            frontsecondcnt++;
            backsecondcnt++;

        }

        private void lblfront_Click(object sender, EventArgs e)
        {
            lblfrontClickAction();
        }

        private void lblfrontClickAction()
        {
            lblfront.Invoke((MethodInvoker)delegate ()
            {
                lblfront.ForeColor = Color.White;
            });
            frontisRed = false;
            NodeGroup_FrontUpper.AlarmClear();
            NodeGroup_FrontLower.AlarmClear();
            frontsecondcnt = 0;
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            lblbackClickAction();

        }

        private void lblbackClickAction()
        {
            lblback.Invoke((MethodInvoker)delegate ()
            {
                lblback.ForeColor = Color.White;
            });
            backisRed = false;
            NodeGroup_BackUpper.AlarmClear();
            NodeGroup_BackLower.AlarmClear();
            backsecondcnt = 0;
        }

        private void lbl_MoldName_Click(object sender, EventArgs e)
        {
            lblfrontClickAction();
            lblbackClickAction();

        }
    }
}
