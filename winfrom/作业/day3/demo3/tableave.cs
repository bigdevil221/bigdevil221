using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace demo3
{
    public partial class tableave : Form
    {
        public tableave()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (sender as TextBox);
            if (string.IsNullOrEmpty(tb.Text))
            {

            }
        }
    }
}
