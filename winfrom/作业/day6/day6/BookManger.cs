using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace day6
{
    public partial class BookManger : Form
    {
        public BookManger()
        {
            InitializeComponent();
            init();
        }

        private void AddBook(bookinfo book)
        {
            booklist.Add(book);
            string str = JsonSerializer.Serialize(booklist, new JsonSerializerOptions()
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            File.WriteAllText("./book.json", str);
        }

        internal List<bookinfo> booklist = new();
        //初始化
        private void init()
        {
            addBtn.Click += AddBtn_Click;
            eitBtn.Click += EitBtn_Click;
            showBtn.Click += ShowBtn_Click;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form1 f1=new Form1();
            //父窗口绑定接收数据方法
            f1.sendData += AddBook;
            f1.Show();
            
        }        
        private void EitBtn_Click(object sender, EventArgs e)
        {
            Form2 f2=new Form2();
            f2.Show();
        }
        private void ShowBtn_Click(object sender, EventArgs e)
        {
            List<bookinfo> books = new List<bookinfo>();
            if (File.Exists("./book.json"))
            {
                string JsonStr = File.ReadAllText("./book.json");
                books = JsonSerializer.Deserialize<List<bookinfo>>(JsonStr);
            }
            Form3 f3 =new Form3(books);
            f3.Show();
        }

        


    }
}
