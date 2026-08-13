namespace demo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> fun = (n1, n2) =>
            {
                Console.WriteLine($"{n1+n2}");
            };
            fun(1, 2);
            void fun2()
            {
                Console.WriteLine("qwe");
                return;
            }

            
        }
    }
}
