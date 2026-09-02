using AntdUI;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string id {  get; set; }
        internal Form2(string Id)
        {
            InitializeComponent();
             this.id=Id;
            init();
        }
        private List<bookinfo> bks = new();
        private void init()
        {
            string JsonStr = File.ReadAllText("./book.json");
            bks = JsonSerializer.Deserialize<List<bookinfo>>(JsonStr);
            bookinfo book = bks.Find(item => item.Id == id);
            input1.Text = book.Bookname;
            input2.Text = book.Author;
            input3.Text = book.Price.ToString();
            input4.Text = book.Lab;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookinfo book = bks.Find(item => item.Id == id);
            bks.Remove(book);
            string bookname = input1.Text;
            string author = input2.Text;
            double price = double.Parse(input3.Text);
            string lab = input4.Text;
            bool isborrow = false;
            bks.Add(new bookinfo(id, bookname, author, price, lab, isborrow));
            string JsonStr = JsonSerializer.Serialize(bks, new JsonSerializerOptions()
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            File.WriteAllText("./book.json", JsonStr);
            this.Close();
        }
    }
}
