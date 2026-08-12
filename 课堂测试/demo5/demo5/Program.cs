namespace demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //利用遍历对字符串去重
            //string str = "abcedgjjjsssabcd";
            //string restr = "";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    int j = 0;
            //    for (; j < restr.Length; j++)
            //    {
            //        if (str[i] == restr[j])
            //            break;
            //    }
            //    if (j == restr.Length) restr += str[i];
            //}
            //Console.WriteLine(restr);
            //*************************************
            //string oldstr = "you love i";
            //string[] strarr = oldstr.Split();//
            //string laststr = "";
            //List<string> list = strarr.ToList();
            //list.Reverse();
            //foreach(string item in list) {
            //    string str1 = item.Substring(0, 1).ToUpper();
            //    string str2 = item.Substring(1).ToLower();
            //    laststr += str1 + str2+ " ";

            //}
            //Console.WriteLine(laststr);

            //***************************************
            //string str = "abcdefg";
            //Console.WriteLine(str.Substring(1, 3));
            //bool res=str.Contains("bcd");
            //Console.WriteLine(res);
            //Console.WriteLine(str.StartsWith("a"));
            //Console.WriteLine(str.StartsWith("b"));
            //Console.WriteLine(str.EndsWith("a")); //fales
            //Console.WriteLine(str.EndsWith("g"));//true
            //Console.WriteLine(str.IndexOf("b",2));//第二个参数是开始寻找的起始位置
            //Console.WriteLine(str.LastIndexOf("e",5));
            //使用Contains 字符串去重
            //string str1 = "abcedgjjjsssabcd";
            //string restr = "";
            //for (int i = 0; i < str1.Length; i++)
            //{
            //    if (!restr.Contains(str1[i])) restr += str1[i];
            //}
            //Console.WriteLine(restr);
            //****************************************

            string str2 = "&&&&&&!!!******88!!!!!ABC   &&&&&&";
            char s = 'A';
            Console.WriteLine((int)s);
            Console.WriteLine(str2.Trim('&','*'));
            Console.WriteLine(str2.Replace("ABC","aa"));//前面参数做选择，后面参数做调整
            //假设list存储敏感词
            //string str3 = "马化腾，我爱你，违禁词";
            //List<string> list = ["马化腾","违禁词"];
            //foreach (var item in list)
            //{
            //    string newstr = "";
            //    for (int i = 0; i < item.Length; i++)
            //    {
            //        newstr += "*";
            //        str3 = str3.Replace(item, newstr);
            //    }
            //}
            //Console.WriteLine(str3);
            // 字符串.Split(指定分隔符)
            //string str = "西瓜_葡萄_芒果_榴莲";
            //string[] resArr = str.Split("_");
            //Console.WriteLine(resArr);
            //Console.WriteLine(str.Split("_"));//分割成为数组
            ////默认使用空格作为分隔符 可以使用一个或多个任意分隔符
            //string[] resArr1 = str.Split("_", 2);
            //foreach (var i1 in resArr1) Console.WriteLine(i1);
            string Str1 = "aa";
            string Str2 = "bb";
            string Str3 = "cc";
            string[] strArr = ["qq", "ww", "EE"];
            Console.WriteLine(string.Concat(Str1,Str2,Str3));
            Console.WriteLine(string.Join("_", strArr));

        }
    }
}
