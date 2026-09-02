using MySqlConnector;
using System.Data;
namespace day08
{
    public partial class Form1 : Form
    {
        //数据库链接字符串
        private string conStr = "server=127.0.0.1;port=3306;database=text;uid=root;password=root;charset=utf8";
        public Form1()
        {
            InitializeComponent();
            selectData();
        }
        //封装查询
        private  void selectData()
        {
            //建立链接
            using (MySqlConnection con = new MySqlConnection(conStr))
            {
                con.Open();
                string Sql = "select *from book";
                //执行指令
                using (MySqlCommand com = new MySqlCommand(Sql, con))
                {
                    //适配器
                    MySqlDataAdapter ada = new MySqlDataAdapter(com);
                    //内存表
                    DataTable dt = new DataTable();
                    //适配器内容塞进内存表
                    ada.Fill(dt);
                    //装进容器
                    dataGridView1.DataSource = dt;
                }
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            Addbook adbook = new Addbook(conStr);
            adbook.Show();
        }
        //删除图书
        private void button3_Click(object sender, EventArgs e)
        {
            //先拿到这一行的索引
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            //再拿这一行数据的id
            int id = int.Parse(row.Cells["id"].Value.ToString());
            using (MySqlConnection con = new MySqlConnection(conStr))
            {
                con.Open();
                string Sql = "DELETE  FROM book WHERE id=@id";
                using (MySqlCommand com = new MySqlCommand(Sql, con))
                {
                    com.Parameters.AddWithValue("id", id);
                    int row1 = com.ExecuteNonQuery();
                    if (row1 > 0)
                    {
                        MessageBox.Show("删除成功");
                        selectData();
                    }
                    else MessageBox.Show("删除失败");
                }
            }
        }
    }
}
