using AntdUI;
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
            //初始化调用展示数据库
            init();
            //给所有按钮绑定事件
            table1.CellButtonClick += Table1_CellButtonClick;
        }
        //连接数据库方法
        private async Task init()
        {
            string sql = "select * from book ";
            await mysql.LinkSql(sql, cmd =>
            {
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);//把适配器装入内存表
                table1.DataSource = dt;
                //设置表头函数
                setcolumn();
            });
        }

        private async void Table1_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            //获取当前行
            DataRow row = (DataRow)e.Record;
            string id = row["id"].ToString();
            string str = "";
            //判断是哪个按钮
            if (e.Btn.Id == "Edit")
            {
                addOrEdit aog= new addOrEdit("编辑", id);
                aog.Show();
            }
            else if (e.Btn.Id == "Delete")
            {
                MessageBox.Show(row["id"].ToString());
                str = "delete from book where id=@id";
                await mysql.LinkSql(str, cmd =>
                {
                    cmd.Parameters.AddWithValue("@id", id); 
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("删除成功!!");
                        init();
                    }
                    else
                    {
                        MessageBox.Show("删除失败!!!");
                    }
                });
            }
            else if (e.Btn.Id == "borrow")
            {
                str = "UPDATE book SET is_borrow=@is_borrow WHERE id=@id";
                if (row["is_borrow"].ToString() == "1")
                {
                    MessageBox.Show("当前书籍已借阅");
                    return;
                }
                else
                {
                    await mysql.LinkSql(str, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@is_borrow", 2);
                        cmd.Parameters.AddWithValue("@id", row["id"]);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show(e.Btn.Text + "成功");
                            init();
                        }
                        else MessageBox.Show(e.Btn.Text + "失败");
                    });
                }
            }
            else if (e.Btn.Id == "return")
            {
                str = "UPDATE book SET is_borrow=@is_borrow WHERE id=@id";
                if (row["is_borrow"].ToString() == "2")
                {
                    MessageBox.Show("当前书籍已归还");
                    return;
                }
                else
                {
                    await mysql.LinkSql(str, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@is_borrow", 1);
                        cmd.Parameters.AddWithValue("@id", row["id"]);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show(e.Btn.Text + "成功");
                            init();
                        }
                        else MessageBox.Show(e.Btn.Text + "失败");
                    });
                }
            }

        }

        //设置表头
        private void setcolumn()
        {
            table1.Columns.Clear();
            table1.ColumnBack = Color.FromArgb(119, 78, 45); // 深棕背景
            table1.ColumnFore = Color.White;
            //table1.ScrollBarAvoidHeader = false;
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
                    //枚举值 2是未借阅 1是已借阅
                    Render =(object val, object cel, int rowIndex)=>val.ToString()=="2"?"未借阅":"已借阅"
                },
                new AntdUI.Column("Edit", "编辑")
                {
                    Render = (object val, object cel, int index) =>
                    new AntdUI.CellButton("Edit", "编辑")
                    {
                        Back = Color.Blue,
                        BackHover = Color.FromArgb(189, 224, 255),
                        Radius = 6
                    },
                },
                new AntdUI.Column("Delete", "删除")
                {
                    Render = (object val, object cel, int index) => new AntdUI.CellButton("Delete", "删除")
                    {
                        Back = Color.Red,
                        BackHover = Color.FromArgb(255, 204, 199),
                        Radius = 6
                    },
                },
                new AntdUI.Column("action", "操作")
                {
                    Render = (object val, object cel, int index) =>
                    new AntdUI.CellLink[]{
                        new AntdUI.CellButton("borrow", "借阅")
                        {
                            Back = Color.Green,
                            BackHover = Color.FromArgb(199, 235, 210),
                            Radius = 6
                        },
                        new AntdUI.CellButton("return", "归还")
                        {
                            Back = Color.Green,
                            BackHover = Color.FromArgb(238, 210, 176),
                            Radius = 6
                        }
                    }
                },
            };
        }
        //新增图书按钮
        private void button1_Click(object sender, EventArgs e)
        {
            addOrEdit aoe = new addOrEdit("新增");
            aoe.Show();
        }
    }
}
