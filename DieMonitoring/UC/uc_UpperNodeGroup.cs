using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieMonitoring
{
    public partial class uc_UpperNodeGroup : UserControl
    {
        public uc_UpperNodeGroup()
        {
            InitializeComponent();
            lbl_title.Font = Program.TitleFont;
        }

        public void ChangeNodeValue(string Nodenum, string value)
        {
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item.GetType() == typeof(uc_DieNode))
                {
                    if (((uc_DieNode)item).NodeNumber == Nodenum)
                    {
                        ((uc_DieNode)item).ChangeValue(value);
                    }
                }
            }
        }
        public void AlarmClear()
        {
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item.GetType() == typeof(uc_DieNode))
                {
                    ((uc_DieNode)item).CheckAlarm();
                }
            }
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item.GetType() == typeof(uc_DieNode))
                {
                    ((uc_DieNode)item).CheckAlarm();
                }
            }
        }
    }
}
