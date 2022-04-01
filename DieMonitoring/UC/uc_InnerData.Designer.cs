namespace DieMonitoring
{
    partial class uc_InnerData
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundBorderPanel1 = new DieMonitoring.RoundBorderPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.lbl_Temptext = new System.Windows.Forms.Label();
            this.roundBorderPanel2 = new DieMonitoring.RoundBorderPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_bar = new System.Windows.Forms.Label();
            this.lbl_bartext = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.roundBorderPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.roundBorderPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BorderColor = System.Drawing.Color.Black;
            this.pnl.BorderWidth = 2;
            this.pnl.Controls.Add(this.tableLayoutPanel1);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.FillColor = System.Drawing.Color.Black;
            this.pnl.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnl.IsBorder = true;
            this.pnl.IsFill = true;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Margin = new System.Windows.Forms.Padding(0);
            this.pnl.Name = "pnl";
            this.pnl.Radius = 10;
            this.pnl.RoundPadding = 2;
            this.pnl.Size = new System.Drawing.Size(330, 110);
            this.pnl.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.roundBorderPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.roundBorderPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 110);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "IN 온도 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "IN 유량 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundBorderPanel1
            // 
            this.roundBorderPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.roundBorderPanel1.BorderWidth = 2;
            this.roundBorderPanel1.Controls.Add(this.tableLayoutPanel2);
            this.roundBorderPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundBorderPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.roundBorderPanel1.IsBorder = true;
            this.roundBorderPanel1.IsFill = true;
            this.roundBorderPanel1.Location = new System.Drawing.Point(165, 5);
            this.roundBorderPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.roundBorderPanel1.Name = "roundBorderPanel1";
            this.roundBorderPanel1.Radius = 10;
            this.roundBorderPanel1.RoundPadding = 2;
            this.roundBorderPanel1.Size = new System.Drawing.Size(160, 50);
            this.roundBorderPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Temp, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Temptext, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(160, 50);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Temp.Font = new System.Drawing.Font("맑은 고딕", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_Temp.ForeColor = System.Drawing.Color.White;
            this.lbl_Temp.Location = new System.Drawing.Point(0, 0);
            this.lbl_Temp.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(80, 50);
            this.lbl_Temp.TabIndex = 4;
            this.lbl_Temp.Text = "100";
            this.lbl_Temp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Temptext
            // 
            this.lbl_Temptext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Temptext.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_Temptext.ForeColor = System.Drawing.Color.White;
            this.lbl_Temptext.Location = new System.Drawing.Point(83, 0);
            this.lbl_Temptext.Name = "lbl_Temptext";
            this.lbl_Temptext.Size = new System.Drawing.Size(74, 50);
            this.lbl_Temptext.TabIndex = 5;
            this.lbl_Temptext.Text = " ℃";
            this.lbl_Temptext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundBorderPanel2
            // 
            this.roundBorderPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.roundBorderPanel2.BorderWidth = 2;
            this.roundBorderPanel2.Controls.Add(this.tableLayoutPanel3);
            this.roundBorderPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundBorderPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.roundBorderPanel2.IsBorder = true;
            this.roundBorderPanel2.IsFill = true;
            this.roundBorderPanel2.Location = new System.Drawing.Point(165, 55);
            this.roundBorderPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.roundBorderPanel2.Name = "roundBorderPanel2";
            this.roundBorderPanel2.Radius = 10;
            this.roundBorderPanel2.RoundPadding = 2;
            this.roundBorderPanel2.Size = new System.Drawing.Size(160, 50);
            this.roundBorderPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_bar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_bartext, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(160, 50);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // lbl_bar
            // 
            this.lbl_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_bar.Font = new System.Drawing.Font("맑은 고딕", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_bar.ForeColor = System.Drawing.Color.White;
            this.lbl_bar.Location = new System.Drawing.Point(0, 0);
            this.lbl_bar.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_bar.Name = "lbl_bar";
            this.lbl_bar.Size = new System.Drawing.Size(80, 50);
            this.lbl_bar.TabIndex = 5;
            this.lbl_bar.Text = "100";
            this.lbl_bar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_bartext
            // 
            this.lbl_bartext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_bartext.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_bartext.ForeColor = System.Drawing.Color.White;
            this.lbl_bartext.Location = new System.Drawing.Point(83, 0);
            this.lbl_bartext.Name = "lbl_bartext";
            this.lbl_bartext.Size = new System.Drawing.Size(74, 50);
            this.lbl_bartext.TabIndex = 6;
            this.lbl_bartext.Text = " bar";
            this.lbl_bartext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uc_InnerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnl);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "uc_InnerData";
            this.Size = new System.Drawing.Size(330, 110);
            this.pnl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.roundBorderPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.roundBorderPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.Label lbl_bar;
        private RoundBorderPanel pnl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundBorderPanel roundBorderPanel1;
        private RoundBorderPanel roundBorderPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Temptext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_bartext;
    }
}
