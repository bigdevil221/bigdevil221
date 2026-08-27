using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private DateTime starttime = new();
        bool falg = true;
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            //需要设置开关，不然一直是最新的time
            if (falg)
            {
                starttime = DateTime.Now;
                falg = false;
            }

        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            falg = true;
            DateTime endtime = DateTime.Now;
            TimeSpan restime = endtime - starttime;
            label2.Text = restime.TotalMilliseconds.ToString("#,#");
        }
    }
}
