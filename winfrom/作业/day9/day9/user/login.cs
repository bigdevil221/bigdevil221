using day9.BookManager;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day9.user
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        //绑定委托给父窗口传递参数
        public event Action<bool> setToken;
        private MySql mysql = new MySql("text");
        //登录按钮
        private async void button1_Click(object sender, EventArgs e)
        {
            string username = input1.Text;
            string password = input2.Text;
            //sql语句
            string sql = "select * from user where username=@username And password=@password";
            await mysql.LinkSql(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                //拿符合条件的这一行数据
                MySqlDataReader Reader = cmd.ExecuteReader();
                //给父窗口传递登陆成功的token 
                if (Reader.Read())
                {
                    MessageBox.Show("登陆成功");
                    setToken.Invoke(true);
                    this.Close();
                    bookmanager bk = new bookmanager();
                    bk.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！！");
                    setToken.Invoke(false);
                    this.Close();
                    Form1 f1 = new Form1();
                    f1.Show();
                }

            });
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("11111111");
            AntdUI.Label lb = sender as AntdUI.Label;
            lb.ForeColor = Color.Blue;
            register reg = new register();            
            reg.Show();
            this.Close();

        }
    }
}
