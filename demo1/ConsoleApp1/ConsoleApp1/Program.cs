namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arr1 = new List<string>() {"A","B","C","D"};
            arr1.Add("Z");
            arr1.Insert(2,"X");
            arr1.AddRange("Q","W","E");
            Console.WriteLine(arr1[0]);

            List<string> name = new List<string> {"a","b"};
            Random r = new Random ();
            int nameid = r.Next(name.Count);

            Console.WriteLine(name[nameid]);
            Console.WriteLine(name.Count);
        }
    }
}
