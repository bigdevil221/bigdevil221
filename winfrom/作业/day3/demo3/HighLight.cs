using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace demo3
{
    public partial class HighLight : Form
    {
        public HighLight()
        {
            InitializeComponent();
            setclick();
        }
        public void setclick()
        {
            textBox1.GotFocus += TextBox1_GotFocus;
            textBox1.Leave += TextBox1_Leave;
            button1.GotFocus += Button1_GotFocus;
            button1.Leave += Button1_Leave;  
        }

        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            TextBox tb = (sender as TextBox);
            tb.BackColor = Color.Pink;
            tb.ForeColor = Color.Blue;

        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            TextBox tb = (sender as TextBox);
            tb.BackColor = Color.White;
            tb.ForeColor = Color.Black;
        }

        private void Button1_GotFocus(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            btn.BackColor = Color.Pink;
            btn.ForeColor = Color.Blue;
        }

        private void Button1_Leave(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }
    }
}
