using System.Text.Json;

namespace day12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManager bookmanager = new BookManager("./book.json", new JsonSerializerOptions
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
            });
            string num = "";
            while (num != "0")
            {
                Console.WriteLine("===欢迎来到图书馆===");
                Console.WriteLine("1：新增图书");
                Console.WriteLine("2：删除图书");
                Console.WriteLine("3：编辑图书");
                Console.WriteLine("4：查询所有图书");
                Console.WriteLine("5：查询单个图书");
                Console.WriteLine("6: 借阅图书");
                Console.WriteLine("7: 还书");
                Console.WriteLine("0：退出");
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        Console.WriteLine("==新增图书==");
                        Console.WriteLine("请输入书名");
                        string bookname1 = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        string aunthor = Console.ReadLine();
                        Console.WriteLine("请输入标签");
                        string mark = Console.ReadLine();
                        Console.WriteLine("请输入价格");
                        double price = double.Parse(Console.ReadLine());
                        Dictionary<string, dynamic> newlist = new Dictionary<string, dynamic>()
                        {
                            ["name"] = bookname1,
                            ["author"] = aunthor,
                            ["isBorrow"] = false,
                            ["id"] = new Random().NextDouble(),
                            ["mark"] = mark,
                            ["price"] = price
                        };
                        Console.WriteLine(bookmanager.AddBook(newlist));
                        break;
                    case "2":
                        Console.WriteLine("==删除图书==");
                        Console.WriteLine("输入书名");
                        string bookname2 = Console.ReadLine();
                        Console.WriteLine(bookmanager.DeleteBook(bookname2));
                        break;
                    case "3":
                        Console.WriteLine("==编辑图书==");
                        Console.WriteLine("输入想更改的书名");
                        string oldname = Console.ReadLine();
                        Console.WriteLine("==新增图书==");
                        Console.WriteLine("请更改书名");
                        string bookname5 = Console.ReadLine();
                        Console.WriteLine("请更改作者");
                        string aunthor2 = Console.ReadLine();
                        Console.WriteLine("请更改标签");
                        string mark2 = Console.ReadLine();
                        Console.WriteLine("请更改价格");
                        double price2 = double.Parse(Console.ReadLine());
                        Dictionary<string, dynamic> newbook = new Dictionary<string, dynamic>()
                        {
                            ["name"] = bookname5,
                            ["author"] = aunthor2,
                            ["mark"] = mark2,
                            ["price"] = price2
                        };
                        Console.WriteLine(bookmanager.EditBook(oldname, newbook));
                        break;
                    case "4":
                        Console.WriteLine("==查询所有图书==");
                        var reslist = bookmanager.SearchBook();
                        if (reslist.Count == 0)
                        {
                            Console.WriteLine("没有书籍，请先添加");
                        }
                        else
                        {
                            foreach (var item in reslist)
                            {
                                Console.WriteLine($"书名{item["name"]}==作者{item["author"]}==价格{item["price"]}==标签{item["mark"]}");
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("5：查询单个图书");
                        string bookname4 = Console.ReadLine();
                        var singlebook = bookmanager.SearchBook(bookname4);
                        if (singlebook.Count == 0) Console.WriteLine("没有图书，请先添加");
                        else Console.WriteLine($"名字：{singlebook["name"]}==作者：{singlebook["author"]}==标签：{singlebook["mark"]}==价格：{singlebook["price"]}");
                        break;
                    case "6":
                        Console.WriteLine("==借阅图书==");
                        var alllist = bookmanager.SearchBook();
                        if (alllist.Count == 0)  Console.WriteLine("没有书籍，请先添加");
                        foreach (var item in alllist)
                        {
                            if (!item["isBorrow"].GetBoolean())
                            {
                                Console.WriteLine("目前未借阅图书：");
                                Console.WriteLine($"书名=={item["name"]}作者=={item["author"]}标签=={item["mark"]}价格=={item["price"]}");
                            }
                        }
                        Console.WriteLine("请输入借阅图书名称");
                        string borrowname = Console.ReadLine();
                        Console.WriteLine(bookmanager.Borrow(borrowname));
                        break;
                    case "7":
                        Console.WriteLine("==还书==");
                        Console.WriteLine("请输入还书的名字");
                        string returnname= Console.ReadLine();
                        Console.WriteLine(bookmanager.ReturnBook(returnname));
                        break;
                    default:
                        Console.WriteLine("请输入正确指令");
                        break;
                }
            }
        }
    }
}
