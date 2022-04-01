namespace DieMonitoring
{
    partial class uc_OptionButton
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
            this.lbl_OptionSetting = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_OptionSetting
            // 
            this.lbl_OptionSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_OptionSetting.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_OptionSetting.ForeColor = System.Drawing.Color.White;
            this.lbl_OptionSetting.Location = new System.Drawing.Point(0, 0);
            this.lbl_OptionSetting.Name = "lbl_OptionSetting";
            this.lbl_OptionSetting.Size = new System.Drawing.Size(120, 120);
            this.lbl_OptionSetting.TabIndex = 0;
            this.lbl_OptionSetting.Text = "옵션\r\n설정";
            this.lbl_OptionSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_OptionSetting.Click += new System.EventHandler(this.lbl_OptionSetting_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbl_OptionSetting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 120);
            this.panel1.TabIndex = 1;
            // 
            // uc_OptionButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::DieMonitoring.Properties.Resources.OptionButton;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "uc_OptionButton";
            this.Size = new System.Drawing.Size(120, 120);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_OptionSetting;
        private System.Windows.Forms.Panel panel1;
    }
}
