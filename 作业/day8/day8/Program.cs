using System.Security.Cryptography;

namespace day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 用函数封装一个猜数字的小游戏，函数中生成一个随机整数（0-100）作为目标数字，不停的让用户输入数字，距离目标数字偏大，就提示用户偏大，距离目标数字偏小就输出偏小，用户有5次输入的机会，5次没有猜对，输出GAME OVER，猜对了就输出WIN！
            //void gussnumber(int n)
            //{
            //    var Random = new Random();
            //    int num = Random.Next(0, 100);
            //    for (int i=1;i<=5 ; i++)
            //    {
            //        if (n == num)
            //        {
            //            Console.WriteLine("WIN");
            //            break;
            //        }
            //        else if (n > num) Console.WriteLine("偏大");
            //        else if (n < num) Console.WriteLine("偏小");
            //        Console.WriteLine("请输入你猜的数字");
            //        n = int.Parse(Console.ReadLine());
            //        if (i == 5) Console.WriteLine("GAME OVER");
            //    }

            //}
            //Console.WriteLine("请输入数字：");
            //int n =int.Parse(Console.ReadLine());
            //gussnumber(n);


            //装修房间：参数1，圆的半径，计算圆的面积，每平方米收费200元，返回装修总价。计算这个半径的圆装修一半需要多少钱？
            Func<double, double> pricefunc = (double r) =>
            {
                double price = Math.PI * r * r * 200 / 2;
                return price;

            };
            Console.WriteLine("请输入半径");
            var r = int.Parse(Console.ReadLine());
            Console.WriteLine($"{pricefunc(r)}元");


            //计算字符在字符串中出现的次数：参数1字符串，参数2某个字符，函数统计次数，并返回。
            string str = "qwerysssssqqqqwwweee";
            Func<string, char, int> fun = (str, c) =>
            {
                int count = 0;
                foreach (char item in str)
                {
                    if (c == item)
                    {
                        count++;
                    }
                }
                return count;
            };
            Console.WriteLine("请输入字符");
            string str1 = Console.ReadLine();
            char c = str1[0];
            var num = fun(str, c);
            Console.WriteLine(num);

            //计算一个整型数组中，最小值第一次出现的下标。
            int[] arr = [10, 20, 5, 30, 50, 6, 7];
            Func<int[],int> getmin = (arr) => {
                int index = 0;
                for ( int i=0;i<arr.Length;i++)
                {
                    if (arr[i] < arr[index])
                    {
                        index = i;
                    }
                }
                return index;
            };

            Console.WriteLine(getmin(arr));


            //判断一个字符串是否为回文，返回布尔值类型。
            //Func<string, bool> func2 = (str) =>
            //{
            //    for (int i = 0; i <= str.Length - 1; i++)
            //    {
            //        if (str[i] != str[str.Length - 1 - i])
            //        {
            //            return false;
            //        }
            //    }
            //    return true;
            //};
            //Console.WriteLine("请输入字符串");
            //string str = Console.ReadLine();
            //Console.WriteLine(func2(str)); ;

        }
    }
}
