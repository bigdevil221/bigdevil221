using System.Drawing.Drawing2D;

namespace day12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Paint += Panel1_Paint;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //配置抗锯齿
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.Yellow, 5))
            {
                g.DrawRectangle(pen, 20, 20, 100, 100);
                g.DrawEllipse(pen, 280, 20, 100, 100);
                g.DrawLine(pen, 580, 100, 680, 30);
                Point[] point = new Point[]{
                    new Point(70,250),
                    new Point(120,300),                    
                    new Point(100,350),
                    new Point(40,350),
                    new Point(20,300)
                };
                //
                g.DrawPolygon(pen, point);
            }
            using (Brush brush = new SolidBrush(Color.Pink)) 
            {
                g.FillRectangle(brush, 140, 20, 120, 150);
                g.FillEllipse(brush, 400, 20, 120, 100);
            }
            using(Brush brush=new SolidBrush(Color.Red))
            using (Font font = new Font("微软雅黑", 8))
            {
                g.DrawString("我是文字", font, brush, 50, 150);
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    g.DrawString("我是文字", font, brush, 50, 200, sf);
                }
            }
            //画三角形
            Point[] point1 = new Point[3];
            //圆心到等边三角形坐标点夹角
            double[] angles = { 30, 150, 270 };
            int radius = 50;
            int ox = 250;
            int oy = 300;
            for (int i = 0; i < 3; i++)
            {
                var x = Math.Cos(angles[i] * Math.PI / 180) * radius + ox;
                var y = Math.Sin(angles[i] * Math.PI / 180) * radius + oy;
                point1[i]=new Point((int)x,(int)y);
                //MessageBox.Show($"point1[{i}] = ({x}, {y})");
            }
            using (Pen pen = new Pen(Color.Green))
            {
                g.DrawPolygon(pen, point1);
            }

            using (Pen pen = new Pen(Color.BurlyWood))
            {
                g.DrawArc(pen, 400, 300, 100, 100,180,180);
            }
        }

    }
}
