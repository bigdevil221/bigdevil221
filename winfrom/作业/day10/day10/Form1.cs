namespace day10
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
            show();
            timer = new System.Windows.Forms.Timer();
            //定时器间隔时间
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            show();
        }

        private void show()
        {
            DateTime now = DateTime.Now;
            DateTime future = new DateTime(2026, 10, 01, 0, 0, 0);
            TimeSpan endtime = future - now;
            label2.Text = $"{endtime.Days}天{endtime.Hours}时{endtime.Minutes}分{endtime.Seconds}秒";
            pictureBox3.Image = Image.FromFile(@"./pic/day.png");
            pictureBox6.Image = Image.FromFile(@"./pic/hour.png");
            pictureBox9.Image = Image.FromFile(@"./pic/minutes.png");
            pictureBox12.Image = Image.FromFile(@"./pic/seconds.png");
            //拼接一下数字
            string timestr = $"{endtime.Days:00}{endtime.Hours:00}{endtime.Minutes:00}{endtime.Seconds:00}";
            PictureBox[] picarr = [pictureBox1, pictureBox2, pictureBox4, pictureBox5, pictureBox7, pictureBox8, pictureBox10, pictureBox11];
            for (int i = 0; i < picarr.Length; i++)
            {
                picarr[i].Image = Image.FromFile(@"./pic/" + timestr[i] + ".png");
            }
        }

    }
}
