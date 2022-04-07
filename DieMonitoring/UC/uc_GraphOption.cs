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
        int MaxDataCount = 300; // 최대 표시개수 300개

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

        private void RefreshGraphCallback(object state)
        {
            try
            {
                if (this.InvokeRequired)
                    BeginInvoke(new Action(DrawingGraph));

                //// 차트 리사이즈
                //if (this.InvokeRequired)
                //    BeginInvoke(new Action(ChartReSizing));

            }
            catch (Exception ex)
            {
            }
        }
        bool _isDrawing = false;

        private void ChartReSizing()
        {
            int commonPadding = 6; // 컨트롤의 기본 패딩 3 + 3 
            // 넓이는 폼길이 - 좌우측 padding(테이블레이아웃의 0번, 마지막번 열 넓이 더한 값)
            int widthScale = (int)tableLayoutPanel1.ColumnStyles[0].Width + (int)tableLayoutPanel1.ColumnStyles[tableLayoutPanel1.ColumnCount - 1].Width + commonPadding + 50;
            _chartMstView.Width = this.Width - widthScale;

            // 높이는 폼높이 - 0행 높이 + {생길 리소스 줄 수 *체크박스높이 + 3}
            //( (리소스글자수 + 10(체크박스높이) + 기본패딩(체크박스와 리소스글자 사이 padding)) / 넓이)  => 한 줄에 들어갈 리소스 수
            // 총 리소스 개수/한 줄에 들어갈 리소스 수  = 생길 리소스 줄 수 
            // 
            int ZeroRowHeight = (int)tableLayoutPanel1.RowStyles[0].Height;
            int ResourceCnt = _chartMstView.Series.Count(); // 총 리소스 개수
            int SumResourceNameLength = 0; // 리소스 글자 수
            int CheckboxSize = _chartMstView.Legend.MarkerSize.Height + 7; // 체크박스 높이
            int CntOfRow = 0; // 생길 리소스 줄 수
            foreach (Series param in _chartMstView.Series)
            {
                SumResourceNameLength += param.Name.Length;
            }
            SumResourceNameLength = SumResourceNameLength * (int)_chartMstView.Legend.Font.Size;
            int ResourceSize; // 리소스 1개 평균 넓이
            if (ResourceCnt > 0)
            {
                ResourceSize = SumResourceNameLength / ResourceCnt;
                //CntOfRow = (int)Math.Ceiling((((SumResourceNameLength *8)+ CheckboxSize + commonPadding)/(double)(_chartMstView.Width)));
                CntOfRow = ResourceCnt / (_chartMstView.Width / ResourceSize); // 1줄에 들어갈 리소스 개수

                _chartMstView.Height = this.Height - ZeroRowHeight + (CntOfRow * CheckboxSize);
            }
            else
            {
                _chartMstView.Height = this.Height - ZeroRowHeight - 50;
            }
        }

        private void DrawingGraph()
        {
            if (!_isDrawing)
            {
                int currentcnt = 0;

                _isDrawing = true;
                if (cb_SensorOption.SelectedItem.ToString() == AllSelect)
                {
                    foreach (DataRow data in summary_table.Rows)
                    {
                        Series _Series_Param2 = new Series($"{data["gr"].ToString()}-{data["rsc"].ToString()}", ViewType.Line);
                        if (_chartMstView.Series[$"{data["gr"].ToString()}-{data["rsc"].ToString()}"] != null)
                        {
                            DateTimeOffset _ts = Convert.ToDateTime(data["reg_date"].ToString());
                            if (_chartMstView.Series[$"{data["gr"].ToString()}-{data["rsc"].ToString()}"].Points.Last().ArgumentX.DateTimeArgument != _ts.DateTime)
                            {
                                if (currentcnt <= MaxDataCount)
                                {
                                    SeriesPoint sp = new SeriesPoint(_ts.ToString(), data["avg_vl"].ToString());
                                    _chartMstView.Series[$"{data["gr"].ToString()}-{data["rsc"].ToString()}"].Points.Add(sp);
                                }
                            }
                        }
                        else
                        {
                            GraphSeriesAdd(_Series_Param2);
                            if (currentcnt <= MaxDataCount)
                            {
                                SeriesPoint sp = new SeriesPoint(data["reg_date"].ToString(), data["avg_vl"].ToString());
                                _chartMstView.Series[$"{data["gr"].ToString()}-{data["rsc"].ToString()}"].Points.Add(sp);
                            }
                        }
                        currentcnt++;

                    }
                    _isDrawing = false;
                    return;
                }
                else
                {
                    foreach (DataRow data in summary_table.Rows)
                    {
                        Series _Series_Param2 = new Series($"{data["gr"].ToString()}-{data["rsc"].ToString()}", ViewType.Line);
                        DateTimeOffset _ts = Convert.ToDateTime(data["reg_date"].ToString());
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
                                if (currentcnt <= MaxDataCount)
                                {
                                    SeriesPoint sp = new SeriesPoint(_ts.ToString(), data["avg_vl"].ToString());
                                    _chartMstView.Series[$"{data["gr"].ToString()}-{data["rsc"].ToString()}"].Points.Add(sp);
                                    currentcnt++;
                                }
                            }
                        }
                        else
                        {
                            GraphSeriesAdd(_Series_Param2);
                            if (currentcnt <= MaxDataCount)
                            {
                                SeriesPoint sp = new SeriesPoint(data["reg_date"].ToString(), data["avg_vl"].ToString());
                                _chartMstView.Series[$"{data["gr"].ToString()}-{data["rsc"].ToString()}"].Points.Add(sp);
                                currentcnt++;
                            }
                        }

                    }
                }
                _isDrawing = false;
                _chartMstView.Invoke((MethodInvoker)delegate ()
                {
                    _chartMstView.Refresh();
                });
            }
        }

        private void GraphSeriesAdd(Series series_Param2)
        {
            // 범례 체크박스는 기본적으로 false
            series_Param2.CheckedInLegend = false;
            // 없을경우 추가
            _chartMstView.Series.Add(series_Param2);

            // X,Y축 설정용 변수. 시리즈를 추가 한 뒤 변수를 조회하여야 올바른 값이 반환되는듯 함.
            XYDiagram diagram = (XYDiagram)_chartMstView.Diagram;
            // X축 스크롤 및 줌 설정
            diagram.EnableAxisXScrolling = false;
            diagram.EnableAxisXZooming = false;
            // Y축 스크롤 및 줌 설정
            diagram.EnableAxisYScrolling = false;
            diagram.EnableAxisYZooming = false;

            diagram.AxisX.WholeRange.SideMarginsValue = 0; // 왼쪽에 공백 0으로 설정해서 없에기
            diagram.AxisX.Label.TextPattern = "{A:HH:mm:ss}"; // 시간,분,초만 표시
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
            diagram.AxisY.NumericScaleOptions.GridOffset = 0;
            diagram.AxisY.NumericScaleOptions.MeasureUnit = NumericMeasureUnit.Ones;
            diagram.AxisY.NumericScaleOptions.AutoGrid = true;
            diagram.AxisY.GridLines.Visible = false;
            diagram.AxisY.Label.TextPattern = "{V:N0}"; // 시리즈 Y축 값 표시형식 정수형태로 변경

        }

        private void cb_option_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            _chartMstView.Series.Clear();
            string selectedgroup;
            string selectedsensor;
            string selectedtime;
            if (cb_SensorOption.SelectedItem.ToString() == "전체")
            {
                selectedgroup = "";
                selectedsensor = "";
            }
            else
            {
                selectedgroup = cb_SensorOption.SelectedItem.ToString().Split('-')[0];
                selectedsensor = cb_SensorOption.SelectedItem.ToString().Split('-')[1];
            }
            selectedtime = cb_TimeOption.SelectedItem.ToString();

            DataConnector con = new DataConnector();
            summary_table = con.monitoring_summary_R10(selectedgroup, selectedsensor, selectedtime);


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
            //cb_TimeOption.Items.Add("3시간");
            //cb_TimeOption.Items.Add("12시간");
            //cb_TimeOption.Items.Add("24시간");
            //cb_TimeOption.Items.Add("7일");
        }

        private void AddSensorOptionItems()
        {
            cb_SensorOption.Items.Add("전체");
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
