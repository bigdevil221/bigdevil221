namespace text3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpManager EM=new EmpManager();
            string index = "";
            while (index!="0") {
                showinfo();
                index=Console.ReadLine();
                switch (index)
                {
                    case "1":
                        Console.WriteLine("==新增员工==");
                        Console.WriteLine(EM.AddEmp());
                        Console.WriteLine("---------------------");
                        break;
                    case "2":
                        Console.WriteLine("==查看全部员工==");
                        EM.ShowEmpInfo();
                        Console.WriteLine("---------------------");
                        break;
                    case "3":
                        Console.WriteLine("==调整薪资==");
                        Console.WriteLine(EM.EditSalary());
                        Console.WriteLine("---------------------");
                        break;
                    case "4":
                        Console.WriteLine("==删除员工==");
                        Console.WriteLine(EM.DeleteEmp());
                        Console.WriteLine("---------------------");
                        break;
                    case "5":
                        Console.WriteLine("按薪资条件筛选员工");
                        EM.SelectEmp();
                        Console.WriteLine("---------------------");
                        break;
                    case "0":
                        Console.WriteLine("退出成功");
                        break;
                    default:
                        Console.WriteLine("输入有误，请重新输入");
                        break;
                }
            
            }
            void showinfo(){
                Console.WriteLine("===欢迎来到员工薪资管理系统===");
                Console.WriteLine("输入1：新增员工");
                Console.WriteLine("输入2：查看全部员工");
                Console.WriteLine("输入3：调整薪资");
                Console.WriteLine("输入4：删除员工");
                Console.WriteLine("输入5：按薪资条件筛选员工");
                Console.WriteLine("输入0：退出系统");
            }


        }
    }
}
