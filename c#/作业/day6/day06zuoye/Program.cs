using System.Text.RegularExpressions;

namespace day06zuoye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //提取一句话中所有的中文姓名
            string str1 = "hello, I am 刘德华,your name is 黎明?";
            var reg1 = @"[\u4e00-\u9fa5]{2,3}";
            MatchCollection res=Regex.Matches(str1, reg1);
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
            //替换所有多余空格
            string str2 = "abc  dd  ee  ff  gg  HH  h j k";
            string resstr = "";
            Console.WriteLine(str2.Replace(" ","-"));
            //身份证号码
            string str3 = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
            // 书写正则, 找到字符串中的身份证号及 出生年,月,日
            var reg2 = @"[1-9]\d{5}(\d{4})(\d{2})(\d{2})\d{3}[0-9Xx]";
            var res3 = Regex.Matches(str3, reg2);
            foreach (Match item in res3)
            {
                Console.WriteLine(item.Groups[0]+"--"+item.Groups[1] + "--" + item.Groups[2] + "--" + item.Groups[3]);
            }

            //密码强度检测：强中弱（字母、数字、特殊符号）
            // 请输入密码（字母、数字、特殊符号）
            //密码中可以有数字,字母,特殊符号;长度要求8~15 
            //如果只有一种则 强度为弱
            //如果只有两种则 强度为中
            //如果两种都有则 强度为强
            //验证密码长度是否符合,并输出密码强度
            //Console.WriteLine("输入密码：");
            //string password = Console.ReadLine();
            //if (password.Length>=8&&password.Length<=15)
            //{
            //    bool strength1 = Regex.IsMatch(password, @"[a-zA-Z]");
            //    bool strength2 = Regex.IsMatch(password, @"\d");
            //    bool strength3 = Regex.IsMatch(password, @"[^A-Za-z0-9]");
            //    int type = (strength1 ? 1 : 0) + (strength2 ? 1 : 0) + (strength3 ? 1 : 0);
            //    string strength = type switch
            //    {
            //        1 => "弱",
            //        2 => "中",
            //        3 => "强"
            //    };
            //    Console.WriteLine($"密码强度:{strength}");
            //}
            //else Console.WriteLine("密码长度不符合要求");

        }
    }
}
