using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace day9
{
    internal class MySql
    {
        public string Server { get; set; } = "127.0.0.1";
        public string Port { get; set; } = "3306";
        public string Database { get; set; }
        public string Uid { get; set; } = "root";
        public string Password { get; set; } = "root";
        public string Charset { get; set; } = "utf8";

        //数据库字符串
        private string Constr { get; set; }
        public MySql(string data)
        {
            this.Database= data;
        }
        //封装链接数据库 并传入参数 sql指令和操作方法函数
        public async Task LinkSql(string sql,Action<MySqlCommand> handler)
        {
            Constr = $"server={Server};port={Port};database={Database};uid={Uid};password={Password};charset={Charset}";
            using (MySqlConnection con=new MySqlConnection(Constr))
            {
                await con.OpenAsync();
                //连接后创建命令对象 
                using (MySqlCommand cmd=new MySqlCommand(sql,con))
                {
                    handler(cmd);
                }
            }
        }
    }
}
