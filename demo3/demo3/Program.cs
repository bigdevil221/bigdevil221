namespace demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //int num = 0;
            //while (i<=10)
            //{
            //    num = num + i;
            //    i++;
            //}
            //Console.WriteLine(num);
            //Console.WriteLine(i);
            //********************
            //int i = 1;
            //int num = 0;
            //while (i<=10) {
            //    if (i % 2 != 0)  {
            //        num = num + i;
            //    }

            //    i++;
            //}
            //Console.WriteLine(num);
            //*******************************
            //double money = 10;
            //double sum = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    money += 1.05 * i;
            //    sum = sum + 12 * money;

            //}
            //Console.WriteLine(money);
            //Console.WriteLine(sum);

            //*****************************
            //List<string> strList = new()
            //{
            //    "aa",
            //    "bb",
            //    "ccc",
            //    "dd",
            //    "eee"
            //};
            //for (int i=0 ; i < strList.Count; i++)
            //{
            //    Console.WriteLine(strList[i]);
            //}
            //****************************8
            //List<int> intList = new()
            //{
            //        3,
            //        5,
            //        7,
            //        2,
            //        9
            // };
            //int sum = 0;
            //for (int i = 0; i < intList.Count; i++)
            //{
            //    sum += intList[i];

            //}
            //Console.WriteLine(sum);
            //***********************************
            Console.WriteLine("请输入数字：");
            int k = int.Parse(Console.ReadLine());
            for (int i = 1;i<=k;i++)
            {
                if (i==1||i==k)
                {
                    continue;
                }
                if (k%i!=0)
                {
                    Console.WriteLine($"{k}是素数");
                }
            }
        }
    }
}
