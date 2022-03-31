namespace DieMonitoring
{
    partial class uc_ProgramTimer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.roundBorderPanel1 = new DieMonitoring.RoundBorderPanel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.uc_InnerTemp1 = new DieMonitoring.uc_InnerTemp();
            this.tableLayoutPanel1.SuspendLayout();
            this.roundBorderPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.44444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.55556F));
            this.tableLayoutPanel1.Controls.Add(this.roundBorderPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.uc_InnerTemp1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // roundBorderPanel1
            // 
            this.roundBorderPanel1.BorderColor = System.Drawing.Color.Maroon;
            this.roundBorderPanel1.BorderWidth = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.roundBorderPanel1, 2);
            this.roundBorderPanel1.Controls.Add(this.lbl_Title);
            this.roundBorderPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundBorderPanel1.FillColor = System.Drawing.Color.Maroon;
            this.roundBorderPanel1.IsBorder = true;
            this.roundBorderPanel1.IsFill = true;
            this.roundBorderPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundBorderPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.roundBorderPanel1.Name = "roundBorderPanel1";
            this.roundBorderPanel1.Radius = 10;
            this.roundBorderPanel1.RoundPadding = 2;
            this.roundBorderPanel1.Size = new System.Drawing.Size(450, 49);
            this.roundBorderPanel1.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Title.Font = new System.Drawing.Font("굴림", 15F);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(450, 49);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "실시간 금형 모니터링";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("굴림", 16F);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(0, 49);
            this.lblDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(235, 49);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "0000. 00. 00";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ExitAction_MouseDoubleClick);
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("굴림", 24F);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(0, 98);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(235, 52);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "PM 00:00";
            this.lblTime.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ExitAction_MouseDoubleClick);
            // 
            // uc_InnerTemp1
            // 
            this.uc_InnerTemp1.BackColor = System.Drawing.Color.Transparent;
            this.uc_InnerTemp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uc_InnerTemp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_InnerTemp1.Location = new System.Drawing.Point(235, 49);
            this.uc_InnerTemp1.Margin = new System.Windows.Forms.Padding(0);
            this.uc_InnerTemp1.Name = "uc_InnerTemp1";
            this.tableLayoutPanel1.SetRowSpan(this.uc_InnerTemp1, 2);
            this.uc_InnerTemp1.Size = new System.Drawing.Size(215, 101);
            this.uc_InnerTemp1.TabIndex = 3;
            // 
            // uc_ProgramTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "uc_ProgramTimer";
            this.Size = new System.Drawing.Size(450, 150);
            this.Load += new System.EventHandler(this.uc_ProgramTimer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.roundBorderPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundBorderPanel roundBorderPanel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private uc_InnerTemp uc_InnerTemp1;
    }
}
