using System.Text.Json;

namespace day9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, dynamic>> list = new() {
                new Dictionary<string, dynamic>(){
                    ["name"] = "zs",
                    ["age"] = 29,
                    ["isMan"] = true,
                    ["isSingle"] = true,
                    ["salary"] = 4200
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "ls",
                    ["age"] = 20,
                    ["isMan"] = false,
                    ["isSingle"] = true,
                    ["salary"] = 3400
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "ww",
                    ["age"] = 19,
                    ["isMan"] = true,
                    ["isSingle"] = false,
                    ["salary"] = 6000
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "zl",
                    ["age"] = 14,
                    ["isMan"] = false,
                    ["isSingle"] = true,
                    ["salary"] = 2000
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "sq",
                    ["age"] = 35,
                    ["isMan"] = true,
                    ["isSingle"] = false,
                    ["salary"] = 7000
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "zb",
                    ["age"] = 27,
                    ["isMan"] = false,
                    ["isSingle"] = true,
                    ["salary"] = 2900
                },
            };
            // FindALL: 要求查找年龄小于20的
            var res1 = list.FindAll(item =>
            {
                return item["age"] < 20; 
            });
            Console.WriteLine(JsonSerializer.Serialize(res1));//序列化
            //FindLast: 要求查找年龄大于25的
            var res2 = list.FindLast(item =>
            {
                return item["age"] > 25;
            });
            Console.WriteLine(JsonSerializer.Serialize(res2));

            // FindAll: 找出性别男的
            var res3 = list.FindAll(item => 
            {
                return item["isMan"] = true;
            });
            foreach (var item in res3)
            {
                Console.WriteLine($"男生姓名：{item["name"]}，");
            }

            // FindIndex: 找出薪水大于5000  找第一个满足条件的元素下标

            var res4 = list.FindIndex(item =>
            {
                return item["salary"] > 5000;
            });
            Console.WriteLine(JsonSerializer.Serialize(res4));
            // FindLastIndex: 找出薪水小于3000 找最后一个满足条件的下标
            var res5 = list.FindLastIndex(item =>
            {
                return item["salary"] < 3000;
            });
            Console.WriteLine(JsonSerializer.Serialize(res5));

            // Exists: 判断是否有薪水大于5000
            bool res6 = list.Exists(item => {
                return item["salary"] > 5000;
            });
            Console.WriteLine(res6);

            // ForEach: 输出每个的 名字-年龄-薪水
            //list.ForEach();

            // ConvertAll: 映射得到一个所以薪水的list
            List<Dictionary<string, dynamic>> newlist = list.ConvertAll(item => {
                return item;
            });
            var option = new JsonSerializerOptions
            {
                WriteIndented= true,
            };
            Console.WriteLine(JsonSerializer.Serialize(newlist, option));
            //TrueForAll: 判断是否都成年
            bool res8 = list.TrueForAll(item => {
                return item["age"] >= 18;
            });
            Console.WriteLine(res8);
            //str="dsajdhsabdhsadbsabd"
            //封装一个函数 接收一个字符串; 返回一个字典,键是字符串的每个字符,键值是这个字符在字符串中出现的次数
            var getdic = (string str) =>
            {
                Dictionary<char, int> dic = new Dictionary<char, int>();
                foreach (char item in str)
                {
                    if (dic.ContainsKey(item))
                    {
                        dic[item]++;
                    }
                    else
                    {
                        dic[item] = 1;
                    }
                }
                return dic;
            };
            Console.WriteLine("请输入一个字符串");
            Console.WriteLine(JsonSerializer.Serialize(getdic(Console.ReadLine())));
        }
    }
}
