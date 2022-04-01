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
    public partial class uc_LowerNodeGroup : UserControl
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

        #region .. code for Flucuring ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion
        public uc_LowerNodeGroup()
        {
            InitializeComponent();
            //lbl_title.Font = Program.TitleFont;
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
                    ((uc_DieNode)item).SafeAlarm();
                }
            }
        }
        private void lbl_title_Click(object sender, EventArgs e)
        {
            AlarmClear();
        }
    }
}
