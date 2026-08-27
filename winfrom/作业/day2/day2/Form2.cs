using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            initTab();
        }
        string[] picArr = [@"./images/cat.jpg", @"./images/bird.jpg", @"./images/eagle.jpg"];
        public void initTab()
        {
            pictureBox1.Image=Image.FromFile(picArr[0]);
            for (int i = 0; i < picArr.Length; i++)
            {
                panel1.Controls[i].Click += btn_Click;
            }
        }
        public void btn_Click(object sender,EventArgs e )
        {
            //先把所有按钮还原
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].BackColor= Color.DarkGray;
                panel1.Controls[i].ForeColor = Color.White;
            }
            Button btn = (Button)sender;
            btn.BackColor = Color.Yellow;
            btn.ForeColor = Color.Black;
            //将图片给换掉
            int index = panel1.Controls.IndexOf(btn);
            pictureBox1.Image = Image.FromFile(picArr[index]);
        }

    }
}
