using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace demo3
{
    public partial class textboxRgx : Form
    {
        public textboxRgx()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox tb = (sender as TextBox);
            if (Regex.IsMatch(tb.Text, @"1[1-9]\d{9}$"))
            {
                label2.Visible = true;
            }
            else
            {
                label1.Visible = true;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
        }

    }
}
