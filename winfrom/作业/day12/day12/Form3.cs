using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace day12
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            panel1.Paint += Panel1_Paint;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //定义一个刻度长度
            int tmpweight = 10;
            int ox = 120;
            int oy = 120;
            //抗锯齿
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.Green, 5))
            {
                g.DrawArc(pen, 20, 20, 200, 200, 180, 180);
                //画指针
                double angle = (180 + 180.0 / 60 * 40) * Math.PI / 180;
                double x = Math.Cos(angle) * (100 - tmpweight) + ox;
                double y = Math.Sin(angle) * (100 - tmpweight) + oy;
                g.DrawLine(pen, ox, oy,(int)x,(int)y);
            }
            ;
            //画刻度
            int radius = 100;
            using (Pen pen1 = new Pen(Color.Orange, 1))
            {
                for (int i = 0; i <= 60; i++)
                {
                    double angle = (180 + 180.0 / 60 * i) * Math.PI / 180;
                    if (i % 20 == 0)
                    {
                        tmpweight = 20;
                        using (Brush brush = new SolidBrush(Color.Black))
                        using (System.Drawing.Font font = new System.Drawing.Font("微软雅黑", 8))
                        {
                            double x = Math.Cos(angle) * (radius - tmpweight) + ox;
                            double y = Math.Sin(angle) * (radius - tmpweight) + oy;
                            g.DrawString(i.ToString(), font, brush, (int)x, (int)y);
                        }
                    }
                    else tmpweight = 10;
                    double startx = Math.Cos(angle) * radius + ox;
                    double starty = Math.Sin(angle) * radius + oy;
                    double endx = Math.Cos(angle) * (radius - tmpweight) + ox;
                    double endy = Math.Sin(angle) * (radius - tmpweight) + oy;
                    g.DrawLine(pen1, (int)startx, (int)starty, (int)endx, (int)endy);
                }
            }
        }
    }
}
