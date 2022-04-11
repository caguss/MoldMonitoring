namespace DieMonitoring
{
    partial class uc_AlarmHistoryNode
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
            this.lbl_AlarmString = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_CheckAlarm = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_DeleteAlarm = new System.Windows.Forms.Label();
            this.lbl_OccurTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_AlarmString, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_OccurTime, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_AlarmString
            // 
            this.lbl_AlarmString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_AlarmString.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lbl_AlarmString.ForeColor = System.Drawing.Color.White;
            this.lbl_AlarmString.Location = new System.Drawing.Point(3, 0);
            this.lbl_AlarmString.Name = "lbl_AlarmString";
            this.lbl_AlarmString.Size = new System.Drawing.Size(494, 60);
            this.lbl_AlarmString.TabIndex = 0;
            this.lbl_AlarmString.Text = "test Notification";
            this.lbl_AlarmString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DieMonitoring.Properties.Resources.ButtonImage;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbl_CheckAlarm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(803, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 54);
            this.panel1.TabIndex = 1;
            // 
            // lbl_CheckAlarm
            // 
            this.lbl_CheckAlarm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CheckAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_CheckAlarm.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_CheckAlarm.ForeColor = System.Drawing.Color.White;
            this.lbl_CheckAlarm.Location = new System.Drawing.Point(0, 0);
            this.lbl_CheckAlarm.Name = "lbl_CheckAlarm";
            this.lbl_CheckAlarm.Size = new System.Drawing.Size(94, 54);
            this.lbl_CheckAlarm.TabIndex = 0;
            this.lbl_CheckAlarm.Text = "확인";
            this.lbl_CheckAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_CheckAlarm.Click += new System.EventHandler(this.lbl_CheckAlarm_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DieMonitoring.Properties.Resources.ButtonImage;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbl_DeleteAlarm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(903, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 54);
            this.panel2.TabIndex = 2;
            // 
            // lbl_DeleteAlarm
            // 
            this.lbl_DeleteAlarm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DeleteAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_DeleteAlarm.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_DeleteAlarm.ForeColor = System.Drawing.Color.White;
            this.lbl_DeleteAlarm.Location = new System.Drawing.Point(0, 0);
            this.lbl_DeleteAlarm.Name = "lbl_DeleteAlarm";
            this.lbl_DeleteAlarm.Size = new System.Drawing.Size(94, 54);
            this.lbl_DeleteAlarm.TabIndex = 0;
            this.lbl_DeleteAlarm.Text = "삭제";
            this.lbl_DeleteAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_DeleteAlarm.Click += new System.EventHandler(this.lbl_DeleteAlarm_Click);
            // 
            // lbl_OccurTime
            // 
            this.lbl_OccurTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_OccurTime.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lbl_OccurTime.ForeColor = System.Drawing.Color.White;
            this.lbl_OccurTime.Location = new System.Drawing.Point(500, 0);
            this.lbl_OccurTime.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_OccurTime.Name = "lbl_OccurTime";
            this.lbl_OccurTime.Size = new System.Drawing.Size(300, 60);
            this.lbl_OccurTime.TabIndex = 3;
            this.lbl_OccurTime.Text = "0000-00-00 00:00:00";
            this.lbl_OccurTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uc_AlarmHistoryNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "uc_AlarmHistoryNode";
            this.Size = new System.Drawing.Size(1000, 60);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_AlarmString;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_CheckAlarm;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbl_DeleteAlarm;
        private System.Windows.Forms.Label lbl_OccurTime;
    }
}
