using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day08
{
    public partial class Addbook : Form
    {
        private string constr;
        public Addbook(string conStr)
        {
            InitializeComponent();
            this.constr = conStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookname = input1.Text;
            string author = input2.Text;
            double price = double.Parse(inputNumber1.Text);
            string lab = input3.Text;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                string Sql = "insert into book(name,author,price,label,is_borrow)value(@bookname,@author,@price,@label,@is_borrow)";
                using (MySqlCommand com = new MySqlCommand(Sql, con))
                {
                    com.Parameters.AddWithValue("@bookname", bookname);
                    com.Parameters.AddWithValue("@author", author);
                    com.Parameters.AddWithValue("@price", price);
                    com.Parameters.AddWithValue("@label", lab);
                    com.Parameters.AddWithValue("@is_borrow", 2);
                    int row = com.ExecuteNonQuery();
                    if (row > 0) 
                    { 
                        MessageBox.Show("添加成功");
                    }
                    else MessageBox.Show("添加失败");
                }
            }
            this.Close();
        }
    }
}
