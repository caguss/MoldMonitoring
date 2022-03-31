using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieMonitoring
{
    public partial class Popup_AlertHistory : Form
    {
        uc_AlarmHistory parentdata;
        public Popup_AlertHistory(uc_AlarmHistory parent)
        {
            InitializeComponent();
            parentdata = parent;
        }

        private void Popup_AlertHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentdata.modalIsOpen = false;
        }

        private void Popup_AlertHistory_Load(object sender, EventArgs e)
        {
            parentdata.modalIsOpen = true;
        }
    }
}
