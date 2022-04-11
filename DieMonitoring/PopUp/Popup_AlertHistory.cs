using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieMonitoring
{
    public partial class Popup_AlertHistory : CustomPopUp
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

        object parentdata;
        string parentType = "";
        string filter_CheckYN = "N";
        int nowalarmcnt = 0;
        bool isworking = false;
        DateTime opentime = DateTime.Now;
        System.Threading.Timer _tmr10SecondTimer = null;

        public Popup_AlertHistory(uc_AlarmHistory parent)
        {
            InitializeComponent();
            _tmr10SecondTimer = new System.Threading.Timer(_tmrCheckAlarm_Callback, null, 3000, 10000);
            parentdata = parent;
            parentType = parent.GetType().ToString();
            lbl_FormName.Text = "알람이력";

            DataConnector con = new DataConnector();
            DataTable dt = con.monitoring_AlarmList_R10("A");
            nowalarmcnt = dt.Rows.Count;
            for (int i = 0; i < nowalarmcnt; i++)
            {
                string errstr = ErrorStringMaker(dt.Rows[i]["alarmCode"].ToString(), dt.Rows[i]["gr"].ToString(), dt.Rows[i]["rsc"].ToString());

                AlarmAdd(dt.Rows[i]["seq"].ToString(), errstr, dt.Rows[i]["alarm_date"].ToString());
            }
            tlp_ControlPanel.Focus();

            filter_CheckYN = "A";
        }
        public Popup_AlertHistory(uc_Alert parent)
        {
            InitializeComponent();
            _tmr10SecondTimer = new System.Threading.Timer(_tmrCheckAlarm_Callback, null, 3000, 5000);
            parentdata = parent;
            parentType = parent.GetType().ToString();
            lbl_FormName.Text = "알람이력";


            DataConnector con = new DataConnector();
            DataTable dt = con.monitoring_AlarmList_R10("N");
            nowalarmcnt = dt.Rows.Count;
            for (int i = 0; i < nowalarmcnt; i++)
            {
                string errstr = ErrorStringMaker(dt.Rows[i]["alarmCode"].ToString(), dt.Rows[i]["gr"].ToString(), dt.Rows[i]["rsc"].ToString());

                AlarmAdd(dt.Rows[i]["seq"].ToString(), errstr, dt.Rows[i]["alarm_date"].ToString());
            }
            tlp_ControlPanel.Focus();

            filter_CheckYN = "N";
        }
        private static string ErrorStringMaker(string alarmcode,string gr, string rsc)
        {
            string errstr = "";
            if (alarmcode == "")
            {
                errstr = $"에러코드가 존재하지 않습니다.";

            }
            else
            {
                string errcode = alarmcode.Substring(2);
                string sensorType = errcode.Substring(0, 2);
                string errorType = errcode.Substring(2);
                string errstrsenType = "";
                string errstrerrtype = "";
                switch (sensorType)
                {
                    case "01":
                        errstrsenType = "온도";
                        break;
                    case "02":
                        errstrsenType = "외부";
                        break;
                    case "04":
                        errstrsenType = "유량";
                        break;
                    case "08":
                        errstrsenType = "냉각수";
                        break;
                    case "10":
                        errstrsenType = "냉각수";
                        break;
                    case "11":
                        errstrsenType = "냉각수";
                        break;
                    case "12":
                        errstrsenType = "외부 온도";
                        break;
                    case "13":
                        errstrsenType = "외부 습도";
                        break;
                    case "14":
                        errstrsenType = "작동유 온도";
                        break;
                    case "15":
                        errstrsenType = "작동유 유압";
                        break;
                    default:
                        break;
                }
                switch (errorType)
                {
                    case "01":
                        errstrerrtype = "상한치";
                        break;
                    case "02":
                        errstrerrtype = "하한치";
                        break;
                    default:
                        break;
                }

                errstr = $"{errstrsenType} 센서 {gr}-{rsc}에서 {errstrerrtype} 이상이 발생하였습니다.";
            }

            return errstr;
        }

      

        private void _tmrCheckAlarm_Callback(object state)
        {
            if (!isworking)
            {
                if (nowalarmcnt < 100)
                {
                    try
                    {
                        DataConnector con = new DataConnector();
                        DataTable dt = con.monitoring_AlarmList_R10("N");
                        isworking = true;
                        while (nowalarmcnt < 100)
                        {
                            for (int i = 0; i < nowalarmcnt; i++)
                            {
                                CrossThreadSafeAlarmAdd(dt.Rows[i]["seq"].ToString(), dt.Rows[i]["seq"].ToString(), dt.Rows[i]["alarm_date"].ToString());
                                nowalarmcnt++;
                            }
                        }
                        isworking = false;

                    }
                    catch (Exception ex)
                    {
                    }

                }
                filter_CheckYN = "N";
              
                isworking = false;

            }

        }

        private void Popup_AlertHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            while (isworking)
            {

            }
            switch (parentType)
            {
                case "DieMonitoring.uc_Alert":
                    ((uc_Alert)parentdata).modalIsOpen = false;
                    break;
                case "DieMonitoring.uc_AlarmHistory":
                    ((uc_AlarmHistory)parentdata).modalIsOpen = false;
                    break;
            }
        }

        private void Popup_AlertHistory_Load(object sender, EventArgs e)
        {
            switch (parentType)
            {
                case "DieMonitoring.uc_Alert":
                    ((uc_Alert)parentdata).modalIsOpen = true;
                    break;
                case "DieMonitoring.uc_AlarmHistory":
                    ((uc_AlarmHistory)parentdata).modalIsOpen = true;
                    break;
            }
        }
        private void CheckAlarm(object sender, EventArgs e)
        {
            DeleteControl(((Label)sender).Parent.Parent.Parent);
        }
      

        private void DeleteControl(Control parent)
        {
            var cellposi = tlp_alarmlist.GetPositionFromControl(parent);
            parent.Dispose();
            tlp_alarmlist.RowStyles.RemoveAt(cellposi.Row);
        }

        private void CrossThreadSafeAlarmAdd(string seq,string alarmstring, string datetime)
        {
            uc_AlarmHistoryNode data = new uc_AlarmHistoryNode(seq,alarmstring + tlp_alarmlist.RowCount, datetime);
            data.Name = "data" + tlp_alarmlist.RowCount;
            data.lbl_DeleteAlarm.Click += CheckAlarm;
            data.lbl_CheckAlarm.Click += CheckAlarm;
            data.Visible = true;
            data.Dock = DockStyle.Fill;

            tlp_alarmlist.Invoke((MethodInvoker)delegate ()
            {
                tlp_alarmlist.RowStyles.Insert(0, new RowStyle(SizeType.Absolute, 60f));
                tlp_alarmlist.Controls.Add(data, 0, 0);
            });

        }

        private void AlarmAdd(string seq, string alarmstring, string datetime)
        {
            uc_AlarmHistoryNode data = new uc_AlarmHistoryNode(seq,alarmstring, datetime);
            data.Name = "data" + tlp_alarmlist.RowCount;
            data.lbl_CheckAlarm.Click += CheckAlarm;
            data.lbl_DeleteAlarm.Click += CheckAlarm;
            data.Visible = true;
            data.Dock = DockStyle.Fill;

            tlp_alarmlist.RowStyles.Insert(0, new RowStyle(SizeType.Absolute, 60f));
            tlp_alarmlist.Controls.Add(data, 0, 0);

        }

        private void Popup_AlertHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            _tmr10SecondTimer.Change(Timeout.Infinite, Timeout.Infinite);
            Thread.Sleep(500);
        }

        private void lbl_DeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 삭제하시겠습니까? 삭제 이후 알람이 보여지지 않습니다.", "경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                isworking = true;
                tlp_alarmlist.Refresh();

                try
                {
                    int clearcnt = 0;
                    while (clearcnt != nowalarmcnt)
                    {
                        var ctl = (uc_AlarmHistoryNode)tlp_alarmlist.GetControlFromPosition(0, 0);
                        ctl.ChangeUseYN();
                        DeleteControl(ctl);
                        clearcnt++;
                    }
                    nowalarmcnt = 0;
                }
                catch (Exception)
                {
                    isworking = false;

                }
                isworking = false;

            }
        }

        private void lbl_CheckAll_Click(object sender, EventArgs e)
        {
            tlp_alarmlist.Refresh();
            isworking = true;

            try
            {
                int clearcnt = 0;
                while (clearcnt != nowalarmcnt)
                {
                    var ctl = (uc_AlarmHistoryNode)tlp_alarmlist.GetControlFromPosition(0, 0);
                    ctl.ChangeCheckYN();
                    DeleteControl(ctl);
                    clearcnt++;
                }
                nowalarmcnt = 0;
            }
            catch (Exception)
            {
                isworking = false;
            }
            isworking = false;

        }
    }
}
