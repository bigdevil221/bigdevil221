namespace day2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;
            if (btn1.Text=="打开")
            {
                pictureBox1.Image = Image.FromFile(@"./images/on.png");
                btn1.Text = "关闭";
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"./images/off.png");
                btn1.Text = "打开";
            }
        }
    }
}
