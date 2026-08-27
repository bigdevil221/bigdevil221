namespace demo3
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
            setclick();
        }
        private string[] picArr = [@"./images/cat.jpg", @"./images/bird.jpg", @"./images/eagle.jpg"];
        //设置索引
        private int index = 0;
        //butlist写在外面不然访问不到
        List<Button> btnlist= new List<Button>();
        //绑定所有事件
        public void setclick()
        {
            btnlist.AddRange([button1, button2, button3]);
            Label[] lablist = [label1, label2];
            foreach (Label i in lablist) i.Click += Label_click;
            foreach (Button i in btnlist) i.Click += Button_click;
        }
        public void Label_click(object sender, EventArgs e)
        {
            Label lab = (sender as Label);
            if (lab.Text == ">")
            {
                //如果是>那么index++ 还得限制一下index范围
                index = index == picArr.Length - 1 ? 0 : ++index;
            }
            else
            {
                //如果index等于0那么把它设置为最大长度
                index = index == 0 ? picArr.Length - 1 : --index;
            }
            //更换图片，且下方按钮也要切换到对应图片
            changeBtnAnd();
            btnlist[index].Focus();
        }
        public void Button_click(object sender, EventArgs e) {
            index=btnlist.IndexOf((Button)sender);
            changeBtnAnd();
        }
        //封装方法 
        //更换图片，且下方按钮也要切换到对应图片
        public void changeBtnAnd()
        {
            //更换图片，且下方按钮也要切换到对应图片
            pictureBox1.Image = Image.FromFile(picArr[index]);
            foreach (var btn in btnlist)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }
            btnlist[index].BackColor = Color.Pink;
            btnlist[index].ForeColor = Color.Purple;
        }

    }
}
