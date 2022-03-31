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
    public partial class uc_OptionButton : UserControl
    {
        public bool modalIsOpen = false;
        public uc_OptionButton()
        {
            InitializeComponent();

            lbl_OptionSetting.Font = Program.Normalfont;
        }

    }
}
