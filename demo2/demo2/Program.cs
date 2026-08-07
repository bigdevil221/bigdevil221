namespace demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入小红资产：");
            int money = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入小红颜值：");
            double yz = double.Parse(Console.ReadLine());
            bool jiegiuo = money > 3000000 && yz > 9.5;
            if (jiegiuo)
            {
                Console.WriteLine("符合小明择偶标准");
            }
            else
            {
                Console.WriteLine("不符合小明择偶标准");
            }
            //;
            ////*************************************************
            Console.WriteLine("请输入成绩：");
            int cj = int.Parse(Console.ReadLine());
            if (cj > 60 && cj < 80)
            {
                Console.WriteLine("及格");
            }
            else if (cj > 80 && cj < 90)
            {
                Console.WriteLine("良好");
            }
            else if ((cj > 90 && cj <= 100))
            {
                Console.WriteLine("优秀");
            }
            else
            {
                Console.WriteLine("不及格");
            }
            //******************************************
            Console.WriteLine("请输入1-7：");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("今天星期一");
                    break;
                case 2:
                    Console.WriteLine("今天星期二");
                    break;
                case 3:
                    Console.WriteLine("今天星期三");
                    break;
                case 4:
                    Console.WriteLine("今天星期四");
                    break;
                case 5:
                    Console.WriteLine("今天星期五");
                    break;
                case 6://穿透
                case 7:
                    Console.WriteLine("今天是周末");
                    break;

                default:
                    Console.WriteLine("请重新输入");
                    break;

            }
            //************************************************
            Console.WriteLine("请输入分数：");
            int score = int.Parse(Console.ReadLine());
            if (score > 0 && score < 100)
            {
                string r = score switch
                {
                    >= 90 => "A",
                    >= 80 => "B",
                    >= 70 => "C",
                    >= 60 => "D",
                    _ => "F"

                };
                Console.WriteLine("res");
            }
            else
            {
                Console.WriteLine("请重新输入分数");
            }
            //************************************
            Console.WriteLine("请输入年龄：");
            int old = int.Parse(Console.ReadLine());
            string res = old > 18 ? "成年了" : "未成年";
            Console.WriteLine(res);
            //*************************************
            Console.WriteLine("请输入年份：");
            int year =int.Parse(Console.ReadLine());
            string result = year / 4 == 0 && year / 100 != 0 || year / 400 == 0 ? "闰年" : "平年";
            Console.WriteLine(result);

            //*************************************
            Console.WriteLine("请输入数字;");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine($"数字{x}是{(x%2==0?"偶数":"奇数")}");

            //*************************************
            int n = 1;
            Console.WriteLine(n == 1 ? "在线" : "离线");

            //*************************************
            Console.WriteLine("请输入文件大小：");
            int m=int.Parse(Console.ReadLine());
            Console.WriteLine($"文件大小是{(m>1024?m%1024+"kb":m+"kb")}");

            //**************************************
            Console.WriteLine("请输入第一个数字：");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("请选择运算符(+ - * /)：");
            string re = Console.ReadLine();
            switch (re)
            {
                case "+":
                    Console.WriteLine($"n1+n2={n1 + n2}");
                    break;
                case "-":
                    Console.WriteLine($"n1+n2={n1 - n2}");
                    break;
                case "*":
                    Console.WriteLine($"n1+n2={n1 * n2}");
                    break;
                case "%":
                    Console.WriteLine($"n1+n2={n1 % n2}");
                    break;
            }
            //*****************************8
            Console.WriteLine("请输入你的血型：");
            string blood = Console.ReadLine();
            switch (blood)
            {
                case "A":
                    Console.WriteLine("细心稳重");
                    break;

                case "B":
                    Console.WriteLine("乐观自由");
                    break;
                case "AB":
                    Console.WriteLine("思维多变");
                    break;
                case "O":
                    Console.WriteLine("热情外向");
                    break;
                default:
                    Console.WriteLine("无此类型");
                    break;

            }





        }
    }
}
