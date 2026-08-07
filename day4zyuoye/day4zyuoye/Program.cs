namespace day4zyuoye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////计算100以内偶数的和
            //int sum = 0;
            //for (int i = 2; i <= 100; i = i + 2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //显示出1000-2000年中所有的闰年，并以每行四个数的形式输出
            //int i = 0;
            //for (int y = 1000; y < 2000; y++)
            //{
            //    if (y % 4 == 0 && y % 100 != 0||y%400==0)
            //    {
            //        Console.Write(y + " ");
            //        i++;
            //        if (i%4==0)
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}
            //输出一个倒三角形
            //for (int x = 9; x>0 ; x--)
            //{
            //    for(int y = x; y >0; y--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //用循环计算下面的结果:1 - 1/2 + 1/3 - 1/4 + ... - 1/100
            //double m = 0;
            //double sum = 0;
            //for (int n = 1; n <= 100; n++)
            //{
            //    m = 1.0 / n;
            //    if (n%2 == 0)
            //    {
            //        sum -= m;
            //    }
            //    else
            //    {
            //        sum += m;
            //    }
            //}
            //Console.WriteLine(sum);
            //求10以内所有数字的阶乘的和 
            //int totalsum = 0;
            //int factorial = 1;
            //for (int n = 0; n <= 10; n++)
            //{
            //    factorial = factorial*n;
            //    totalsum += factorial;
            //}
            //Console.WriteLine(totalsum);
            //篮球从5米高的地方掉下来，每次弹起的高度是原来的30%，经过几次弹起，篮球的高度小于0.1米。
            //double high = 5;
            //int i = 0;
            //for (; i < 100; i++)
            //{
            //    high = high * 0.3;
            //    if (high < 0.1)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(i);
            //有一个棋盘，有64个方格，在第一个方格里面放1粒芝麻重量是0.00001kg，第二个里面放2粒，第三个里面放4，棋盘上放的所有芝麻的重量
            //double weight = 1;
            //double sumweight = 0;
            //int geshu = 1;
            //for (int m = 1; m <= 64; m++) {
            //    sumweight += geshu * 0.00001;
            //    geshu *= 2;             
            //}
            //Console.WriteLine(sumweight);
            //猴子摘桃，猴子摘了x个桃，每天吃一半，再多吃一个，第7天吃的时候剩下一个了，猴子摘了多少桃子？
            double num = 1;
            for (int i = 6; i >=1; i--)
            {
                num = (num + 1) * 2;

            }
            Console.WriteLine(num);









        }
    }
}
