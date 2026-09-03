using AntdUI;
using day9.BookManager;
using day9.user;

namespace day9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }
        //定义一个token 判断登陆状态
        public bool token = false;
        //判断用户登录状态
        private void init()
        {
            if (token)
            {
                label2.ForeColor = Color.Green;
                label3.Text = "已登录";
            }
            else
            {
                label2.ForeColor = SystemColors.ActiveBorder;
                label3.Text = "未登录";
            }
        }
        //图书管理按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (token)
            {
                //登陆状态
                bookmanager bk = new bookmanager();
                bk.Show();
                this.Hide();
                //如果管理界面是窗口关闭，这个打开
                bk.FormClosing += (object sender, FormClosingEventArgs e) => { this.Show(); };
            }
            else
            {
                //未登录状态
                login lgn = new login();
                lgn.Show();
                this.Hide();
                //绑定事件接收参数token
                lgn.setToken += (bool token) => { this.token = token; init(); };
                //如果登陆界面关闭，这个打开
                lgn.FormClosing += (object sender, FormClosingEventArgs e) => { this.Show(); };
            }

        }


    }
}
