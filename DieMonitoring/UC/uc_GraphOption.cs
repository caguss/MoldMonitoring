using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;

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
        System.Threading.Timer _GraphTmr;// 그래프 새로고침용 타이머


        private string AllSelect = "전체";
        private DataTable summary_table = new DataTable();

        int _GridSpacing = 1;
        int MaxDataCount = 100; // 최대 표시개수 100개

        private ChartControl _chartMstView;
        public uc_GraphOption()
        {
            InitializeComponent();
        }

        public uc_GraphOption(ChartControl parentchart)
        {
            InitializeComponent();
            try
            {
                AddTimeOptionItems(); //시간선택 데이터
                AddSensorOptionItems(); //센서선택 데이터
                cb_SensorOption.SelectedIndex = 0;
                cb_TimeOption.SelectedIndex = 0;

                cb_SensorOption.OnSelectedIndexChanged += cb_option_OnSelectedIndexChanged;
                cb_TimeOption.OnSelectedIndexChanged += cb_option_OnSelectedIndexChanged;

                _chartMstView = parentchart;

                // 마우스를 올리면 해당 위치에 값이 보임
                _chartMstView.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.True;
                _chartMstView.CrosshairOptions.ShowGroupHeaders = true; // X축 시간값 표시

                // 범례 체크박스로 변경
                _chartMstView.Legend.MarkerMode = LegendMarkerMode.CheckBox;
                _chartMstView.Legend.MaxHorizontalPercentage = 100;
            }
            catch (Exception)
            {

            }
        }
        string selectedgroup;
        string selectedsensor;
        int selectedtime;
        private void RefreshGraphCallback(object state)
        {
            try
            {


                DataConnector con = new DataConnector();
                if (selectedgroup == "99")
                {
                    summary_table = con.monitoring_summary_R20(selectedtime);
                    if (this.InvokeRequired)
                        BeginInvoke(new Action(DrawingPressGraph));
                }
                else
                {
                    summary_table = con.monitoring_summary_R10(selectedgroup, selectedsensor, selectedtime);
                    if (this.InvokeRequired)
                        BeginInvoke(new Action(DrawingGraph));
                }
            }
            catch (Exception ex)
            {
            }
        }
        bool _isDrawing = false;

        private void DrawingGraph()
        {
            if (!_isDrawing)
            {
                _isDrawing = true;

                foreach (DataRow data in summary_table.Rows)
                {
                    Series _Series_Param = new Series($"{data["gr"].ToString()}-{data["rsc"].ToString()}", ViewType.Line);
                    DateTimeOffset _ts = Convert.ToDateTime(data["stSenDate"].ToString());
                    bool _SeriesCheck = false;
                    foreach (Series series in _chartMstView.Series)
                    {
                        if (series.Name == $"{data["gr"].ToString()}-{data["rsc"].ToString()}")
                        {
                            _SeriesCheck = true;
                        }
                    }
                    if (_SeriesCheck)
                    {
                        if (_chartMstView.Series[$"{data["gr"].ToString()}-{data["rsc"].ToString()}"].Points.Last().ArgumentX.DateTimeArgument != _ts.DateTime)
                        {
                            SeriesPoint sp = new SeriesPoint(_ts.ToString(), data["vl"].ToString());
                            _chartMstView.Series[$"{data["gr"].ToString()}-{data["rsc"].ToString()}"].Points.Add(sp);
                        }

                        // 갯수가 {MaxDataCount}개 이상일 경우 초과분만큼 데이터 지움
                        if (_chartMstView.Series[$"{data["gr"].ToString()}-{data["rsc"].ToString()}"].Points.Count > MaxDataCount)
                        {
                            _chartMstView.Series[$"{data["gr"].ToString()}-{data["rsc"].ToString()}"].Points.RemoveRange(0, _chartMstView.Series[$"{data["gr"].ToString()}-{data["rsc"].ToString()}"].Points.Count - MaxDataCount);
                        }
                    }
                    else
                    {
                        GraphSeriesAdd(_Series_Param);
                        SeriesPoint sp = new SeriesPoint(_ts.ToString(), data["vl"].ToString());
                        _chartMstView.Series[$"{data["gr"].ToString()}-{data["rsc"].ToString()}"].Points.Add(sp);
                    }

                }
                _isDrawing = false;
                _chartMstView.Invoke((MethodInvoker)delegate ()
                {
                    _chartMstView.RefreshData();
                    _chartMstView.Update();
                    _chartMstView.Refresh();
                });
            }
        }
        private void DrawingPressGraph()
        {
            if (!_isDrawing)
            {
                _isDrawing = true;

                foreach (DataRow data in summary_table.Rows)
                {
                    Series _Series_Param_AVG = new Series($"{data["moldCode"].ToString()} 평균", ViewType.Line);
                    Series _Series_Param_MIN = new Series($"{data["moldCode"].ToString()} 최소", ViewType.Line);
                    Series _Series_Param_MAX = new Series($"{data["moldCode"].ToString()} 최대", ViewType.Line);
                    DateTimeOffset _ts = Convert.ToDateTime(data["stdt"].ToString());
                    bool _SeriesCheck = false;
                    foreach (Series series in _chartMstView.Series)
                    {
                        if (series.Name == $"{data["moldCode"].ToString()} 평균")
                        {
                            _SeriesCheck = true;
                        }
                    }
                    if (_SeriesCheck)
                    {
                        if (_chartMstView.Series[$"{data["moldCode"].ToString()} 평균"].Points.Last().ArgumentX.DateTimeArgument != _ts.DateTime)
                        {
                            SeriesPoint sp = new SeriesPoint(_ts.ToString(), data["avg_vl"].ToString());
                            _chartMstView.Series[$"{data["moldCode"].ToString()} 평균"].Points.Add(sp);
                            sp = new SeriesPoint(_ts.ToString(), data["min_vl"].ToString());
                            _chartMstView.Series[$"{data["moldCode"].ToString()} 최소"].Points.Add(sp);
                            sp = new SeriesPoint(_ts.ToString(), data["max_vl"].ToString());
                            _chartMstView.Series[$"{data["moldCode"].ToString()} 최대"].Points.Add(sp);
                        }

                        // 갯수가 {MaxDataCount}개 이상일 경우 초과분만큼 데이터 지움
                        if (_chartMstView.Series[$"{data["moldCode"].ToString()} 평균"].Points.Count > MaxDataCount)
                        {
                            _chartMstView.Series[$"{data["moldCode"].ToString()} 평균"].Points.RemoveRange(0, _chartMstView.Series[$"{data["moldCode"].ToString()} 평균"].Points.Count - MaxDataCount);
                            _chartMstView.Series[$"{data["moldCode"].ToString()} 최소"].Points.RemoveRange(0, _chartMstView.Series[$"{data["moldCode"].ToString()} 최소"].Points.Count - MaxDataCount);
                            _chartMstView.Series[$"{data["moldCode"].ToString()} 최대"].Points.RemoveRange(0, _chartMstView.Series[$"{data["moldCode"].ToString()} 최대"].Points.Count - MaxDataCount);
                        }
                    }
                    else
                    {
                        GraphSeriesAdd(_Series_Param_AVG);
                        GraphSeriesAdd(_Series_Param_MIN);
                        GraphSeriesAdd(_Series_Param_MAX);
                        SeriesPoint sp = new SeriesPoint(_ts.ToString(), data["avg_vl"].ToString());
                        _chartMstView.Series[$"{data["moldCode"].ToString()} 평균"].Points.Add(sp);
                        sp = new SeriesPoint(_ts.ToString(), data["min_vl"].ToString());
                        _chartMstView.Series[$"{data["moldCode"].ToString()} 최소"].Points.Add(sp);
                        sp = new SeriesPoint(_ts.ToString(), data["max_vl"].ToString());
                        _chartMstView.Series[$"{data["moldCode"].ToString()} 최대"].Points.Add(sp);
                    }

                }
                _isDrawing = false;
                _chartMstView.Invoke((MethodInvoker)delegate ()
                {
                    _chartMstView.RefreshData();
                    _chartMstView.Update();
                    _chartMstView.Refresh();
                });
            }
        }
        private void GraphSeriesAdd(Series series_Param2)
        {
            // 범례 체크박스는 기본적으로 false
            series_Param2.CheckedInLegend = true;
            // 없을경우 추가
            _chartMstView.Series.Add(series_Param2);

            // X,Y축 설정용 변수. 시리즈를 추가 한 뒤 변수를 조회하여야 올바른 값이 반환되는듯 함.
            XYDiagram diagram = (XYDiagram)_chartMstView.Diagram;
            diagram.DefaultPane.BackColor = Color.Transparent;
            // X축 스크롤 및 줌 설정
            diagram.EnableAxisXScrolling = false;
            diagram.EnableAxisXZooming = false;
            // Y축 스크롤 및 줌 설정
            diagram.EnableAxisYScrolling = false;
            diagram.EnableAxisYZooming = false;

            diagram.AxisX.WholeRange.SideMarginsValue = 0; // 왼쪽에 공백 0으로 설정해서 없에기
            diagram.AxisX.Label.TextPattern = "{A:HH:mm:ss}"; // 시간,분,초만 표시
            diagram.AxisX.Label.TextColor = Color.White;
            diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual;
            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Second; // 데이터들을 MeasureUnit단위로 묶어서 평균을 내 한개의 점으로 찍게함
            diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Hour; // X축에 날짜를 시간단위로 보여줌
            diagram.AxisX.DateTimeScaleOptions.GridSpacing = 1; // 1 DateTimeMeasureUnit.Minute(분) 단위로 X축 표시

            // 1번째 ROW는 기본 Y축을 이용한다.
            // Y축설정
            //diagram.AxisY.WholeRange.MaxValue = GetMaxValue(ScaleName);
            //diagram.AxisY.WholeRange.MinValue = GetMinValue(ScaleName);
            diagram.AxisY.WholeRange.Auto = true; // Y축 자동설정
            diagram.AxisY.NumericScaleOptions.GridSpacing = _GridSpacing;
            diagram.AxisY.Label.TextColor = Color.White;
            diagram.AxisY.NumericScaleOptions.GridOffset = 0;
            diagram.AxisY.NumericScaleOptions.MeasureUnit = NumericMeasureUnit.Ones;
            diagram.AxisY.NumericScaleOptions.AutoGrid = true;
            diagram.AxisY.GridLines.Visible = false;
            diagram.AxisY.Label.TextPattern = "{V:N0}"; // 시리즈 Y축 값 표시형식 정수형태로 변경

        }

        private void cb_option_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            _chartMstView.Series.Clear();
            if (cb_SensorOption.SelectedItem.ToString() == "전체")
            {
                selectedgroup = "";
                selectedsensor = "";
            }
            else if (cb_SensorOption.SelectedItem.ToString() == "타공")
            {
                selectedgroup = "99";
                selectedsensor = "99";
            }
            else
            {
                selectedgroup = cb_SensorOption.SelectedItem.ToString().Split('-')[0];
                selectedsensor = cb_SensorOption.SelectedItem.ToString().Split('-')[1];
            }
            switch (cb_TimeOption.SelectedItem.ToString())
            {
                case "1분":
                    selectedtime = 1;
                    break;
                case "15분":
                    selectedtime = 15;
                    break;
                case "30분":
                    selectedtime = 30;
                    break;
                case "1시간":
                    selectedtime = 60;
                    break;
                case "3시간":
                    selectedtime = 180;
                    break;
                case "6시간":
                    selectedtime = 360;
                    break;
                case "12시간":
                    selectedtime = 720;
                    break;
                case "24시간":
                    selectedtime = 1440;
                    break;
                default:
                    break;
            }


            // 그래프 새로고침 타이머 시작
            _GraphTmr = new System.Threading.Timer(RefreshGraphCallback, null, 1000, 60000);

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
            //cb_TimeOption.Items.Add("7일");
        }

        private void AddSensorOptionItems()
        {
            cb_SensorOption.Items.Add("전체");
            cb_SensorOption.Items.Add("타공");
            try
            {
                DataConnector con = new DataConnector();
                DataTable sensor_mst = con.monitoring_Graph_R10();
                for (int i = 0; i < sensor_mst.Rows.Count; i++)
                {
                    cb_SensorOption.Items.Add($"{sensor_mst.Rows[i]["gr"].ToString()}-{sensor_mst.Rows[i]["rsn"].ToString()}");
                }
            }
            catch (Exception)
            {
            }


        }
    }
}
