using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day9.BookManager
{
    public partial class bookmanager : Form
    {
        private MySql mysql = new MySql("text");
        public bookmanager()
        {
            InitializeComponent();
            init();
        }
        //初始化界面，连接数据库
        private async Task init()
        {
            string sql = "select * from book ";
            await mysql.LinkSql(sql, cmd =>
            {
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);//把适配器装入内存表
                table1.DataSource = dt;
                //设置一下表头
                setcolumn();
            });
        }
        //设置表头
        private void setcolumn()
        {
            table1.Columns.Clear();
            table1.Columns = new AntdUI.ColumnCollection()
            {
                new AntdUI.Column("id","编号"){
                    Render =(object val, object cel, int rowIndex)=>rowIndex+1
                },
                new AntdUI.Column("name","书名"),
                new AntdUI.Column("author","作者"),
                new AntdUI.Column("price","价格"),
                new AntdUI.Column("label","标签"),
                new AntdUI.Column("is_borrow", "借阅")
                {
                    Render =(object val, object cel, int rowIndex)=>val.ToString()=="1"?"未借阅":"已借阅"
                },
            };
            var handercol = new AntdUI.Column("Edit", "修改")
            {
                Render = (object val, object cel, int index) => "编辑"
            };
            var handercol2 = new AntdUI.Column("Delete", "操作")
            {
                Render = (object val, object cel, int index) => "删除"
            };
            table1.Columns.Add(handercol);
            table1.Columns.Add(handercol2);
        }
        //新增图书按钮
        private void button1_Click(object sender, EventArgs e)
        {
            addOrEdit aoe=new addOrEdit("新增");
            aoe.Show();
        }
    }
}
