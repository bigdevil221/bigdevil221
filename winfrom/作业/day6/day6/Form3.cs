using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private List<bookinfo> bk = new();
        internal Form3(List<bookinfo> booklist)
        {
            InitializeComponent();
            this.bk = booklist;
            init();
        }
        
        private void init()
        {
            table1.DataSource = bk;
            table1.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column("Id","编号")
                {
                    Render=(object val,object cel,int
                     index)=>index.ToString(),
                },
                new AntdUI.Column("Bookname","书籍名称"),
                new AntdUI.Column("Author","作者"),
                new AntdUI.Column("Price","价格"),
                new AntdUI.Column("Lab","标签"),
                new AntdUI.Column("isborrow", "是否借阅")
                {
                    Render = (object val,object cel,int index) =>
                    {
                        return (bool)val?"已借阅":"书架中";
                    }
                },
            };
            table1.Columns.Add(new AntdUI.Column("Handler1", "操作")
            {
                Render =(object val,object cel,int index)=>"删除"
            });
            table1.Columns.Add(new AntdUI.Column("Handler2", "操作")
            {
                Render = (object val, object cel, int index) => "编辑"
            });
            table1.CellClick += Table1_CellClick;
        }

        private void Table1_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            bookinfo book = e.Record as bookinfo;
            if (e.ColumnIndex.ToString()=="6")
            {
                return;
            }
            if (e.ColumnIndex.ToString() == "7")
            {
                //new Form2(book.Id).Show();
            }
        }
    }
}
