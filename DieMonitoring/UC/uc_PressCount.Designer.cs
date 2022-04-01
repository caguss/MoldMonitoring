namespace DieMonitoring
{
    partial class uc_PressCount
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
            this.tlp_Today = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTodayCnt = new System.Windows.Forms.Label();
            this.roundBorderPanel2 = new DieMonitoring.RoundBorderPanel();
            this.tlp_Total = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCnt = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.roundBorderPanel1.SuspendLayout();
            this.tlp_Today.SuspendLayout();
            this.roundBorderPanel2.SuspendLayout();
            this.tlp_Total.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Controls.Add(this.roundBorderPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.roundBorderPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(371, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // roundBorderPanel1
            // 
            this.roundBorderPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.roundBorderPanel1.BorderWidth = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.roundBorderPanel1, 2);
            this.roundBorderPanel1.Controls.Add(this.tlp_Today);
            this.roundBorderPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundBorderPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.roundBorderPanel1.IsBorder = true;
            this.roundBorderPanel1.IsFill = true;
            this.roundBorderPanel1.Location = new System.Drawing.Point(3, 3);
            this.roundBorderPanel1.Name = "roundBorderPanel1";
            this.roundBorderPanel1.Radius = 10;
            this.roundBorderPanel1.RoundPadding = 2;
            this.roundBorderPanel1.Size = new System.Drawing.Size(365, 44);
            this.roundBorderPanel1.TabIndex = 0;
            // 
            // tlp_Today
            // 
            this.tlp_Today.ColumnCount = 2;
            this.tlp_Today.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_Today.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_Today.Controls.Add(this.label1, 0, 0);
            this.tlp_Today.Controls.Add(this.lblTodayCnt, 1, 0);
            this.tlp_Today.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Today.Location = new System.Drawing.Point(0, 0);
            this.tlp_Today.Margin = new System.Windows.Forms.Padding(5);
            this.tlp_Today.Name = "tlp_Today";
            this.tlp_Today.RowCount = 1;
            this.tlp_Today.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Today.Size = new System.Drawing.Size(365, 44);
            this.tlp_Today.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "금일 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodayCnt
            // 
            this.lblTodayCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTodayCnt.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lblTodayCnt.ForeColor = System.Drawing.Color.White;
            this.lblTodayCnt.Location = new System.Drawing.Point(109, 0);
            this.lblTodayCnt.Margin = new System.Windows.Forms.Padding(0);
            this.lblTodayCnt.Name = "lblTodayCnt";
            this.lblTodayCnt.Size = new System.Drawing.Size(256, 44);
            this.lblTodayCnt.TabIndex = 1;
            this.lblTodayCnt.Text = "000,000,000,000";
            this.lblTodayCnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTodayCnt.Click += new System.EventHandler(this.lblTodayCnt_Click);
            // 
            // roundBorderPanel2
            // 
            this.roundBorderPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.roundBorderPanel2.BorderWidth = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.roundBorderPanel2, 2);
            this.roundBorderPanel2.Controls.Add(this.tlp_Total);
            this.roundBorderPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundBorderPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.roundBorderPanel2.IsBorder = true;
            this.roundBorderPanel2.IsFill = true;
            this.roundBorderPanel2.Location = new System.Drawing.Point(3, 53);
            this.roundBorderPanel2.Name = "roundBorderPanel2";
            this.roundBorderPanel2.Radius = 10;
            this.roundBorderPanel2.RoundPadding = 2;
            this.roundBorderPanel2.Size = new System.Drawing.Size(365, 44);
            this.roundBorderPanel2.TabIndex = 1;
            // 
            // tlp_Total
            // 
            this.tlp_Total.ColumnCount = 2;
            this.tlp_Total.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_Total.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_Total.Controls.Add(this.label2, 0, 0);
            this.tlp_Total.Controls.Add(this.lblTotalCnt, 1, 0);
            this.tlp_Total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Total.Location = new System.Drawing.Point(0, 0);
            this.tlp_Total.Margin = new System.Windows.Forms.Padding(5);
            this.tlp_Total.Name = "tlp_Total";
            this.tlp_Total.RowCount = 1;
            this.tlp_Total.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Total.Size = new System.Drawing.Size(365, 44);
            this.tlp_Total.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "누적 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCnt
            // 
            this.lblTotalCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCnt.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalCnt.ForeColor = System.Drawing.Color.White;
            this.lblTotalCnt.Location = new System.Drawing.Point(109, 0);
            this.lblTotalCnt.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCnt.Name = "lblTotalCnt";
            this.lblTotalCnt.Size = new System.Drawing.Size(256, 44);
            this.lblTotalCnt.TabIndex = 1;
            this.lblTotalCnt.Text = "000,000,000,000";
            this.lblTotalCnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uc_PressCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "uc_PressCount";
            this.Size = new System.Drawing.Size(371, 100);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.roundBorderPanel1.ResumeLayout(false);
            this.tlp_Today.ResumeLayout(false);
            this.roundBorderPanel2.ResumeLayout(false);
            this.tlp_Total.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundBorderPanel roundBorderPanel1;
        private System.Windows.Forms.TableLayoutPanel tlp_Today;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTodayCnt;
        private RoundBorderPanel roundBorderPanel2;
        private System.Windows.Forms.TableLayoutPanel tlp_Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCnt;
    }
}
