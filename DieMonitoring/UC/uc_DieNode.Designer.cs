namespace DieMonitoring
{
    partial class uc_DieNode
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
            this.lblValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.roundBorderPanel1 = new DieMonitoring.RoundBorderPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_format = new System.Windows.Forms.Label();
            this.rbp_NodeNum = new DieMonitoring.RoundBorderPanel();
            this.lblNodeNum = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.roundBorderPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.rbp_NodeNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValue.Font = new System.Drawing.Font("맑은 고딕", 26F, System.Drawing.FontStyle.Bold);
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(0, 0);
            this.lblValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(94, 50);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "110";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValue.Click += new System.EventHandler(this.Node_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.roundBorderPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbp_NodeNum, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(170, 50);
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.roundBorderPanel1.Location = new System.Drawing.Point(31, 0);
            this.roundBorderPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.roundBorderPanel1.Name = "roundBorderPanel1";
            this.roundBorderPanel1.Radius = 10;
            this.roundBorderPanel1.RoundPadding = 2;
            this.roundBorderPanel1.Size = new System.Drawing.Size(139, 50);
            this.roundBorderPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.Controls.Add(this.lblValue, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_format, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(139, 50);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbl_format
            // 
            this.lbl_format.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_format.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_format.ForeColor = System.Drawing.Color.White;
            this.lbl_format.Location = new System.Drawing.Point(94, 0);
            this.lbl_format.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_format.Name = "lbl_format";
            this.lbl_format.Size = new System.Drawing.Size(45, 50);
            this.lbl_format.TabIndex = 1;
            this.lbl_format.Text = "℃";
            this.lbl_format.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbp_NodeNum
            // 
            this.rbp_NodeNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(173)))), ((int)(((byte)(71)))));
            this.rbp_NodeNum.BorderWidth = 2;
            this.rbp_NodeNum.Controls.Add(this.lblNodeNum);
            this.rbp_NodeNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbp_NodeNum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(173)))), ((int)(((byte)(71)))));
            this.rbp_NodeNum.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbp_NodeNum.IsBorder = true;
            this.rbp_NodeNum.IsFill = true;
            this.rbp_NodeNum.Location = new System.Drawing.Point(0, 0);
            this.rbp_NodeNum.Margin = new System.Windows.Forms.Padding(0);
            this.rbp_NodeNum.Name = "rbp_NodeNum";
            this.rbp_NodeNum.Radius = 10;
            this.rbp_NodeNum.RoundPadding = 2;
            this.rbp_NodeNum.Size = new System.Drawing.Size(31, 50);
            this.rbp_NodeNum.TabIndex = 2;
            // 
            // lblNodeNum
            // 
            this.lblNodeNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNodeNum.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lblNodeNum.ForeColor = System.Drawing.Color.White;
            this.lblNodeNum.Location = new System.Drawing.Point(0, 0);
            this.lblNodeNum.Margin = new System.Windows.Forms.Padding(0);
            this.lblNodeNum.Name = "lblNodeNum";
            this.lblNodeNum.Size = new System.Drawing.Size(31, 50);
            this.lblNodeNum.TabIndex = 0;
            this.lblNodeNum.Text = "0";
            this.lblNodeNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNodeNum.Click += new System.EventHandler(this.Node_Click);
            // 
            // uc_DieNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "uc_DieNode";
            this.Size = new System.Drawing.Size(170, 50);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.roundBorderPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.rbp_NodeNum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundBorderPanel roundBorderPanel1;
        private RoundBorderPanel rbp_NodeNum;
        private System.Windows.Forms.Label lblNodeNum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_format;
    }
}
