using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
        //图书修改界面
        private async Task button1_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@label", lab);
                //if (title =="编辑")cmd.Parameters.AddWithValue("@id", id);
                int rows=cmd.ExecuteNonQuery();
                if (rows>0)
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
    }
}
