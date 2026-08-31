namespace day5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }
        private Dictionary<string, Color> color {  get; set; }
        private void init()
        {
            color = new()
            {
                ["红色"] = Color.Red,
                ["橙色"] = Color.Orange,
                ["黄色"] = Color.Yellow,
                ["绿色"] = Color.Green,
                ["青色"] = Color.Cyan,
                ["蓝色"] = Color.Blue,
                ["紫色"] = Color.Purple,
            };
            select1.Items.AddRange(color.Keys.ToArray());
            select1.SelectedIndexChanged += changed;
        }

        private void changed(object sender, AntdUI.IntEventArgs e)
        {
            string sColor = select1.SelectedValue.ToString();
            this.BackColor = color[sColor];
        }
    }
}
