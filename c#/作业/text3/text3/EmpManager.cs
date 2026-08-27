using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace text3
{
    internal class EmpManager
    {
        public string Path { get; } = "./emp.json";
        public JsonSerializerOptions options { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            Encoder=System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        //新增员工
        public string AddEmp()
        {
            Console.WriteLine("请输入员工编号");
            int Id=int.Parse(Console.ReadLine());
            Console.WriteLine("请输入员工姓名");
            string Name=Console.ReadLine();
            Console.WriteLine("请输入员工部门");
            string Department=Console.ReadLine();
            Console.WriteLine("请输入员工薪资");
            double Salary=double.Parse(Console.ReadLine());
            //创建一个空list集合
            List<Employee> list = new();
            //如果存在读文件
            if (File.Exists(this.Path))
            {
                var json = File.ReadAllText(this.Path);
                list=JsonSerializer.Deserialize<List<Employee>>(json);
            }
            Employee em = new(Id,Name,Department,Salary);
            //判断是否有重复添加
            if (list.Exists(item => item.Empld == Id)) return "员工已存在，请勿重复添加";
            list.Add(em);
            //序列化,存文件
            var newjson = JsonSerializer.Serialize(list, this.options);
            File.WriteAllText(this.Path, newjson);
            return "新增员工成功";
        }
        //查看全部员工
        public void ShowEmpInfo()
        {
            //创建一个空list集合
            List<Employee> list = new();
            //如果不存在文件直接返回请先添加
            if (!File.Exists(this.Path)) 
            {
                Console.WriteLine("暂无员工数据");
                return;
            };
            var json = File.ReadAllText(this.Path);
            list = JsonSerializer.Deserialize<List<Employee>>(json);
            foreach (var item in list)
            {
                Console.WriteLine($"员工编号：{item.Empld}==员工姓名：{item.EmpName}==所属部门：{item.Department}==员工薪资：{item.Salary}");
            }
        }
        //调整薪资
        public string EditSalary()
        {
            List<Employee> list = new();
            Console.WriteLine("请输入员工编号");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入新薪资");
            double Salary = double.Parse(Console.ReadLine());
            if (!File.Exists(this.Path)) return "暂无员工信息，请先添加";
            //读文件 反序列化装载
            var json = File.ReadAllText(this.Path);
            list = JsonSerializer.Deserialize<List<Employee>>(json);
            var emp = list.Find(item => item.Empld == Id);
            //判断有没有这个id，如果没有返回
            if (emp == null) return "没有这个员工";
            emp.Salary=Salary;
            var newjson = JsonSerializer.Serialize(list, this.options);
            File.WriteAllText(this.Path, newjson);
            return "修改薪资成功";
        }
        //根据编号删除员工
        public string DeleteEmp()
        {
            List<Employee> list = new();
            Console.WriteLine("请输入删除员工编号");
            int Id=int.Parse(Console.ReadLine());
            if (!File.Exists(this.Path)) return "文件不存在，请先添加";
            //如果文件存在就正常读文件反序列化
            var json = File.ReadAllText(this.Path);
            list = JsonSerializer.Deserialize<List<Employee>>(json);
            if (!list.Exists(item => item.Empld == Id)) return "员工不存在，请重新输入";
            list.RemoveAll(item => item.Empld == Id);
            var newjson = JsonSerializer.Serialize(list, this.options);
            File.WriteAllText(this.Path, newjson);
            return "删除成功";
        }
        //按薪资条件筛选员工
        public void SelectEmp()
        {
            //创建一个空list集合
            List<Employee> list = new();
            Console.WriteLine("请输入薪资数值");
            double money=double.Parse(Console.ReadLine());
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("暂无员工数据，请先添加");
                return;
            }
            var json = File.ReadAllText(this.Path);
            list = JsonSerializer.Deserialize<List<Employee>>(json);
            list.ForEach(item =>
            {
                if (item.Salary>money)
                {
                    Console.WriteLine($"大于{money}收入的员工:{item.EmpName}");
                }
                else Console.WriteLine("没有大于此金额的员工"); 
            });
        }
    }
}
