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
    public partial class uc_GraphOption : UserControl
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


        //추후 rsc로 변경하는 작업 필요
        public string Selectedsensor { get => selectedsensor; set => selectedsensor = value; }
        public string SelectedTime { get => selectedtime; set => selectedtime = value; }

        private DataTable sensor_mst;
        private string selectedsensor;
        private string selectedtime;
        public uc_GraphOption()
        {
            InitializeComponent();
            //foreach (var item in tableLayoutPanel1.Controls)
            //{
            //    if (item.GetType() == typeof(Label))
            //    {
            //        ((Label)item).Font = Program.DescriptionFont;

            //    }
            //}

            AddTimeOptionItems(); //시간선택 데이터
            AddSensorOptionItems(); //센서선택 데이터
        }



        /// <summary>
        /// 콤보박스 Item 저장
        /// </summary>
        private void AddTimeOptionItems()
        {
            cb_TimeOption.Items.Add("1분");
            cb_TimeOption.Items.Add("15분");
            cb_TimeOption.Items.Add("30분");
            cb_TimeOption.Items.Add("1시간");
            cb_TimeOption.Items.Add("3시간");
            cb_TimeOption.Items.Add("12시간");
            cb_TimeOption.Items.Add("24시간");
            cb_TimeOption.Items.Add("7일");
        }
        /// <summary>
        /// test method
        /// </summary>
        private void AddSensorOptionItems()
        {
            //try
            //{
            //    DataConnector con = new DataConnector();
            //    sensor_mst = con.mornitoring_Graph_R10();
            //    for (int i = 0; i < sensor_mst.Rows.Count; i++)
            //    {
            //        cb_SensorOption.Items.Add(sensor_mst.Rows[i]["rsn"].ToString());
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;

            //}


        }
    }
}
