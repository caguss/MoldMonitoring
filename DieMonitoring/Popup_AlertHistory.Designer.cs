namespace DieMonitoring
{
    partial class Popup_AlertHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup_AlertHistory));
            this.tlp_alarmlist = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlp_ControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_CheckAll = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_DeleteAll = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tlp_ControlPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_alarmlist
            // 
            this.tlp_alarmlist.AutoSize = true;
            this.tlp_alarmlist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_alarmlist.ColumnCount = 1;
            this.tlp_alarmlist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_alarmlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_alarmlist.Location = new System.Drawing.Point(0, 64);
            this.tlp_alarmlist.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_alarmlist.Name = "tlp_alarmlist";
            this.tlp_alarmlist.RowCount = 1;
            this.tlp_alarmlist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_alarmlist.Size = new System.Drawing.Size(740, 0);
            this.tlp_alarmlist.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tlp_alarmlist);
            this.panel1.Controls.Add(this.tlp_ControlPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 486);
            this.panel1.TabIndex = 2;
            // 
            // tlp_ControlPanel
            // 
            this.tlp_ControlPanel.ColumnCount = 4;
            this.tlp_ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ControlPanel.Controls.Add(this.panel2, 1, 0);
            this.tlp_ControlPanel.Controls.Add(this.panel3, 2, 0);
            this.tlp_ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.tlp_ControlPanel.Name = "tlp_ControlPanel";
            this.tlp_ControlPanel.RowCount = 1;
            this.tlp_ControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ControlPanel.Size = new System.Drawing.Size(740, 64);
            this.tlp_ControlPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DieMonitoring.Properties.Resources.ButtonImage;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbl_CheckAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(173, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 58);
            this.panel2.TabIndex = 0;
            // 
            // lbl_CheckAll
            // 
            this.lbl_CheckAll.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CheckAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_CheckAll.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_CheckAll.ForeColor = System.Drawing.Color.White;
            this.lbl_CheckAll.Location = new System.Drawing.Point(0, 0);
            this.lbl_CheckAll.Name = "lbl_CheckAll";
            this.lbl_CheckAll.Size = new System.Drawing.Size(194, 58);
            this.lbl_CheckAll.TabIndex = 0;
            this.lbl_CheckAll.Text = "전체확인";
            this.lbl_CheckAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_CheckAll.Click += new System.EventHandler(this.lbl_CheckAll_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::DieMonitoring.Properties.Resources.AlarmHistoryButton;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lbl_DeleteAll);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(373, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 58);
            this.panel3.TabIndex = 1;
            // 
            // lbl_DeleteAll
            // 
            this.lbl_DeleteAll.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DeleteAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_DeleteAll.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_DeleteAll.ForeColor = System.Drawing.Color.White;
            this.lbl_DeleteAll.Location = new System.Drawing.Point(0, 0);
            this.lbl_DeleteAll.Name = "lbl_DeleteAll";
            this.lbl_DeleteAll.Size = new System.Drawing.Size(194, 58);
            this.lbl_DeleteAll.TabIndex = 0;
            this.lbl_DeleteAll.Text = "전체삭제";
            this.lbl_DeleteAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_DeleteAll.Click += new System.EventHandler(this.lbl_DeleteAll_Click);
            // 
            // Popup_AlertHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 511);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Popup_AlertHistory";
            this.Text = "Popup_AlertHistory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Popup_AlertHistory_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Popup_AlertHistory_FormClosed);
            this.Load += new System.EventHandler(this.Popup_AlertHistory_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlp_ControlPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_alarmlist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlp_ControlPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_CheckAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_DeleteAll;
    }
}