namespace day13
{
    public partial class Form1 : Form
    {
        //定义一个全局计时器
        private System.Windows.Forms.Timer golbaltimer = new();
        private Random random = new Random();
        private List<label> lablist = new();
        //定义初始速度
        private int speed = 5;
        //定义游戏等级
        private int leval = 1;
        //得分
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(120, Color.Black);
            //定时器间隔
            golbaltimer.Interval = 1000;
            golbaltimer.Tick += Golbaltimer_Tick;
            //绑定键盘事件
            this.KeyPreview = true;
            this.KeyUp += Form1_KeyUp;
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < lablist.Count; i++)
            {
                if (e.KeyCode.ToString() != lablist[i].lab.Text) continue;
                //如果是当前字母，清除掉
                panel1.Controls.Remove(lablist[i].lab);
                lablist[i].labtimer.Stop();
                lablist.RemoveAt(i);
                //加分
                score++;
                label2.Text = score.ToString();
                if (score % 10 == 0)
                {
                    leval++;
                    label4.Text = leval.ToString();
                    speed+=5;
                }
                return;
            }
        }

        private void Golbaltimer_Tick(object sender, EventArgs e)
        {
            setlab();
        }

        private void setlab()
        {
            //创建一个lab
            Label lab = new Label();
            lab.Text = ((Char)random.Next(65, 90)).ToString();
            lab.Font = new Font("微软雅黑", 18, FontStyle.Bold);
            lab.ForeColor = Color.FromArgb(
                random.Next(256),
                random.Next(256),
                random.Next(256)
            );
            lab.Size = new Size(30, 30);
            //随机位置
            lab.Location = new Point(random.Next(panel1.Width - 30), 0);
            System.Windows.Forms.Timer labtimer = new();
            labtimer.Interval = 100;
            label Label = new(lab, labtimer);
            //把创建的lab类塞进列表
            lablist.Add(Label);
            panel1.Controls.Add(lab);

            //让lab动起来
            labtimer.Tick += (object? sender, EventArgs e) => Labtimer_Tick(lab);
            labtimer.Start();
        }
        
        private void Labtimer_Tick(Label lab)
        {
            lab.Top += speed;
            //如果落地游戏结束
            if (lab.Top>=panel1.Height-30)
            {
                //关闭所有定时器
                golbaltimer.Stop();
                lablist.ForEach(item => item.labtimer.Stop());
                MessageBox.Show("GAME OVER！！！");
                //清除掉所有lab跟清空列表
                panel1.Controls.Clear();
                lablist.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
            label4.Text="1";
            speed = 5;
            golbaltimer.Start();
        }

        //开启双缓冲，防止屏幕闪烁
        public class MyPanel : Panel
        {
            public MyPanel()
            {
                this.DoubleBuffered = true;
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.UserPaint, true);
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            }
        }
    }
}
