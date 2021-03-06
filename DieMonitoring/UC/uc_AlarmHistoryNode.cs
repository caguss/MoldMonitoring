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
    public partial class uc_AlarmHistoryNode : UserControl
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
        string logseq;

        public uc_AlarmHistoryNode()
        {
            InitializeComponent();
        }

        public uc_AlarmHistoryNode(string seq, string alarmString, DateTime OccurTime)
        {
            InitializeComponent();
            logseq = seq;
            lbl_AlarmString.Text = alarmString;
            lbl_OccurTime.Text = OccurTime.ToString("yyyy-mm-dd tt hh:mm:ss");
        }
        public uc_AlarmHistoryNode(string seq,string alarmString, string OccurTime)
        {
            InitializeComponent();
            logseq = seq;
            lbl_AlarmString.Text = alarmString;
            lbl_OccurTime.Text = OccurTime;
        }

        private void lbl_DeleteAlarm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 삭제하시겠습니까? 삭제 이후 알람이 보여지지 않습니다.", "경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ChangeUseYN();
            } 
            
        }

        private void lbl_CheckAlarm_Click(object sender, EventArgs e)
        {
            ChangeCheckYN();
        }
        public void ChangeCheckYN()
        {
            //DB CheckYN 변경
            DataConnector con = new DataConnector();
            con.monitoring_AlarmList_U10(logseq);
        }

        public void ChangeUseYN()
        {
            //DB UseYN 변경
            DataConnector con = new DataConnector();
            con.monitoring_AlarmList_D10(logseq);
        }
    }
}
