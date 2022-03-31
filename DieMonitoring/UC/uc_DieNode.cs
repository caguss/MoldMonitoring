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
        System.Threading.Timer _tmrSecondTimer = null;
        public bool isRed = false;
        public int secondcnt = 0; // 안들어온 초를 세기위한 함수
        public int maxcnt = 10; // secondcnt와의 비교하기 위한 함수. 해당 함수의 수만큼 데이터가 들어오지 않을경우 빨간색 점멸

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
            
            lblValue.Font = Program.TitleFont;
            lblNodeNum.Font = Program.Normalfont;
            lbl_format.Font = Program.Normalfont;
            _tmrSecondTimer = new System.Threading.Timer(_tmrConnectionError_Callback, null, 1000, 1000);
        }

   

        public void ChangeValue(string value)
        {
            lblValue.Text = value + "℃";
            CheckAlarm();
          

        }
        public void ChangeValue(decimal value)
        {
            lblValue.Text = value.ToString() + "℃";
            CheckAlarm();


        }

        public void CheckAlarm()
        {
            lblNodeNum.Invoke((MethodInvoker)delegate () {
                lblNodeNum.BackColor = Color.Transparent;
            });

            lblValue.Invoke((MethodInvoker)delegate () {
                lblValue.ForeColor = Color.White;
            });


            secondcnt = 0;
            isRed = false;
        }
        private void _tmrConnectionError_Callback(object state)
        {
            if (secondcnt >= maxcnt)
            {
                if (!isRed)
                {

                    lblNodeNum.Invoke((MethodInvoker)delegate () {
                        lblNodeNum.BackColor = Color.Red;
                    });


                    lblValue.Invoke((MethodInvoker)delegate () {
                        lblValue.ForeColor = Color.Red;
                    });
                    isRed = true;
                }
                
                //else
                //{
                //    CSafeSetColor(lblValue, Color.FromArgb(163, 252, 78));
                //    isRed = false;

                //}
            }


            secondcnt++;

        }
    


        /// <summary>
        /// test method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Node_Click(object sender, EventArgs e)
        {
            ChangeValue(Convert.ToDecimal(10.001));
        }
 
    }
}
