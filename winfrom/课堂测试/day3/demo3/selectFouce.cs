using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace demo3
{
    public partial class selectFouce : Form
    {
        public selectFouce()
        {
            InitializeComponent();
            comboBox1.GotFocus += ComboBox1_GotFocus;
            comboBox1.Leave += ComboBox1_Leave;
        }

        private void ComboBox1_Leave(object sender, EventArgs e)
        {
            ComboBox cb = (sender as ComboBox);
            cb.DroppedDown = false;
        }

        private void ComboBox1_GotFocus(object sender, EventArgs e)
        {
            ComboBox cb = (sender as ComboBox);
            cb.DroppedDown = true;
        }

        private void selectFouce_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
