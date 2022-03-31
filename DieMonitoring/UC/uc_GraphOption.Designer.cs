namespace DieMonitoring
{
    partial class uc_GraphOption
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl = new DieMonitoring.RoundBorderPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_SensorOption = new DieMonitoring.CustomComboBox();
            this.cb_TimeOption = new DieMonitoring.CustomComboBox();
            this.pnl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BorderColor = System.Drawing.Color.White;
            this.pnl.BorderWidth = 2;
            this.pnl.Controls.Add(this.tableLayoutPanel1);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.pnl.IsBorder = true;
            this.pnl.IsFill = true;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Radius = 10;
            this.pnl.RoundPadding = 2;
            this.pnl.Size = new System.Drawing.Size(500, 60);
            this.pnl.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_SensorOption, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_TimeOption, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "센서 선택";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(253, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "표시 시간";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_SensorOption
            // 
            this.cb_SensorOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.cb_SensorOption.BorderColor = System.Drawing.Color.White;
            this.cb_SensorOption.BorderSize = 2;
            this.cb_SensorOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_SensorOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_SensorOption.ForeColor = System.Drawing.Color.White;
            this.cb_SensorOption.IconColor = System.Drawing.Color.White;
            this.cb_SensorOption.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.cb_SensorOption.ListTextColor = System.Drawing.Color.White;
            this.cb_SensorOption.Location = new System.Drawing.Point(109, 13);
            this.cb_SensorOption.MinimumSize = new System.Drawing.Size(100, 30);
            this.cb_SensorOption.Name = "cb_SensorOption";
            this.cb_SensorOption.Padding = new System.Windows.Forms.Padding(2);
            this.cb_SensorOption.Size = new System.Drawing.Size(138, 34);
            this.cb_SensorOption.TabIndex = 3;
            this.cb_SensorOption.Texts = "";
            // 
            // cb_TimeOption
            // 
            this.cb_TimeOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.cb_TimeOption.BorderColor = System.Drawing.Color.White;
            this.cb_TimeOption.BorderSize = 2;
            this.cb_TimeOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_TimeOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cb_TimeOption.ForeColor = System.Drawing.Color.White;
            this.cb_TimeOption.IconColor = System.Drawing.Color.White;
            this.cb_TimeOption.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.cb_TimeOption.ListTextColor = System.Drawing.Color.White;
            this.cb_TimeOption.Location = new System.Drawing.Point(349, 13);
            this.cb_TimeOption.MinimumSize = new System.Drawing.Size(100, 30);
            this.cb_TimeOption.Name = "cb_TimeOption";
            this.cb_TimeOption.Padding = new System.Windows.Forms.Padding(2);
            this.cb_TimeOption.Size = new System.Drawing.Size(138, 34);
            this.cb_TimeOption.TabIndex = 4;
            this.cb_TimeOption.Texts = "";
            // 
            // uc_GraphOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "uc_GraphOption";
            this.Size = new System.Drawing.Size(500, 60);
            this.pnl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundBorderPanel pnl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomComboBox cb_SensorOption;
        private CustomComboBox cb_TimeOption;
    }
}
