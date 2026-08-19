namespace demo9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var getfil=(string str)=>
            //{
            //    var data =  DateTime.Now;

            //    var path = (@"./content.log");
            //    File.AppendAllText(path,$"{str}+{data}\n");
            //};
            //Console.WriteLine("输入内容+日期");
            //getfil(Console.ReadLine());

            //***********************************************
            Func<string, int> isFileOrDir = path =>
            {
                // 说明path是文件
                if (File.Exists(path)) return 1;
                // 说明path是目录
                if (Directory.Exists(path)) return 2;
                return 0;
            };
            Console.WriteLine(isFileOrDir("./"));


            Func<string, List<string>> getFileAndDir = path =>
            {
                List<string> resList = [];
                // 判断路径是否是 目录 ===> 使用刚刚书写的函数
                //  如果不是目录则 手动抛出一个异常
                if (isFileOrDir(path) != 2) throw new Exception("传递的参数有误,必须要是目录路径");
                // 获取目录下的所有文件
                string[] files = Directory.GetFiles(path);
                // 将得到 files数组添加到 list中
                resList.AddRange(files);

                // 获取所有的目录
                string[] dirs = Directory.GetDirectories(path);
                resList.AddRange(dirs);
                return resList;
            };

            //*******************************************************


        }
    }
}
