using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieMonitoring
{
    public partial class Popup_Setting : CustomPopUp
    {
        uc_OptionButton parentdata;
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
        public Popup_Setting(uc_OptionButton parent)
        {
            InitializeComponent();

            parentdata = parent;
            lbl_FormName.Text = "옵션설정";

            try
            {
                DataConnector con = new DataConnector();
                DataSet ds = con.monitoring_Setting_R10();
                //ds[0] : 그룹별 이름
                //ds[1] : 센서별 이름

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    lb_GroupList.Items.Add($"{ds.Tables[0].Rows[i]["gr"].ToString()}");
                }
                for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                {
                    lb_SensorList.Items.Add($"{ds.Tables[1].Rows[i]["gr"].ToString()}-{ds.Tables[1].Rows[i]["rsc"].ToString()}");
                }
            }
            catch (Exception)
            {

                throw;

            }

        }

        private void Popup_Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentdata.modalIsOpen = false;
        }

        private void Popup_Setting_Load(object sender, EventArgs e)
        {
            parentdata.modalIsOpen = true;
        }

        private void lb_GroupList_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_selectedGroup.Texts = lb_GroupList.SelectedItem.ToString();
        }

        private void lb_SensorList_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_selectedSensor.Texts = lb_SensorList.SelectedItem.ToString();
            DataConnector con = new DataConnector();
            DataTable dt = con.monitoring_Setting_R20(txt_selectedSensor.Texts.Split('-')[0], txt_selectedSensor.Texts.Split('-')[1]);
            if (dt.Rows.Count > 0)
            {
                txt_sensor_High.Texts = dt.Rows[0]["limit_high"].ToString();
                txt_sensor_Low.Texts = dt.Rows[0]["limit_low"].ToString();
            }
        }

        private void lbl_groupSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("경고", "그룹별 센서 상하한치를 저장하시겠습니까? 그룹 내 전체의 센서의 상하한치가 변경됩니다.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataConnector con = new DataConnector();
                try
                {
                    con.monitoring_Setting_U10(txt_selectedGroup.Texts, txt_group_High.Texts, txt_group_Low.Texts);
                    MessageBox.Show("저장이 완료되었습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"에러가 발생했습니다. 관리자에게 문의해 주세요. {ex.Message}");
                }
            }
        }

        private void lbl_sensorSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("경고", "센서별 센서 상하한치를 저장하시겠습니까?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataConnector con = new DataConnector();
                try
                {
                    con.monitoring_Setting_U20(txt_selectedSensor.Texts.Split('-')[0], txt_selectedSensor.Texts.Split('-')[1], txt_group_High.Texts, txt_group_Low.Texts);
                    MessageBox.Show("저장이 완료되었습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"에러가 발생했습니다. 관리자에게 문의해 주세요. {ex.Message}");
                }
            }
        }
    }
}
