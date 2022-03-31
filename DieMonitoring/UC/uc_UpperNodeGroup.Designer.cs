namespace DieMonitoring
{
    partial class uc_UpperNodeGroup
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
            this.roundBorderPanel6 = new DieMonitoring.RoundBorderPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.roundBorderPanel8 = new DieMonitoring.RoundBorderPanel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.uc_DieNode1 = new DieMonitoring.uc_DieNode();
            this.uc_DieNode2 = new DieMonitoring.uc_DieNode();
            this.uc_DieNode3 = new DieMonitoring.uc_DieNode();
            this.uc_DieNode4 = new DieMonitoring.uc_DieNode();
            this.uc_DieNode5 = new DieMonitoring.uc_DieNode();
            this.uc_DieNode6 = new DieMonitoring.uc_DieNode();
            this.uc_DieNode7 = new DieMonitoring.uc_DieNode();
            this.roundBorderPanel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.roundBorderPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundBorderPanel6
            // 
            this.roundBorderPanel6.BorderColor = System.Drawing.Color.Black;
            this.roundBorderPanel6.BorderWidth = 2;
            this.roundBorderPanel6.Controls.Add(this.tableLayoutPanel1);
            this.roundBorderPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundBorderPanel6.FillColor = System.Drawing.Color.Black;
            this.roundBorderPanel6.IsBorder = true;
            this.roundBorderPanel6.IsFill = true;
            this.roundBorderPanel6.Location = new System.Drawing.Point(0, 0);
            this.roundBorderPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.roundBorderPanel6.Name = "roundBorderPanel6";
            this.roundBorderPanel6.Radius = 20;
            this.roundBorderPanel6.RoundPadding = 2;
            this.roundBorderPanel6.Size = new System.Drawing.Size(670, 200);
            this.roundBorderPanel6.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.roundBorderPanel8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uc_DieNode1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uc_DieNode2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.uc_DieNode3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.uc_DieNode4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uc_DieNode5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.uc_DieNode6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.uc_DieNode7, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 200);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // roundBorderPanel8
            // 
            this.roundBorderPanel8.BackColor = System.Drawing.Color.Transparent;
            this.roundBorderPanel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.roundBorderPanel8.BorderWidth = 2;
            this.roundBorderPanel8.Controls.Add(this.lbl_title);
            this.roundBorderPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundBorderPanel8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.roundBorderPanel8.IsBorder = true;
            this.roundBorderPanel8.IsFill = true;
            this.roundBorderPanel8.Location = new System.Drawing.Point(10, 15);
            this.roundBorderPanel8.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.roundBorderPanel8.Name = "roundBorderPanel8";
            this.roundBorderPanel8.Radius = 10;
            this.roundBorderPanel8.RoundPadding = 2;
            this.roundBorderPanel8.Size = new System.Drawing.Size(147, 70);
            this.roundBorderPanel8.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Font = new System.Drawing.Font("굴림", 25F);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(147, 70);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "상형";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // uc_DieNode1
            // 
            this.uc_DieNode1.BackColor = System.Drawing.Color.Transparent;
            this.uc_DieNode1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_DieNode1.Location = new System.Drawing.Point(172, 20);
            this.uc_DieNode1.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.uc_DieNode1.Name = "uc_DieNode1";
            this.uc_DieNode1.NodeNumber = "1";
            this.uc_DieNode1.Size = new System.Drawing.Size(157, 60);
            this.uc_DieNode1.TabIndex = 1;
            // 
            // uc_DieNode2
            // 
            this.uc_DieNode2.BackColor = System.Drawing.Color.Transparent;
            this.uc_DieNode2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_DieNode2.Location = new System.Drawing.Point(339, 20);
            this.uc_DieNode2.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.uc_DieNode2.Name = "uc_DieNode2";
            this.uc_DieNode2.NodeNumber = "2";
            this.uc_DieNode2.Size = new System.Drawing.Size(157, 60);
            this.uc_DieNode2.TabIndex = 2;
            // 
            // uc_DieNode3
            // 
            this.uc_DieNode3.BackColor = System.Drawing.Color.Transparent;
            this.uc_DieNode3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_DieNode3.Location = new System.Drawing.Point(506, 20);
            this.uc_DieNode3.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.uc_DieNode3.Name = "uc_DieNode3";
            this.uc_DieNode3.NodeNumber = "3";
            this.uc_DieNode3.Size = new System.Drawing.Size(159, 60);
            this.uc_DieNode3.TabIndex = 3;
            // 
            // uc_DieNode4
            // 
            this.uc_DieNode4.BackColor = System.Drawing.Color.Transparent;
            this.uc_DieNode4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_DieNode4.Location = new System.Drawing.Point(5, 120);
            this.uc_DieNode4.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.uc_DieNode4.Name = "uc_DieNode4";
            this.uc_DieNode4.NodeNumber = "4";
            this.uc_DieNode4.Size = new System.Drawing.Size(157, 60);
            this.uc_DieNode4.TabIndex = 4;
            // 
            // uc_DieNode5
            // 
            this.uc_DieNode5.BackColor = System.Drawing.Color.Transparent;
            this.uc_DieNode5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_DieNode5.Location = new System.Drawing.Point(172, 120);
            this.uc_DieNode5.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.uc_DieNode5.Name = "uc_DieNode5";
            this.uc_DieNode5.NodeNumber = "5";
            this.uc_DieNode5.Size = new System.Drawing.Size(157, 60);
            this.uc_DieNode5.TabIndex = 5;
            // 
            // uc_DieNode6
            // 
            this.uc_DieNode6.BackColor = System.Drawing.Color.Transparent;
            this.uc_DieNode6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_DieNode6.Location = new System.Drawing.Point(339, 120);
            this.uc_DieNode6.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.uc_DieNode6.Name = "uc_DieNode6";
            this.uc_DieNode6.NodeNumber = "6";
            this.uc_DieNode6.Size = new System.Drawing.Size(157, 60);
            this.uc_DieNode6.TabIndex = 6;
            // 
            // uc_DieNode7
            // 
            this.uc_DieNode7.BackColor = System.Drawing.Color.Transparent;
            this.uc_DieNode7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_DieNode7.Location = new System.Drawing.Point(506, 120);
            this.uc_DieNode7.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.uc_DieNode7.Name = "uc_DieNode7";
            this.uc_DieNode7.NodeNumber = "7";
            this.uc_DieNode7.Size = new System.Drawing.Size(159, 60);
            this.uc_DieNode7.TabIndex = 7;
            // 
            // uc_UpperNodeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundBorderPanel6);
            this.Name = "uc_UpperNodeGroup";
            this.Size = new System.Drawing.Size(670, 200);
            this.roundBorderPanel6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.roundBorderPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundBorderPanel roundBorderPanel6;
        private RoundBorderPanel roundBorderPanel8;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private uc_DieNode uc_DieNode1;
        private uc_DieNode uc_DieNode2;
        private uc_DieNode uc_DieNode3;
        private uc_DieNode uc_DieNode4;
        private uc_DieNode uc_DieNode5;
        private uc_DieNode uc_DieNode6;
        private uc_DieNode uc_DieNode7;
    }
}
