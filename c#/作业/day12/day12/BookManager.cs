using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace day12
{
    internal class BookManager
    {
        public string path { get; }
        public JsonSerializerOptions options { get; }
        // 增
        public string AddBook(Dictionary<string,dynamic>booklist)
        {
            List <Dictionary<string, dynamic>>oldlist = new();
            if (File.Exists(path))
            {
                var json=File.ReadAllText(path);
                oldlist=JsonSerializer.Deserialize<List<Dictionary<string,dynamic>>>(json);
            }
            //判断是否添加相同名字书籍
            foreach (var item in oldlist)
            {
                if (item["name"].ToString() == booklist["name"]) return "已存在相同名字书籍";
            }
            oldlist.Add(booklist);
            string newjson = JsonSerializer.Serialize(oldlist, options);
            File.WriteAllText(path, newjson);      
            return "添加成功";
        }
        //删
        public string DeleteBook(string bookname)
        {
            List<Dictionary<string, dynamic>> oldlist = new();
            if (File.Exists(this.path))
            {
                var json = File.ReadAllText(path);
                oldlist = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            }
            else return "请先添加";
            int index = oldlist.FindIndex(item => item["name"].ToString() == bookname);
            //根据索引判断并删除
            if (index == -1) return "没有要删除的书籍";
            oldlist.RemoveAt(index);
            //List<Dictionary<string,dynamic>>newlist= oldlist.FindAll(item => item["name"].ToString()!=bookname );
            string jsonstr = JsonSerializer.Serialize(oldlist, options);
            File.WriteAllText(path, jsonstr);
            return "删除成功";
        }
        //改
        public string EditBook(string bookname,Dictionary<string,dynamic> newbook)
        {
            if (!File.Exists(path)) return "请先添加";
            var json = File.ReadAllText(path);
            List<Dictionary<string, dynamic>>oldlist = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            foreach (var item in oldlist)
            {
                if (item["name"].ToString() == bookname)
                {
                    item["name"] = newbook["name"];
                    item["author"] = newbook["author"];
                    item["price"] = newbook["price"];
                    item["mark"] = newbook["mark"];
                }
                //这里如果执行第一次循环没有找到符合名字图书会直接return导致程序结束不会执行下一步操作
                //else return "找不到书籍";
            }
            string newjson = JsonSerializer.Serialize(oldlist, options);
            File.WriteAllText(path, newjson);
            return "修改成功";
        }
        //查询所有数据
        public List<Dictionary<string, dynamic>> SearchBook()
        {
            List<Dictionary<string, dynamic>> list = new();
            if (!File.Exists(path)) return list;
            var jsonstr=File.ReadAllText(path);
            list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(jsonstr);
            return list;
        }
        //查单个数据
        public Dictionary<string,dynamic> SearchBook(string bookname)
        {
            Dictionary<string,dynamic> list=new();
            if (!File.Exists(path)) return list;
            var json = File.ReadAllText(path);
            List<Dictionary<string,dynamic>> oldlist =JsonSerializer.Deserialize<List<Dictionary<string,dynamic>>>(json);
            Dictionary<string, dynamic> resdic = oldlist.Find(item => item["name"].ToString() == bookname);
            if (resdic == null)  return list;
            return resdic;
        }
        //借阅功能
        public string Borrow(string borrowname)
        {
            List<Dictionary<string, dynamic>> list = new();
            if (!File.Exists(path)) return "没有图书，请先添加";
            var json= File.ReadAllText(path);
            list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            bool index = list.Exists(item => item["name"].ToString() == borrowname);
            if (!index == true) return "没有此图书，请重新选择";
            foreach (var item in list)
            {
                if (item["name"].ToString() == borrowname)
                {
                    item["isBorrow"] = true;
                }
            }
            var newjson = JsonSerializer.Serialize(list, options);
            File.WriteAllText(path, newjson);
            return "借阅成功";
        }
        //还书功能
        public string ReturnBook(string returnname)
        {
            List<Dictionary<string, dynamic>> list = new();
            if (!File.Exists(path)) return "没有图书，请先添加";
            var json = File.ReadAllText(path);
            list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            bool index = list.Exists(item => item["name"].ToString() == returnname);
            if (!index == true) return "没有借阅图书，请重新选择";
            foreach (var item in list)
            {
                if (item["name"].ToString() == returnname)
                {
                    item["isBorrow"] = false;
                }
            }
            var newjson = JsonSerializer.Serialize(list, options);
            File.WriteAllText(path, newjson);
            return "还书成功";
        }
        public BookManager(string bookpath,JsonSerializerOptions jsonopt) {
            path = bookpath;
            options = jsonopt;
        }
        
    }
}
