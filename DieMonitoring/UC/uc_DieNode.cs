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
    public partial class uc_DieNode : UserControl
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

        public double high_limit = 30;
        public double low_limit = 10;
        private string nodenumber = "0";

        [Category("RJ Code - Appearance")]
        public string NodeNumber
        {
            get { return nodenumber; }
            set
            {
                nodenumber = value;
                lblNodeNum.Text = nodenumber; //Border Color
            }
        }


        public uc_DieNode()
        {
            InitializeComponent();
            
            //lblValue.Font = Program.TitleFont;
            //lblNodeNum.Font = Program.Normalfont;
            //lbl_format.Font = Program.Normalfont;
        }

        public void SetLimit(string high_value, string low_value)
        {
            high_limit = Convert.ToDouble(high_value);
            low_limit = Convert.ToDouble(low_value);
        }

        public void ChangeValue(string value)
        {
            lblValue.Invoke((MethodInvoker)delegate () {
                lblValue.Text = ((int)Convert.ToDouble(value)).ToString();
            });
            if (Convert.ToDouble(value) >= high_limit || Convert.ToDouble(value) <= low_limit)
            {
                RedAlarm();
            }
            else
            {
                SafeAlarm();
            }



        }
        public void ChangeValue(int value)
        {
            lblValue.Invoke((MethodInvoker)delegate () {
                lblValue.Text = value.ToString();
            });
            if (Convert.ToDouble(value) >= high_limit || Convert.ToDouble(value) <= low_limit)
            {
                RedAlarm();
            }
            else
            {
                SafeAlarm();
            }



        }

        public void SafeAlarm()
        {
            lblNodeNum.Invoke((MethodInvoker)delegate () {
                lblNodeNum.BackColor = Color.Transparent;
            });

            lblValue.Invoke((MethodInvoker)delegate () {
                lblValue.ForeColor = Color.White;
            });
            lbl_format.Invoke((MethodInvoker)delegate () {
                lbl_format.ForeColor = Color.White;
            });

        }

        public void RedAlarm()
        {
            lblNodeNum.Invoke((MethodInvoker)delegate () {
                lblNodeNum.BackColor = Color.Red;
            });

            lblValue.Invoke((MethodInvoker)delegate () {
                lblValue.ForeColor = Color.Red;
            });
            lbl_format.Invoke((MethodInvoker)delegate () {
                lbl_format.ForeColor = Color.Red;
            });

        }
    }
}
