namespace DieMonitoring
{
    partial class CustomPopUp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_FormName = new System.Windows.Forms.Label();
            this.btn_Maximize = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_FormName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Maximize, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Minimize, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Close, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 25);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_FormName
            // 
            this.lbl_FormName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.lbl_FormName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_FormName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_FormName.ForeColor = System.Drawing.Color.White;
            this.lbl_FormName.Location = new System.Drawing.Point(0, 0);
            this.lbl_FormName.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_FormName.Name = "lbl_FormName";
            this.lbl_FormName.Size = new System.Drawing.Size(680, 25);
            this.lbl_FormName.TabIndex = 0;
            this.lbl_FormName.Text = "FormName";
            this.lbl_FormName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_FormName.DoubleClick += new System.EventHandler(this.btn_Maximize_Click);
            this.lbl_FormName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_FormName_MouseDown);
            this.lbl_FormName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_FormName_MouseMove);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.BackgroundImage = global::DieMonitoring.Properties.Resources.FormMaximize;
            this.btn_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Maximize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Maximize.Location = new System.Drawing.Point(720, 0);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(40, 25);
            this.btn_Maximize.TabIndex = 2;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackgroundImage = global::DieMonitoring.Properties.Resources.FormMinimize;
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Minimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Minimize.Location = new System.Drawing.Point(680, 0);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(40, 25);
            this.btn_Minimize.TabIndex = 4;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::DieMonitoring.Properties.Resources.Formclose;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Close.Location = new System.Drawing.Point(760, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(40, 25);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // CustomPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomPopUp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lbl_FormName;
        private System.Windows.Forms.Panel btn_Maximize;
        private System.Windows.Forms.Panel btn_Minimize;
        private System.Windows.Forms.Panel btn_Close;
    }
}