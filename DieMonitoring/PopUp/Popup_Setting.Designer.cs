namespace DieMonitoring
{
    partial class Popup_Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_sensor_Low = new DieMonitoring.UC.CustomData.CustomTextbox();
            this.txt_sensor_High = new DieMonitoring.UC.CustomData.CustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_groupSave = new System.Windows.Forms.Label();
            this.lb_SensorList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_selectedSensor = new DieMonitoring.UC.CustomData.CustomTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_SensorTerm = new DieMonitoring.CustomComboBox();
            this.cb_acceleration_Range = new DieMonitoring.CustomComboBox();
            this.cb_acceleration_Threshold = new DieMonitoring.CustomComboBox();
            this.cb_acceleration_Detect = new DieMonitoring.CustomComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_selectedGroup = new DieMonitoring.UC.CustomData.CustomTextbox();
            this.txt_group_High = new DieMonitoring.UC.CustomData.CustomTextbox();
            this.txt_group_Low = new DieMonitoring.UC.CustomData.CustomTextbox();
            this.lb_GroupList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_sensorSave = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_sensorDefault = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Excel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 611);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txt_sensor_Low, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.txt_sensor_High, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lb_SensorList, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txt_selectedSensor, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.cb_SensorTerm, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.cb_acceleration_Range, 2, 10);
            this.tableLayoutPanel2.Controls.Add(this.cb_acceleration_Threshold, 2, 11);
            this.tableLayoutPanel2.Controls.Add(this.cb_acceleration_Detect, 2, 12);
            this.tableLayoutPanel2.Controls.Add(this.label18, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label19, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_selectedGroup, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_group_High, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_group_Low, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lb_GroupList, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 13);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 15;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(983, 760);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txt_sensor_Low
            // 
            this.txt_sensor_Low.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.txt_sensor_Low.BorderColor = System.Drawing.Color.White;
            this.txt_sensor_Low.BorderFocusColor = System.Drawing.Color.White;
            this.txt_sensor_Low.BorderSize = 2;
            this.txt_sensor_Low.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_sensor_Low.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.txt_sensor_Low.ForeColor = System.Drawing.Color.White;
            this.txt_sensor_Low.Location = new System.Drawing.Point(670, 449);
            this.txt_sensor_Low.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sensor_Low.Multiline = false;
            this.txt_sensor_Low.Name = "txt_sensor_Low";
            this.txt_sensor_Low.Padding = new System.Windows.Forms.Padding(7);
            this.txt_sensor_Low.PasswordChar = false;
            this.txt_sensor_Low.Size = new System.Drawing.Size(309, 47);
            this.txt_sensor_Low.TabIndex = 47;
            this.txt_sensor_Low.Texts = "";
            this.txt_sensor_Low.UnderlinedStyle = false;
            // 
            // txt_sensor_High
            // 
            this.txt_sensor_High.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.txt_sensor_High.BorderColor = System.Drawing.Color.White;
            this.txt_sensor_High.BorderFocusColor = System.Drawing.Color.White;
            this.txt_sensor_High.BorderSize = 2;
            this.txt_sensor_High.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_sensor_High.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.txt_sensor_High.ForeColor = System.Drawing.Color.White;
            this.txt_sensor_High.Location = new System.Drawing.Point(670, 399);
            this.txt_sensor_High.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sensor_High.Multiline = false;
            this.txt_sensor_High.Name = "txt_sensor_High";
            this.txt_sensor_High.Padding = new System.Windows.Forms.Padding(7);
            this.txt_sensor_High.PasswordChar = false;
            this.txt_sensor_High.Size = new System.Drawing.Size(309, 47);
            this.txt_sensor_High.TabIndex = 46;
            this.txt_sensor_High.Texts = "";
            this.txt_sensor_High.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(350, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 50);
            this.label2.TabIndex = 40;
            this.label2.Text = "상한치";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(350, 445);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 50);
            this.label4.TabIndex = 42;
            this.label4.Text = "하한치";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(983, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "그룹별 상하한치 설정";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(350, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "상한치";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.tableLayoutPanel2.SetColumnSpan(this.label6, 3);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(983, 65);
            this.label6.TabIndex = 5;
            this.label6.Text = "센서별 설정";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel4, 3);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 215);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(983, 65);
            this.tableLayoutPanel4.TabIndex = 48;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::DieMonitoring.Properties.Resources.AlarmHistoryButton;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.lbl_groupSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(391, 3);
            this.panel5.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 59);
            this.panel5.TabIndex = 26;
            // 
            // lbl_groupSave
            // 
            this.lbl_groupSave.BackColor = System.Drawing.Color.Transparent;
            this.lbl_groupSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_groupSave.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_groupSave.ForeColor = System.Drawing.Color.White;
            this.lbl_groupSave.Location = new System.Drawing.Point(0, 0);
            this.lbl_groupSave.Name = "lbl_groupSave";
            this.lbl_groupSave.Size = new System.Drawing.Size(200, 59);
            this.lbl_groupSave.TabIndex = 0;
            this.lbl_groupSave.Text = "저장";
            this.lbl_groupSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_groupSave.Click += new System.EventHandler(this.lbl_groupSave_Click);
            // 
            // lb_SensorList
            // 
            this.lb_SensorList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.lb_SensorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_SensorList.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lb_SensorList.ForeColor = System.Drawing.Color.White;
            this.lb_SensorList.FormattingEnabled = true;
            this.lb_SensorList.ItemHeight = 37;
            this.lb_SensorList.Location = new System.Drawing.Point(0, 345);
            this.lb_SensorList.Margin = new System.Windows.Forms.Padding(0);
            this.lb_SensorList.Name = "lb_SensorList";
            this.tableLayoutPanel2.SetRowSpan(this.lb_SensorList, 7);
            this.lb_SensorList.Size = new System.Drawing.Size(350, 350);
            this.lb_SensorList.TabIndex = 39;
            this.lb_SensorList.SelectedValueChanged += new System.EventHandler(this.lb_SensorList_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(350, 345);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 50);
            this.label7.TabIndex = 6;
            this.label7.Text = "선택 센서명";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_selectedSensor
            // 
            this.txt_selectedSensor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.txt_selectedSensor.BorderColor = System.Drawing.Color.White;
            this.txt_selectedSensor.BorderFocusColor = System.Drawing.Color.White;
            this.txt_selectedSensor.BorderSize = 2;
            this.txt_selectedSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_selectedSensor.Enabled = false;
            this.txt_selectedSensor.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.txt_selectedSensor.ForeColor = System.Drawing.Color.White;
            this.txt_selectedSensor.Location = new System.Drawing.Point(670, 349);
            this.txt_selectedSensor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_selectedSensor.Multiline = false;
            this.txt_selectedSensor.Name = "txt_selectedSensor";
            this.txt_selectedSensor.Padding = new System.Windows.Forms.Padding(7);
            this.txt_selectedSensor.PasswordChar = false;
            this.txt_selectedSensor.Size = new System.Drawing.Size(309, 47);
            this.txt_selectedSensor.TabIndex = 45;
            this.txt_selectedSensor.Texts = "";
            this.txt_selectedSensor.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(350, 495);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 50);
            this.label8.TabIndex = 12;
            this.label8.Text = "전송주기";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(350, 595);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(316, 50);
            this.label9.TabIndex = 13;
            this.label9.Text = "가속도 threshold";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(350, 645);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(316, 50);
            this.label10.TabIndex = 14;
            this.label10.Text = "가속도 detect 축";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(350, 545);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(316, 50);
            this.label11.TabIndex = 15;
            this.label11.Text = "가속도 범위";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_SensorTerm
            // 
            this.cb_SensorTerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.cb_SensorTerm.BorderColor = System.Drawing.Color.White;
            this.cb_SensorTerm.BorderSize = 2;
            this.cb_SensorTerm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_SensorTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_SensorTerm.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.cb_SensorTerm.ForeColor = System.Drawing.Color.White;
            this.cb_SensorTerm.IconColor = System.Drawing.Color.White;
            this.cb_SensorTerm.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.cb_SensorTerm.ListTextColor = System.Drawing.Color.White;
            this.cb_SensorTerm.Location = new System.Drawing.Point(669, 498);
            this.cb_SensorTerm.MinimumSize = new System.Drawing.Size(100, 30);
            this.cb_SensorTerm.Name = "cb_SensorTerm";
            this.cb_SensorTerm.Padding = new System.Windows.Forms.Padding(2);
            this.cb_SensorTerm.Size = new System.Drawing.Size(311, 44);
            this.cb_SensorTerm.TabIndex = 16;
            this.cb_SensorTerm.Texts = "";
            // 
            // cb_acceleration_Range
            // 
            this.cb_acceleration_Range.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.cb_acceleration_Range.BorderColor = System.Drawing.Color.White;
            this.cb_acceleration_Range.BorderSize = 2;
            this.cb_acceleration_Range.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_acceleration_Range.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_acceleration_Range.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.cb_acceleration_Range.ForeColor = System.Drawing.Color.White;
            this.cb_acceleration_Range.IconColor = System.Drawing.Color.White;
            this.cb_acceleration_Range.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.cb_acceleration_Range.ListTextColor = System.Drawing.Color.White;
            this.cb_acceleration_Range.Location = new System.Drawing.Point(669, 548);
            this.cb_acceleration_Range.MinimumSize = new System.Drawing.Size(100, 30);
            this.cb_acceleration_Range.Name = "cb_acceleration_Range";
            this.cb_acceleration_Range.Padding = new System.Windows.Forms.Padding(2);
            this.cb_acceleration_Range.Size = new System.Drawing.Size(311, 44);
            this.cb_acceleration_Range.TabIndex = 17;
            this.cb_acceleration_Range.Texts = "";
            // 
            // cb_acceleration_Threshold
            // 
            this.cb_acceleration_Threshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.cb_acceleration_Threshold.BorderColor = System.Drawing.Color.White;
            this.cb_acceleration_Threshold.BorderSize = 2;
            this.cb_acceleration_Threshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_acceleration_Threshold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_acceleration_Threshold.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.cb_acceleration_Threshold.ForeColor = System.Drawing.Color.White;
            this.cb_acceleration_Threshold.IconColor = System.Drawing.Color.White;
            this.cb_acceleration_Threshold.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.cb_acceleration_Threshold.ListTextColor = System.Drawing.Color.White;
            this.cb_acceleration_Threshold.Location = new System.Drawing.Point(669, 598);
            this.cb_acceleration_Threshold.MinimumSize = new System.Drawing.Size(100, 30);
            this.cb_acceleration_Threshold.Name = "cb_acceleration_Threshold";
            this.cb_acceleration_Threshold.Padding = new System.Windows.Forms.Padding(2);
            this.cb_acceleration_Threshold.Size = new System.Drawing.Size(311, 44);
            this.cb_acceleration_Threshold.TabIndex = 18;
            this.cb_acceleration_Threshold.Texts = "";
            // 
            // cb_acceleration_Detect
            // 
            this.cb_acceleration_Detect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.cb_acceleration_Detect.BorderColor = System.Drawing.Color.White;
            this.cb_acceleration_Detect.BorderSize = 2;
            this.cb_acceleration_Detect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_acceleration_Detect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_acceleration_Detect.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.cb_acceleration_Detect.ForeColor = System.Drawing.Color.White;
            this.cb_acceleration_Detect.IconColor = System.Drawing.Color.White;
            this.cb_acceleration_Detect.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.cb_acceleration_Detect.ListTextColor = System.Drawing.Color.White;
            this.cb_acceleration_Detect.Location = new System.Drawing.Point(669, 648);
            this.cb_acceleration_Detect.MinimumSize = new System.Drawing.Size(100, 30);
            this.cb_acceleration_Detect.Name = "cb_acceleration_Detect";
            this.cb_acceleration_Detect.Padding = new System.Windows.Forms.Padding(2);
            this.cb_acceleration_Detect.Size = new System.Drawing.Size(311, 44);
            this.cb_acceleration_Detect.TabIndex = 19;
            this.cb_acceleration_Detect.Texts = "";
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(350, 65);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(316, 50);
            this.label18.TabIndex = 26;
            this.label18.Text = "선택 그룹명";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(350, 165);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(316, 50);
            this.label19.TabIndex = 27;
            this.label19.Text = "하한치";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_selectedGroup
            // 
            this.txt_selectedGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.txt_selectedGroup.BorderColor = System.Drawing.Color.White;
            this.txt_selectedGroup.BorderFocusColor = System.Drawing.Color.White;
            this.txt_selectedGroup.BorderSize = 2;
            this.txt_selectedGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_selectedGroup.Enabled = false;
            this.txt_selectedGroup.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.txt_selectedGroup.ForeColor = System.Drawing.Color.White;
            this.txt_selectedGroup.Location = new System.Drawing.Point(670, 69);
            this.txt_selectedGroup.Margin = new System.Windows.Forms.Padding(4);
            this.txt_selectedGroup.Multiline = false;
            this.txt_selectedGroup.Name = "txt_selectedGroup";
            this.txt_selectedGroup.Padding = new System.Windows.Forms.Padding(7);
            this.txt_selectedGroup.PasswordChar = false;
            this.txt_selectedGroup.Size = new System.Drawing.Size(309, 47);
            this.txt_selectedGroup.TabIndex = 35;
            this.txt_selectedGroup.Texts = "";
            this.txt_selectedGroup.UnderlinedStyle = false;
            // 
            // txt_group_High
            // 
            this.txt_group_High.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.txt_group_High.BorderColor = System.Drawing.Color.White;
            this.txt_group_High.BorderFocusColor = System.Drawing.Color.White;
            this.txt_group_High.BorderSize = 2;
            this.txt_group_High.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_group_High.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.txt_group_High.ForeColor = System.Drawing.Color.White;
            this.txt_group_High.Location = new System.Drawing.Point(670, 119);
            this.txt_group_High.Margin = new System.Windows.Forms.Padding(4);
            this.txt_group_High.Multiline = false;
            this.txt_group_High.Name = "txt_group_High";
            this.txt_group_High.Padding = new System.Windows.Forms.Padding(7);
            this.txt_group_High.PasswordChar = false;
            this.txt_group_High.Size = new System.Drawing.Size(309, 47);
            this.txt_group_High.TabIndex = 36;
            this.txt_group_High.Texts = "";
            this.txt_group_High.UnderlinedStyle = false;
            // 
            // txt_group_Low
            // 
            this.txt_group_Low.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.txt_group_Low.BorderColor = System.Drawing.Color.White;
            this.txt_group_Low.BorderFocusColor = System.Drawing.Color.White;
            this.txt_group_Low.BorderSize = 2;
            this.txt_group_Low.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_group_Low.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.txt_group_Low.ForeColor = System.Drawing.Color.White;
            this.txt_group_Low.Location = new System.Drawing.Point(670, 169);
            this.txt_group_Low.Margin = new System.Windows.Forms.Padding(4);
            this.txt_group_Low.Multiline = false;
            this.txt_group_Low.Name = "txt_group_Low";
            this.txt_group_Low.Padding = new System.Windows.Forms.Padding(7);
            this.txt_group_Low.PasswordChar = false;
            this.txt_group_Low.Size = new System.Drawing.Size(309, 47);
            this.txt_group_Low.TabIndex = 37;
            this.txt_group_Low.Texts = "";
            this.txt_group_Low.UnderlinedStyle = false;
            // 
            // lb_GroupList
            // 
            this.lb_GroupList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.lb_GroupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_GroupList.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lb_GroupList.ForeColor = System.Drawing.Color.White;
            this.lb_GroupList.FormattingEnabled = true;
            this.lb_GroupList.ItemHeight = 37;
            this.lb_GroupList.Location = new System.Drawing.Point(0, 65);
            this.lb_GroupList.Margin = new System.Windows.Forms.Padding(0);
            this.lb_GroupList.Name = "lb_GroupList";
            this.tableLayoutPanel2.SetRowSpan(this.lb_GroupList, 3);
            this.lb_GroupList.Size = new System.Drawing.Size(350, 150);
            this.lb_GroupList.TabIndex = 38;
            this.lb_GroupList.SelectedValueChanged += new System.EventHandler(this.lb_GroupList_SelectedValueChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel5, 3);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 695);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(983, 65);
            this.tableLayoutPanel5.TabIndex = 49;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::DieMonitoring.Properties.Resources.AlarmHistoryButton;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.lbl_sensorSave);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(491, 3);
            this.panel7.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 59);
            this.panel7.TabIndex = 26;
            // 
            // lbl_sensorSave
            // 
            this.lbl_sensorSave.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sensorSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_sensorSave.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_sensorSave.ForeColor = System.Drawing.Color.White;
            this.lbl_sensorSave.Location = new System.Drawing.Point(0, 0);
            this.lbl_sensorSave.Name = "lbl_sensorSave";
            this.lbl_sensorSave.Size = new System.Drawing.Size(200, 59);
            this.lbl_sensorSave.TabIndex = 0;
            this.lbl_sensorSave.Text = "저장";
            this.lbl_sensorSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_sensorSave.Click += new System.EventHandler(this.lbl_sensorSave_Click);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::DieMonitoring.Properties.Resources.ButtonImage;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.lbl_sensorDefault);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(294, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(194, 59);
            this.panel8.TabIndex = 27;
            // 
            // lbl_sensorDefault
            // 
            this.lbl_sensorDefault.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sensorDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_sensorDefault.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_sensorDefault.ForeColor = System.Drawing.Color.White;
            this.lbl_sensorDefault.Location = new System.Drawing.Point(0, 0);
            this.lbl_sensorDefault.Name = "lbl_sensorDefault";
            this.lbl_sensorDefault.Size = new System.Drawing.Size(194, 59);
            this.lbl_sensorDefault.TabIndex = 0;
            this.lbl_sensorDefault.Text = "기본값 설정";
            this.lbl_sensorDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::DieMonitoring.Properties.Resources.ButtonImage;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lbl_Excel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(403, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 58);
            this.panel3.TabIndex = 23;
            // 
            // lbl_Excel
            // 
            this.lbl_Excel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Excel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Excel.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.lbl_Excel.ForeColor = System.Drawing.Color.White;
            this.lbl_Excel.Location = new System.Drawing.Point(0, 0);
            this.lbl_Excel.Name = "lbl_Excel";
            this.lbl_Excel.Size = new System.Drawing.Size(194, 58);
            this.lbl_Excel.TabIndex = 0;
            this.lbl_Excel.Text = "Excel 저장";
            this.lbl_Excel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 636);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1000, 64);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // Popup_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.DoubleBuffered = true;
            this.Name = "Popup_Setting";
            this.Text = "Popup_Setting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Popup_Setting_FormClosed);
            this.Load += new System.EventHandler(this.Popup_Setting_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private CustomComboBox cb_SensorTerm;
        private CustomComboBox cb_acceleration_Range;
        private CustomComboBox cb_acceleration_Threshold;
        private CustomComboBox cb_acceleration_Detect;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Excel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private UC.CustomData.CustomTextbox txt_selectedGroup;
        private UC.CustomData.CustomTextbox txt_group_High;
        private UC.CustomData.CustomTextbox txt_group_Low;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_SensorList;
        private System.Windows.Forms.ListBox lb_GroupList;
        private UC.CustomData.CustomTextbox txt_sensor_Low;
        private UC.CustomData.CustomTextbox txt_sensor_High;
        private UC.CustomData.CustomTextbox txt_selectedSensor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_groupSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_sensorSave;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_sensorDefault;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}