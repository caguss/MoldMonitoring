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
        #region MoldManager
        public bool modalisOpen = false;
        #endregion

        System.Threading.Timer _tmrSecondTimer = null;
        public int frontsecondcnt = 0; // 안들어온 초를 세기위한 함수 --DB상 센서카운트 14개가 안된다면 cnt 올림?? 구상 필요
        public int backsecondcnt = 0; // 안들어온 초를 세기위한 함수 --DB상 센서카운트 14개가 안된다면 cnt 올림?? 구상 필요


        public int maxcnt = 10; // secondcnt와의 비교하기 위한 함수. 해당 함수의 수만큼 데이터가 들어오지 않을경우 빨간색 점멸

        public MonitoringForm()
        {
            InitializeComponent();
            uc_GraphOption1.Dispose();
            uc_GraphOption1 = new uc_GraphOption(_chartMstView);
            this.uc_GraphOption1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.uc_GraphOption1, 3);
            this.uc_GraphOption1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_GraphOption1.Location = new System.Drawing.Point(1408, 657);
            this.uc_GraphOption1.Margin = new System.Windows.Forms.Padding(0);
            this.uc_GraphOption1.Name = "uc_GraphOption1";
            this.uc_GraphOption1.Size = new System.Drawing.Size(496, 70);
            this.uc_GraphOption1.TabIndex = 34;
            this.tableLayoutPanel1.Controls.Add(this.uc_GraphOption1, 2, 2);

            _tmrSecondTimer = new System.Threading.Timer(_tmrConnection_Callback, null, 3000, 2000);
            //lbl_MoldName.Font = Program.BigFont;
            //lblback.Font = Program.TitleFont;
            //lblfront.Font = Program.TitleFont;

            //1.금형 Init
            lbl_MoldName.Text = Properties.Settings.Default.LastMoldName;
            //2.센서별 상하한치 Init
            DataTable dt;
            DataConnector con = new DataConnector();
            dt = con.monitoring_sensor_R30();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                switch (dt.Rows[i]["gr"].ToString())
                {
                    case "1": //전면 상단
                        NodeGroup_FrontUpper.ChangeNodeLimitValue(dt.Rows[i]["rsc"].ToString(), dt.Rows[i]["limit_high"].ToString(), dt.Rows[i]["limit_low"].ToString());
                        break;
                    case "2": //전면 하단
                        NodeGroup_FrontLower.ChangeNodeLimitValue(dt.Rows[i]["rsc"].ToString(), dt.Rows[i]["limit_high"].ToString(), dt.Rows[i]["limit_low"].ToString());
                        break;
                    case "3": //후면 상단
                        NodeGroup_BackUpper.ChangeNodeLimitValue(dt.Rows[i]["rsc"].ToString(), dt.Rows[i]["limit_high"].ToString(), dt.Rows[i]["limit_low"].ToString());
                        break;
                    case "4": //후면 하단
                        NodeGroup_BackLower.ChangeNodeLimitValue(dt.Rows[i]["rsc"].ToString(), dt.Rows[i]["limit_high"].ToString(), dt.Rows[i]["limit_low"].ToString());
                        break;
                    default:
                        break;
                }
            }


        }
        private void _tmrConnection_Callback(object state)
        {
            #region connection 끊김시 전면 후면 깜빡임
            //센서별 끊긴 센서의 최대치 불러오는 코드 필요
            if (frontsecondcnt >= maxcnt)
            {
                if (!frontisRed)
                {

                    lblfront.Invoke((MethodInvoker)delegate ()
                    {
                        lblfront.ForeColor = Color.Red;
                    });
                    frontisRed = true;
                }
                else
                {
                    lblfront.Invoke((MethodInvoker)delegate ()
                    {
                        lblfront.ForeColor = Color.White;
                    });
                    frontisRed = false;
                }
            }
            if (backsecondcnt >= maxcnt)
            {
                if (!backisRed)
                {
                    lblback.Invoke((MethodInvoker)delegate ()
                    {
                        lblback.ForeColor = Color.Red;
                    });
                    backisRed = true;
                }
                else
                {
                    lblback.Invoke((MethodInvoker)delegate ()
                    {
                        lblback.ForeColor = Color.White;
                    });
                    backisRed = false;
                }
            }
            frontsecondcnt++;
            backsecondcnt++;
            #endregion
            try
            {
                DataConnector con = new DataConnector();
                DataSet ds = con.monitoring_sensor_R10();
                //ds.Tables[0] : 태그별 온도 센서
                //ds.Tables[1] : IN/OUT 유량
                //ds.Tables[2] : 알람 건수
                //ds.Tables[3] : 타공수
                //ds.Tables[4] : PLC 데이터

                #region 온도 데이터 Load

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    switch (ds.Tables[0].Rows[i]["gr"].ToString())
                    {
                        case "1": //전면 상단
                            NodeGroup_FrontUpper.ChangeNodeValue(ds.Tables[0].Rows[i]["rsc"].ToString(), ds.Tables[0].Rows[i]["vl"].ToString());
                            break;
                        case "2": //전면 하단
                            NodeGroup_FrontLower.ChangeNodeValue(ds.Tables[0].Rows[i]["rsc"].ToString(), ds.Tables[0].Rows[i]["vl"].ToString());
                            break;
                        case "3": //후면 상단
                            NodeGroup_BackUpper.ChangeNodeValue(ds.Tables[0].Rows[i]["rsc"].ToString(), ds.Tables[0].Rows[i]["vl"].ToString());
                            break;
                        case "4": //후면 하단
                            NodeGroup_BackLower.ChangeNodeValue(ds.Tables[0].Rows[i]["rsc"].ToString(), ds.Tables[0].Rows[i]["vl"].ToString());
                            break;
                        default:
                            break;
                    }
                }

                #endregion

                #region 유량, 냉각수 Load
                for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                {
                    switch (ds.Tables[1].Rows[i]["gr"].ToString())
                    {
                        case "1": //전면 상단
                            if (ds.Tables[1].Rows[i]["rsc"].ToString() == "10" || ds.Tables[1].Rows[i]["rsc"].ToString() == "8")
                                InnerData_FrontUpper.ChangeData((ds.Tables[1].Rows[i]["rsc"].ToString() == "10") ? true : false, ds.Tables[1].Rows[i]["vl"].ToString());
                            else
                                OuterData_FrontUpper.ChangeData((ds.Tables[1].Rows[i]["rsc"].ToString() == "11") ? true : false, ds.Tables[1].Rows[i]["vl"].ToString());
                            break;
                        case "2": //전면 하단
                            if (ds.Tables[1].Rows[i]["rsc"].ToString() == "10" || ds.Tables[1].Rows[i]["rsc"].ToString() == "8")
                                InnerData_FrontLower.ChangeData((ds.Tables[1].Rows[i]["rsc"].ToString() == "10") ? true : false, ds.Tables[1].Rows[i]["vl"].ToString());
                            else
                                OuterData_FrontLower.ChangeData((ds.Tables[1].Rows[i]["rsc"].ToString() == "11") ? true : false, ds.Tables[1].Rows[i]["vl"].ToString());
                            break;
                        case "3": //후면 상단
                            if (ds.Tables[1].Rows[i]["rsc"].ToString() == "10" || ds.Tables[1].Rows[i]["rsc"].ToString() == "8")
                                InnerData_BackUpper.ChangeData((ds.Tables[1].Rows[i]["rsc"].ToString() == "10") ? true : false, ds.Tables[1].Rows[i]["vl"].ToString());
                            else
                                OuterData_BackUpper.ChangeData((ds.Tables[1].Rows[i]["rsc"].ToString() == "11") ? true : false, ds.Tables[1].Rows[i]["vl"].ToString());
                            break;
                        case "4": //후면 하단
                            if (ds.Tables[1].Rows[i]["rsc"].ToString() == "10" || ds.Tables[1].Rows[i]["rsc"].ToString() == "8")
                                InnerData_BackLower.ChangeData((ds.Tables[1].Rows[i]["rsc"].ToString() == "10") ? true : false, ds.Tables[1].Rows[i]["vl"].ToString());
                            else
                                OuterData_BackLower.ChangeData((ds.Tables[1].Rows[i]["rsc"].ToString() == "11") ? true : false, ds.Tables[1].Rows[i]["vl"].ToString());
                            break;
                        default:
                            break;
                    }
                }
                #endregion
                #region 알림 갯수 Load
                uc_Alert1.AlertLoad(ds.Tables[2].Rows[0]["cnt"].ToString());
                #endregion
                #region press 타공 횟수 Load
                uc_PressCount2.PressCntLoad(ds.Tables[3].Rows[0]["Totalcnt"].ToString(), ds.Tables[3].Rows[0]["Todaycnt"].ToString());
                #endregion
                #region PLC 데이터 Load
                for (int i = 0; i < ds.Tables[4].Rows.Count; i++)
                {
                    //14 작동유유량, 15 작동유온도
                    uc_WorkingData1.ChangeData((ds.Tables[4].Rows[i]["rsc"].ToString() == "15") ? true : false, ds.Tables[4].Rows[i]["vl"].ToString());
                }

                #endregion
            }
            catch (Exception ex)
            {
            }

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
            if (!modalisOpen)
            {
                Popup_MoldManager modal = new Popup_MoldManager(this);
                modal.Show();
            }
        }

        private void MonitoringForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LastMoldName = lbl_MoldName.Text;
            if (Popup_MoldManager.selectedMoldCode != null)
            {
                Properties.Settings.Default.LastMoldCode = Popup_MoldManager.selectedMoldCode;
            }
            Properties.Settings.Default.Save();
        }
    }
}
