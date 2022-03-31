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
        public uc_GraphOption()
        {
            InitializeComponent();
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item.GetType() == typeof(Label))
                {
                    ((Label)item).Font = Program.DescriptionFont;

                }
            }
            

            AddTimeOptionItems(); //시간선택 데이터
            AddSensorOptionItems(); //시간선택 데이터
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
            cb_TimeOption.Items.Add("31일");
        }
        /// <summary>
        /// test method
        /// </summary>
        private void AddSensorOptionItems()
        {
            cb_SensorOption.Items.Add("센서1");
            cb_SensorOption.Items.Add("센서2");
            cb_SensorOption.Items.Add("센서3");
            cb_SensorOption.Items.Add("센서4");
            cb_SensorOption.Items.Add("센서5");
            cb_SensorOption.Items.Add("센서6");
            cb_SensorOption.Items.Add("센서7");
            cb_SensorOption.Items.Add("센서8");
            cb_SensorOption.Items.Add("센서9");
            cb_SensorOption.Items.Add("센서10");
            cb_SensorOption.Items.Add("센서11");
            cb_SensorOption.Items.Add("센서12");
            cb_SensorOption.Items.Add("센서13");
            cb_SensorOption.Items.Add("센서14");
            cb_SensorOption.Items.Add("센서15");
            cb_SensorOption.Items.Add("센서16");
            cb_SensorOption.Items.Add("센서17");
            cb_SensorOption.Items.Add("센서18");
            cb_SensorOption.Items.Add("센서19");
            cb_SensorOption.Items.Add("센서20");
            cb_SensorOption.Items.Add("센서21");
            cb_SensorOption.Items.Add("센서22");
            cb_SensorOption.Items.Add("센서23");
            cb_SensorOption.Items.Add("센서24");
        }


    }
}
