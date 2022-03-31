using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieMonitoring
{
    public partial class MonitoringForm : Form
    {
        public MonitoringForm()
        {
            InitializeComponent();
            lbl_MoldName.Font = Program.BigFont;
            lblback.Font = Program.TitleFont;
            lblfront.Font = Program.TitleFont;
        }

        private void BorderAction(object sender, PaintEventArgs e)
        {

            int borderWidth = 2;
            Color borderColor = Color.White;



            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
             borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth,
            ButtonBorderStyle.Solid, borderColor, borderWidth,
             ButtonBorderStyle.Solid,
            borderColor, borderWidth, ButtonBorderStyle.Solid);
            base.OnPaint(e);

        }

        private void lblfront_Click(object sender, EventArgs e)
        {
            NodeGroup_FrontUpper.AlarmClear();
            NodeGroup_FrontLower.AlarmClear();
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            NodeGroup_BackUpper.AlarmClear();
            NodeGroup_BackLower.AlarmClear();
        }

        private void lbl_MoldName_Click(object sender, EventArgs e)
        {
            NodeGroup_FrontUpper.AlarmClear();
            NodeGroup_FrontLower.AlarmClear();
            NodeGroup_BackUpper.AlarmClear();
            NodeGroup_BackLower.AlarmClear();
        }
    }
}
