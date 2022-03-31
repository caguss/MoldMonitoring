namespace DieMonitoring
{
    partial class MonitoringForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoringForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblfront = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblback = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uc_GraphOption1 = new DieMonitoring.uc_GraphOption();
            this.uc_AlarmHistory1 = new DieMonitoring.uc_AlarmHistory();
            this.uc_Alert1 = new DieMonitoring.uc_Alert();
            this.roundBorderPanel4 = new DieMonitoring.RoundBorderPanel();
            this.NodeGroup_FrontLower = new DieMonitoring.uc_LowerNodeGroup();
            this.OuterData_FrontLower = new DieMonitoring.uc_OuterData();
            this.roundBorderPanel6 = new DieMonitoring.RoundBorderPanel();
            this.InnerData_FrontLower = new DieMonitoring.uc_InnerData();
            this.NodeGroup_FrontUpper = new DieMonitoring.uc_UpperNodeGroup();
            this.OuterData_FrontUpper = new DieMonitoring.uc_OuterData();
            this.InnerData_FrontUpper = new DieMonitoring.uc_InnerData();
            this.roundBorderPanel5 = new DieMonitoring.RoundBorderPanel();
            this.roundBorderPanel1 = new DieMonitoring.RoundBorderPanel();
            this.NodeGroup_BackLower = new DieMonitoring.uc_LowerNodeGroup();
            this.OuterData_BackLower = new DieMonitoring.uc_OuterData();
            this.InnerData_BackLower = new DieMonitoring.uc_InnerData();
            this.OuterData_BackUpper = new DieMonitoring.uc_OuterData();
            this.InnerData_BackUpper = new DieMonitoring.uc_InnerData();
            this.NodeGroup_BackUpper = new DieMonitoring.uc_UpperNodeGroup();
            this.roundBorderPanel2 = new DieMonitoring.RoundBorderPanel();
            this.lbl_MoldName = new System.Windows.Forms.Label();
            this.uc_ProgramTimer1 = new DieMonitoring.uc_ProgramTimer();
            this.uc_PressCount2 = new DieMonitoring.uc_PressCount();
            this.uc_WorkingData1 = new DieMonitoring.uc_WorkingData();
            this.uc_OptionButton1 = new DieMonitoring.uc_OptionButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.roundBorderPanel4.SuspendLayout();
            this.roundBorderPanel5.SuspendLayout();
            this.roundBorderPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.86539F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.32966F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.807693F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.997253F));
            this.tableLayoutPanel1.Controls.Add(this.chartControl1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.uc_GraphOption1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.uc_AlarmHistory1, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.uc_Alert1, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uc_WorkingData1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.uc_OptionButton1, 4, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1904, 1041);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // chartControl1
            // 
            this.chartControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.tableLayoutPanel1.SetColumnSpan(this.chartControl1, 3);
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(1407, 153);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(497, 504);
            this.chartControl1.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.roundBorderPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.roundBorderPanel5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 150);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.534619F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.46538F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1407, 891);
            this.tableLayoutPanel2.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::DieMonitoring.Properties.Resources.FrontBackTitle;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblfront);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(200, 5, 200, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 73);
            this.panel2.TabIndex = 4;
            // 
            // lblfront
            // 
            this.lblfront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblfront.Font = new System.Drawing.Font("굴림", 20F);
            this.lblfront.ForeColor = System.Drawing.Color.White;
            this.lblfront.Location = new System.Drawing.Point(0, 0);
            this.lblfront.Margin = new System.Windows.Forms.Padding(0);
            this.lblfront.Name = "lblfront";
            this.lblfront.Size = new System.Drawing.Size(303, 73);
            this.lblfront.TabIndex = 0;
            this.lblfront.Text = "전면";
            this.lblfront.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblfront.Click += new System.EventHandler(this.lblfront_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::DieMonitoring.Properties.Resources.FrontBackTitle;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblback);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(903, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(200, 5, 200, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 73);
            this.panel3.TabIndex = 5;
            // 
            // lblback
            // 
            this.lblback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblback.Font = new System.Drawing.Font("굴림", 20F);
            this.lblback.ForeColor = System.Drawing.Color.White;
            this.lblback.Location = new System.Drawing.Point(0, 0);
            this.lblback.Margin = new System.Windows.Forms.Padding(0);
            this.lblback.Name = "lblback";
            this.lblback.Size = new System.Drawing.Size(304, 73);
            this.lblback.TabIndex = 0;
            this.lblback.Text = "후면";
            this.lblback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblback.Click += new System.EventHandler(this.lblback_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 5);
            this.panel1.Controls.Add(this.roundBorderPanel2);
            this.panel1.Controls.Add(this.uc_ProgramTimer1);
            this.panel1.Controls.Add(this.uc_PressCount2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 150);
            this.panel1.TabIndex = 31;
            // 
            // uc_GraphOption1
            // 
            this.uc_GraphOption1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.uc_GraphOption1, 3);
            this.uc_GraphOption1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_GraphOption1.Location = new System.Drawing.Point(1407, 657);
            this.uc_GraphOption1.Margin = new System.Windows.Forms.Padding(0);
            this.uc_GraphOption1.Name = "uc_GraphOption1";
            this.uc_GraphOption1.Size = new System.Drawing.Size(497, 60);
            this.uc_GraphOption1.TabIndex = 21;
            // 
            // uc_AlarmHistory1
            // 
            this.uc_AlarmHistory1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.uc_AlarmHistory1, 2);
            this.uc_AlarmHistory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_AlarmHistory1.Location = new System.Drawing.Point(1712, 951);
            this.uc_AlarmHistory1.Margin = new System.Windows.Forms.Padding(10);
            this.uc_AlarmHistory1.Name = "uc_AlarmHistory1";
            this.uc_AlarmHistory1.Size = new System.Drawing.Size(182, 80);
            this.uc_AlarmHistory1.TabIndex = 23;
            // 
            // uc_Alert1
            // 
            this.uc_Alert1.BackColor = System.Drawing.Color.Transparent;
            this.uc_Alert1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_Alert1.Location = new System.Drawing.Point(1417, 951);
            this.uc_Alert1.Margin = new System.Windows.Forms.Padding(10);
            this.uc_Alert1.Name = "uc_Alert1";
            this.uc_Alert1.Size = new System.Drawing.Size(275, 80);
            this.uc_Alert1.TabIndex = 26;
            // 
            // roundBorderPanel4
            // 
            this.roundBorderPanel4.BorderColor = System.Drawing.Color.White;
            this.roundBorderPanel4.BorderWidth = 2;
            this.roundBorderPanel4.Controls.Add(this.NodeGroup_FrontLower);
            this.roundBorderPanel4.Controls.Add(this.OuterData_FrontLower);
            this.roundBorderPanel4.Controls.Add(this.roundBorderPanel6);
            this.roundBorderPanel4.Controls.Add(this.InnerData_FrontLower);
            this.roundBorderPanel4.Controls.Add(this.NodeGroup_FrontUpper);
            this.roundBorderPanel4.Controls.Add(this.OuterData_FrontUpper);
            this.roundBorderPanel4.Controls.Add(this.InnerData_FrontUpper);
            this.roundBorderPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundBorderPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.roundBorderPanel4.IsBorder = true;
            this.roundBorderPanel4.IsFill = true;
            this.roundBorderPanel4.Location = new System.Drawing.Point(5, 88);
            this.roundBorderPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.roundBorderPanel4.Name = "roundBorderPanel4";
            this.roundBorderPanel4.Radius = 20;
            this.roundBorderPanel4.RoundPadding = 2;
            this.tableLayoutPanel2.SetRowSpan(this.roundBorderPanel4, 2);
            this.roundBorderPanel4.Size = new System.Drawing.Size(693, 798);
            this.roundBorderPanel4.TabIndex = 2;
            // 
            // NodeGroup_FrontLower
            // 
            this.NodeGroup_FrontLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NodeGroup_FrontLower.BackColor = System.Drawing.Color.Transparent;
            this.NodeGroup_FrontLower.Location = new System.Drawing.Point(10, 420);
            this.NodeGroup_FrontLower.Name = "NodeGroup_FrontLower";
            this.NodeGroup_FrontLower.Size = new System.Drawing.Size(670, 200);
            this.NodeGroup_FrontLower.TabIndex = 11;
            // 
            // OuterData_FrontLower
            // 
            this.OuterData_FrontLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OuterData_FrontLower.BackColor = System.Drawing.Color.Transparent;
            this.OuterData_FrontLower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OuterData_FrontLower.Location = new System.Drawing.Point(350, 630);
            this.OuterData_FrontLower.Margin = new System.Windows.Forms.Padding(0);
            this.OuterData_FrontLower.Name = "OuterData_FrontLower";
            this.OuterData_FrontLower.Size = new System.Drawing.Size(330, 150);
            this.OuterData_FrontLower.TabIndex = 10;
            // 
            // roundBorderPanel6
            // 
            this.roundBorderPanel6.BorderColor = System.Drawing.Color.White;
            this.roundBorderPanel6.BorderWidth = 2;
            this.roundBorderPanel6.FillColor = System.Drawing.Color.White;
            this.roundBorderPanel6.IsBorder = true;
            this.roundBorderPanel6.IsFill = true;
            this.roundBorderPanel6.Location = new System.Drawing.Point(10, 410);
            this.roundBorderPanel6.Name = "roundBorderPanel6";
            this.roundBorderPanel6.Radius = 30;
            this.roundBorderPanel6.RoundPadding = 2;
            this.roundBorderPanel6.Size = new System.Drawing.Size(670, 10);
            this.roundBorderPanel6.TabIndex = 4;
            // 
            // InnerData_FrontLower
            // 
            this.InnerData_FrontLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InnerData_FrontLower.BackColor = System.Drawing.Color.Transparent;
            this.InnerData_FrontLower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InnerData_FrontLower.Location = new System.Drawing.Point(10, 630);
            this.InnerData_FrontLower.Margin = new System.Windows.Forms.Padding(0);
            this.InnerData_FrontLower.Name = "InnerData_FrontLower";
            this.InnerData_FrontLower.Size = new System.Drawing.Size(330, 150);
            this.InnerData_FrontLower.TabIndex = 9;
            // 
            // NodeGroup_FrontUpper
            // 
            this.NodeGroup_FrontUpper.BackColor = System.Drawing.Color.Transparent;
            this.NodeGroup_FrontUpper.Location = new System.Drawing.Point(10, 20);
            this.NodeGroup_FrontUpper.Name = "NodeGroup_FrontUpper";
            this.NodeGroup_FrontUpper.Size = new System.Drawing.Size(670, 200);
            this.NodeGroup_FrontUpper.TabIndex = 3;
            // 
            // OuterData_FrontUpper
            // 
            this.OuterData_FrontUpper.BackColor = System.Drawing.Color.Transparent;
            this.OuterData_FrontUpper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OuterData_FrontUpper.Location = new System.Drawing.Point(350, 230);
            this.OuterData_FrontUpper.Margin = new System.Windows.Forms.Padding(0);
            this.OuterData_FrontUpper.Name = "OuterData_FrontUpper";
            this.OuterData_FrontUpper.Size = new System.Drawing.Size(330, 150);
            this.OuterData_FrontUpper.TabIndex = 2;
            // 
            // InnerData_FrontUpper
            // 
            this.InnerData_FrontUpper.BackColor = System.Drawing.Color.Transparent;
            this.InnerData_FrontUpper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InnerData_FrontUpper.Location = new System.Drawing.Point(10, 230);
            this.InnerData_FrontUpper.Margin = new System.Windows.Forms.Padding(0);
            this.InnerData_FrontUpper.Name = "InnerData_FrontUpper";
            this.InnerData_FrontUpper.Size = new System.Drawing.Size(330, 150);
            this.InnerData_FrontUpper.TabIndex = 1;
            // 
            // roundBorderPanel5
            // 
            this.roundBorderPanel5.BorderColor = System.Drawing.Color.White;
            this.roundBorderPanel5.BorderWidth = 2;
            this.roundBorderPanel5.Controls.Add(this.roundBorderPanel1);
            this.roundBorderPanel5.Controls.Add(this.NodeGroup_BackLower);
            this.roundBorderPanel5.Controls.Add(this.OuterData_BackLower);
            this.roundBorderPanel5.Controls.Add(this.InnerData_BackLower);
            this.roundBorderPanel5.Controls.Add(this.OuterData_BackUpper);
            this.roundBorderPanel5.Controls.Add(this.InnerData_BackUpper);
            this.roundBorderPanel5.Controls.Add(this.NodeGroup_BackUpper);
            this.roundBorderPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundBorderPanel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.roundBorderPanel5.IsBorder = true;
            this.roundBorderPanel5.IsFill = true;
            this.roundBorderPanel5.Location = new System.Drawing.Point(708, 88);
            this.roundBorderPanel5.Margin = new System.Windows.Forms.Padding(5);
            this.roundBorderPanel5.Name = "roundBorderPanel5";
            this.roundBorderPanel5.Radius = 20;
            this.roundBorderPanel5.RoundPadding = 2;
            this.tableLayoutPanel2.SetRowSpan(this.roundBorderPanel5, 2);
            this.roundBorderPanel5.Size = new System.Drawing.Size(694, 798);
            this.roundBorderPanel5.TabIndex = 3;
            // 
            // roundBorderPanel1
            // 
            this.roundBorderPanel1.BorderColor = System.Drawing.Color.White;
            this.roundBorderPanel1.BorderWidth = 2;
            this.roundBorderPanel1.FillColor = System.Drawing.Color.White;
            this.roundBorderPanel1.IsBorder = true;
            this.roundBorderPanel1.IsFill = true;
            this.roundBorderPanel1.Location = new System.Drawing.Point(10, 410);
            this.roundBorderPanel1.Name = "roundBorderPanel1";
            this.roundBorderPanel1.Radius = 30;
            this.roundBorderPanel1.RoundPadding = 2;
            this.roundBorderPanel1.Size = new System.Drawing.Size(670, 10);
            this.roundBorderPanel1.TabIndex = 5;
            // 
            // NodeGroup_BackLower
            // 
            this.NodeGroup_BackLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NodeGroup_BackLower.BackColor = System.Drawing.Color.Transparent;
            this.NodeGroup_BackLower.Location = new System.Drawing.Point(10, 420);
            this.NodeGroup_BackLower.Name = "NodeGroup_BackLower";
            this.NodeGroup_BackLower.Size = new System.Drawing.Size(670, 200);
            this.NodeGroup_BackLower.TabIndex = 12;
            // 
            // OuterData_BackLower
            // 
            this.OuterData_BackLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OuterData_BackLower.BackColor = System.Drawing.Color.Transparent;
            this.OuterData_BackLower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OuterData_BackLower.Location = new System.Drawing.Point(350, 630);
            this.OuterData_BackLower.Margin = new System.Windows.Forms.Padding(0);
            this.OuterData_BackLower.Name = "OuterData_BackLower";
            this.OuterData_BackLower.Size = new System.Drawing.Size(330, 150);
            this.OuterData_BackLower.TabIndex = 8;
            // 
            // InnerData_BackLower
            // 
            this.InnerData_BackLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InnerData_BackLower.BackColor = System.Drawing.Color.Transparent;
            this.InnerData_BackLower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InnerData_BackLower.Location = new System.Drawing.Point(10, 630);
            this.InnerData_BackLower.Margin = new System.Windows.Forms.Padding(0);
            this.InnerData_BackLower.Name = "InnerData_BackLower";
            this.InnerData_BackLower.Size = new System.Drawing.Size(330, 150);
            this.InnerData_BackLower.TabIndex = 7;
            // 
            // OuterData_BackUpper
            // 
            this.OuterData_BackUpper.BackColor = System.Drawing.Color.Transparent;
            this.OuterData_BackUpper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OuterData_BackUpper.Location = new System.Drawing.Point(350, 230);
            this.OuterData_BackUpper.Margin = new System.Windows.Forms.Padding(0);
            this.OuterData_BackUpper.Name = "OuterData_BackUpper";
            this.OuterData_BackUpper.Size = new System.Drawing.Size(330, 150);
            this.OuterData_BackUpper.TabIndex = 6;
            // 
            // InnerData_BackUpper
            // 
            this.InnerData_BackUpper.BackColor = System.Drawing.Color.Transparent;
            this.InnerData_BackUpper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InnerData_BackUpper.Location = new System.Drawing.Point(10, 230);
            this.InnerData_BackUpper.Margin = new System.Windows.Forms.Padding(0);
            this.InnerData_BackUpper.Name = "InnerData_BackUpper";
            this.InnerData_BackUpper.Size = new System.Drawing.Size(330, 150);
            this.InnerData_BackUpper.TabIndex = 5;
            // 
            // NodeGroup_BackUpper
            // 
            this.NodeGroup_BackUpper.BackColor = System.Drawing.Color.Transparent;
            this.NodeGroup_BackUpper.Location = new System.Drawing.Point(10, 20);
            this.NodeGroup_BackUpper.Name = "NodeGroup_BackUpper";
            this.NodeGroup_BackUpper.Size = new System.Drawing.Size(670, 200);
            this.NodeGroup_BackUpper.TabIndex = 0;
            // 
            // roundBorderPanel2
            // 
            this.roundBorderPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.roundBorderPanel2.BorderWidth = 2;
            this.roundBorderPanel2.Controls.Add(this.lbl_MoldName);
            this.roundBorderPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.roundBorderPanel2.IsBorder = true;
            this.roundBorderPanel2.IsFill = true;
            this.roundBorderPanel2.Location = new System.Drawing.Point(660, 30);
            this.roundBorderPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.roundBorderPanel2.Name = "roundBorderPanel2";
            this.roundBorderPanel2.Radius = 10;
            this.roundBorderPanel2.RoundPadding = 2;
            this.roundBorderPanel2.Size = new System.Drawing.Size(679, 78);
            this.roundBorderPanel2.TabIndex = 29;
            // 
            // lbl_MoldName
            // 
            this.lbl_MoldName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MoldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_MoldName.Font = new System.Drawing.Font("굴림", 26F);
            this.lbl_MoldName.ForeColor = System.Drawing.Color.White;
            this.lbl_MoldName.Location = new System.Drawing.Point(0, 0);
            this.lbl_MoldName.Name = "lbl_MoldName";
            this.lbl_MoldName.Size = new System.Drawing.Size(679, 78);
            this.lbl_MoldName.TabIndex = 0;
            this.lbl_MoldName.Text = "금형이름";
            this.lbl_MoldName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_MoldName.Click += new System.EventHandler(this.lbl_MoldName_Click);
            // 
            // uc_ProgramTimer1
            // 
            this.uc_ProgramTimer1.BackColor = System.Drawing.Color.Transparent;
            this.uc_ProgramTimer1.Location = new System.Drawing.Point(0, 0);
            this.uc_ProgramTimer1.Margin = new System.Windows.Forms.Padding(0);
            this.uc_ProgramTimer1.Name = "uc_ProgramTimer1";
            this.uc_ProgramTimer1.Size = new System.Drawing.Size(450, 150);
            this.uc_ProgramTimer1.TabIndex = 1;
            // 
            // uc_PressCount2
            // 
            this.uc_PressCount2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_PressCount2.BackColor = System.Drawing.Color.Transparent;
            this.uc_PressCount2.Location = new System.Drawing.Point(1477, 30);
            this.uc_PressCount2.Name = "uc_PressCount2";
            this.uc_PressCount2.Size = new System.Drawing.Size(427, 117);
            this.uc_PressCount2.TabIndex = 28;
            // 
            // uc_WorkingData1
            // 
            this.uc_WorkingData1.BackColor = System.Drawing.Color.Transparent;
            this.uc_WorkingData1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.uc_WorkingData1, 2);
            this.uc_WorkingData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_WorkingData1.Location = new System.Drawing.Point(1407, 804);
            this.uc_WorkingData1.Margin = new System.Windows.Forms.Padding(0);
            this.uc_WorkingData1.Name = "uc_WorkingData1";
            this.uc_WorkingData1.Size = new System.Drawing.Size(364, 137);
            this.uc_WorkingData1.TabIndex = 32;
            // 
            // uc_OptionButton1
            // 
            this.uc_OptionButton1.BackColor = System.Drawing.Color.Transparent;
            this.uc_OptionButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uc_OptionButton1.BackgroundImage")));
            this.uc_OptionButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uc_OptionButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_OptionButton1.Location = new System.Drawing.Point(1781, 814);
            this.uc_OptionButton1.Margin = new System.Windows.Forms.Padding(10);
            this.uc_OptionButton1.Name = "uc_OptionButton1";
            this.uc_OptionButton1.Size = new System.Drawing.Size(113, 117);
            this.uc_OptionButton1.TabIndex = 33;
            // 
            // MonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonitoringForm";
            this.Text = "DieMonitoring";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.roundBorderPanel4.ResumeLayout(false);
            this.roundBorderPanel5.ResumeLayout(false);
            this.roundBorderPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private uc_GraphOption uc_GraphOption1;
        private uc_AlarmHistory uc_AlarmHistory1;
        private uc_Alert uc_Alert1;
        private uc_ProgramTimer uc_ProgramTimer1;
        private uc_PressCount uc_PressCount2;
        private RoundBorderPanel roundBorderPanel2;
        private System.Windows.Forms.Label lbl_MoldName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private RoundBorderPanel roundBorderPanel4;
        private RoundBorderPanel roundBorderPanel5;
        private uc_WorkingData uc_WorkingData1;
        private uc_OuterData OuterData_FrontUpper;
        private uc_InnerData InnerData_FrontUpper;
        private uc_LowerNodeGroup NodeGroup_FrontLower;
        private uc_OuterData OuterData_FrontLower;
        private RoundBorderPanel roundBorderPanel6;
        private uc_InnerData InnerData_FrontLower;
        private uc_UpperNodeGroup NodeGroup_FrontUpper;
        private uc_LowerNodeGroup NodeGroup_BackLower;
        private uc_OuterData OuterData_BackLower;
        private uc_InnerData InnerData_BackLower;
        private uc_OuterData OuterData_BackUpper;
        private uc_InnerData InnerData_BackUpper;
        private uc_UpperNodeGroup NodeGroup_BackUpper;
        private uc_OptionButton uc_OptionButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblfront;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblback;
        private RoundBorderPanel roundBorderPanel1;
    }
}

