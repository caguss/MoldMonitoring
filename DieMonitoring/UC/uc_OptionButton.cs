﻿using System;
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
        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion

        public bool modalIsOpen = false;
        public uc_OptionButton()
        {
            InitializeComponent();

            //lbl_OptionSetting.Font = Program.Normalfont;
        }

        private void lbl_OptionSetting_Click(object sender, EventArgs e)
        {
            Popup_Setting test = new Popup_Setting(this);
            test.Show();
        }
    }
}
