namespace day15
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            CarManager CM=new CarManager();
            UserManager UM=new UserManager();
            RentReturnClass RR=new RentReturnClass();
            string num="";
            while (num != "0")
            {
                Tips();
                num =Console.ReadLine();
                switch (num) {
                    case "1":
                        Console.WriteLine("==新增车辆==");
                        Console.WriteLine(CM.Addcar());
                        break;
                    case "2":
                        Console.WriteLine("==查看所有车辆信息==");
                        CM.SearchAll();
                        break;
                    case "3":
                        Console.WriteLine("==查看某辆车==");
                        CM.SearchOne();
                        break;
                    case "4":
                        Console.WriteLine("==查看所有空闲车辆==");
                        CM.SearchFree();
                        break;
                    case "5":
                        Console.WriteLine("==新增客户==");
                        Console.WriteLine(UM.Adduser());
                        break;
                    case "6":
                        Console.WriteLine("==查看所有客户==");
                        UM.SearchAll();
                        break;
                    case "7":
                        Console.WriteLine("==查看某个客户==");
                        Console.WriteLine("请输入客户Id");
                        int userid = int.Parse(Console.ReadLine());
                        UM.SearchOne(userid);
                        break;
                    case "8":
                        Console.WriteLine("==租车==");
                        Console.WriteLine(RR.Rentcar());
                        break;
                    case "9":
                        Console.WriteLine("==还车==");
                        RR.ReturnCar();
                        break;
                    default:
                        Console.WriteLine("退出系统");
                        break;
                }
            }
            static void Tips()
            {
                Console.WriteLine("==欢迎来到租车系统==");
                Console.WriteLine("请选择操作编号：");
                Console.WriteLine("0：退出系统");
                Console.WriteLine("1：新增车辆");
                Console.WriteLine("2：查看所有车辆信息");
                Console.WriteLine("3：查看某辆车");
                Console.WriteLine("4：查看所有空闲车辆");
                Console.WriteLine("5：新增客户");
                Console.WriteLine("6：查看所有客户");
                Console.WriteLine("7：查看某个客户");
                Console.WriteLine("8：租车");
                Console.WriteLine("9：换车");
                Console.WriteLine("10：查看所有租车记录");
            } 
        }
    }
}
