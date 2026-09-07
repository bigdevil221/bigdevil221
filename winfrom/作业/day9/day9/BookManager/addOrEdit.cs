using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace day9.BookManager
{
    public partial class addOrEdit : Form
    {
        private MySql mysql = new MySql("text");
        private string title { get; set; }
        private string id { get; set; }
        public addOrEdit()
        {
            InitializeComponent();
        }
        public addOrEdit(string title)
        {
            InitializeComponent();
            label1.Text = "图书" + title;
            button1.Text = title;
            this.title = title;
        }
        public addOrEdit(string title ,string id)
        {
            InitializeComponent();
            label1.Text = "图书" + title;
            button1.Text = title;
            this.title = title;
            this.id = id;
            showdata();
        }
        //图书修改界面
        private void button1_Click(object sender, EventArgs e)
        {
            addoredit();
        }
        //封装一下
        public async Task addoredit()
        {
            string name = input1.Text;
            string author = input2.Text;
            double price = double.Parse(inputNumber1.Text);
            string lab = input3.Text;
            string sql = "";
            if (title == "新增") sql = "insert into book(name,author,price,label) value(@name,@author,@price,@label)";
            else sql = "update book set name=@name,author=@author,price=@price,label=@label where id=@id";
            await mysql.LinkSql(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@label", lab);
                if (title == "编辑") cmd.Parameters.AddWithValue("@id", id);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show(this.title + "成功");
                    this.Close();

                }
                else
                {
                    MessageBox.Show(this.title + "失败");
                }
            });
        }
        //展示数据并回填到文本框
        private async Task showdata()
        {
            string sql = "sleect * from where id=@id";
            await mysql.LinkSql(sql, cmd => {
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                bool IsRead = reader.Read();
                if (!IsRead)
                {
                    MessageBox.Show("编辑失败!!!");
                    this.Close();
                    return;
                }
                input1.Text = reader.GetString("name");
                input2.Text = reader.GetString("author");
                input3.Text = reader.GetString("label");
                inputNumber1.Value = (decimal)reader.GetDouble("price");
            });
        }
    }
}
