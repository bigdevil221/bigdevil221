using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace day15
{
    internal class UserManager
    {
        private string Path { get; } = "./user.json";
        private JsonSerializerOptions options { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        //新增客户
        public string Adduser()
        {
            Console.WriteLine("请输入客户姓名");
            string username=Console.ReadLine();
            Console.WriteLine("请输入身份证号");
            string idcard = Console.ReadLine();
            Console.WriteLine("请输入性别");
            string gender = Console.ReadLine();
            Console.WriteLine("请输入手机号");
            string phoneno = Console.ReadLine();
            Console.WriteLine("请输入座右铭");
            string motto = Console.ReadLine();
            if (!Regex.IsMatch(phoneno,@"1\d{10}$"))
            {
                return "输入手机号有误";
            }
            List<User> list=new List<User>();
            if (File.Exists(this.Path))
            {
                string json=File.ReadAllText(this.Path);
                list=JsonSerializer.Deserialize<List<User>>(json);
            }
            //判断一下有没有重复添加客户
            if (list.Exists(item=>item.IdCard== idcard))
            {
                return"客户已存在，请勿重复添加";
            }
            //id如果列表里没有用户数据则走false
            int id = list.Count == 0 ? 1 : list[list.Count - 1].Id + 1;
            //获取当前注册时间
            string regtime = DateTime.Now.ToString();
            User user = new User(id,username, idcard,regtime,gender,phoneno,motto);
            list.Add(user);
            //序列化存入文件
            var newjson = JsonSerializer.Serialize(list, this.options);
            File.WriteAllText(this.Path,newjson);
            return "新增客户成功";
        }
        //查看所有客户
        public void SearchAll()
        {
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("没有用户信息，请先添加");
                return;
            }
            string json = File.ReadAllText(this.Path);
            List<User> list=JsonSerializer.Deserialize<List<User>>(json);
            Console.WriteLine("===========================");
            foreach (var item in list)
            {
                Console.WriteLine($"ID: {item.Id} -- 姓名: {item.Name} -- 身份证: {item.IdCard} -- 性别: {item.Gender} -- 手机号: {item.PhoneNo} -- 座右铭: {item.Motto} ");
            }
            Console.WriteLine("===========================");
        }
        //查看某个客户
        public void SearchOne(int userid)
        {
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("暂无客户信息，请先添加");
                return ;
            }
            string json= File.ReadAllText(this.Path);
            List<User> list = JsonSerializer.Deserialize<List<User>>(json);
            //判断用户是否存在
            User user = list.Find(item => item.Id == userid);
            if (user==null)
            {
                Console.WriteLine("没有此用户");
                return ;
            }
            // 找到了展示
            Console.WriteLine("=================================");
            // 遍历输出
            Console.WriteLine($"ID: {user.Id} -- 姓名: {user.Name} -- 身份证: {user.IdCard} -- 性别: {user.Gender} -- 手机号: {user.PhoneNo} -- 座右铭: {user.Motto} ");
            Console.WriteLine("=================================");
            return ;
        }
        // 根据id查找用户是否存在
        public bool SearchOneById(int id)
        {
            // 判断存储数据的文件是否存在
            // 文件不存在---提示
            if (!File.Exists(this.Path)) return false;

            // 文件存在===>读文件 ---> 反序列化 List<User>  list            
            string jsonStr = File.ReadAllText(this.Path);
            List<User> list = JsonSerializer.Deserialize<List<User>>(jsonStr);
            // 根据ID查找客户对象===》找不到 ----->提示
            User userObj = list.Find(item => item.Id == id);
            if (userObj == null) return false;
            return true;
        }


    }
}
