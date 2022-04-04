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

        uc_AlarmHistory parentdata;
        DateTime opentime = DateTime.Now;
        System.Threading.Timer _tmr5SecondTimer = null;

        public Popup_AlertHistory(uc_AlarmHistory parent)
        {
            InitializeComponent();
            _tmr5SecondTimer = new System.Threading.Timer(_tmrCheckAlarm_Callback, null, 10000, 5000);
            parentdata = parent;
            lbl_FormName.Text = "알람이력";

            for (int i = 0; i < 20; i++)
            {
                AlarmAdd(i.ToString());
            }
            tlp_ControlPanel.Focus();
        }

        private void _tmrCheckAlarm_Callback(object state)
        {
            //opentime과 비교하여 이후 들어오는 새로운 알람이 있는 경우 tlp_alarmlist에 추가
            if (true)
            {
                CrossThreadSafeAlarmAdd("test");
            }
        }

        private void Popup_AlertHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentdata.modalIsOpen = false;
        }

        private void Popup_AlertHistory_Load(object sender, EventArgs e)
        {
            parentdata.modalIsOpen = true;
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

        private void CrossThreadSafeAlarmAdd(string alarmstring)
        {
            uc_AlarmHistoryNode data = new uc_AlarmHistoryNode(alarmstring + tlp_alarmlist.RowCount, DateTime.Now);
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

        private void AlarmAdd(string alarmstring)
        {
            uc_AlarmHistoryNode data = new uc_AlarmHistoryNode(alarmstring,DateTime.Now);
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
            _tmr5SecondTimer.Change(Timeout.Infinite, Timeout.Infinite);
            Thread.Sleep(500);
        }

        private void lbl_DeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 삭제하시겠습니까? 삭제 이후 알람이 보여지지 않습니다.", "경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tlp_alarmlist.Refresh();

                try
                {
                    while (tlp_alarmlist.RowCount == 1)
                    {
                        var ctl = (uc_AlarmHistoryNode)tlp_alarmlist.GetControlFromPosition(0, 0);
                        ctl.ChangeUseYN();
                        DeleteControl(ctl);
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void lbl_CheckAll_Click(object sender, EventArgs e)
        {
            tlp_alarmlist.Refresh();

            try
            {
                while (tlp_alarmlist.RowCount == 1)
                {
                    var ctl = (uc_AlarmHistoryNode)tlp_alarmlist.GetControlFromPosition(0, 0);
                    ctl.ChangeCheckYN();
                    DeleteControl(ctl);
                }
            }
            catch (Exception)
            {
            }

        }
    }
}
