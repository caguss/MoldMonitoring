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
            this.dgv_History = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_History
            // 
            this.dgv_History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_History.Location = new System.Drawing.Point(0, 0);
            this.dgv_History.MainView = this.gridView1;
            this.dgv_History.Name = "dgv_History";
            this.dgv_History.Size = new System.Drawing.Size(431, 465);
            this.dgv_History.TabIndex = 0;
            this.dgv_History.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgv_History;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Popup_AlertHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 465);
            this.Controls.Add(this.dgv_History);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Popup_AlertHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Popup_AlertHistory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Popup_AlertHistory_FormClosed);
            this.Load += new System.EventHandler(this.Popup_AlertHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgv_History;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}