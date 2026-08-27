namespace day4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int speed = 30;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Point p1 = panel1.Location;
            int maxX = this.Width - panel1.Width;
            int maxY = this.Height - panel1.Height;
            switch (e.KeyCode) {
                case Keys.W:
                    p1.Y -= speed;
                    if (p1.Y < 0) p1.Y = 0;
                    break;
                case Keys.A:
                    p1.X -= speed;
                    if (p1.X < 0) p1.X = 0;
                    break;
                case Keys.S:
                    p1.Y += speed;
                    if (p1.Y >maxY) p1.Y = maxY;
                    break;
                case Keys.D:
                    p1.X += speed;
                    if (p1.X < maxX) p1.X = maxX;
                    break;
                default:
                    break;
            }
            panel1.Location = p1;
        }
    }
}
