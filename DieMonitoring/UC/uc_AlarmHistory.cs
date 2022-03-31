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
    public partial class uc_AlarmHistory : UserControl
    {
        public bool modalIsOpen = false;
        public uc_AlarmHistory()
        {
            InitializeComponent();

            lbl_AlarmHistory.Font = Program.Normalfont;
        }

        private void lbl_AlarmHistory_Click(object sender, EventArgs e)
        {
            if (!modalIsOpen)
            {
                Popup_AlertHistory modal = new Popup_AlertHistory(this);
                modal.Show();
            }
        }
    }
}
