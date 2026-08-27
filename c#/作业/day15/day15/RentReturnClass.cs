using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace day15
{
    internal class RentReturnClass
    {
        private string Path { get; } = "./rentreturn.json";
        private JsonSerializerOptions option { get; }
        = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas=true,
            Encoder=System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        //新增租车记录
        public string Rentcar()
        {
            Console.WriteLine("请输入车辆ID");
            int carid = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入客户ID");
            int userid = int.Parse(Console.ReadLine());
            //先检查客户是否存在 再检查车辆是否存在 车辆直接改，如果改完等于空那么返回不存在
            UserManager UM=new UserManager();
            CarManager CM=new CarManager();
            if (!UM.SearchOneById(userid)) return "客户不存在";
            var (str, isupdated) = CM.UpdateStatus(carid);
            if (!isupdated) return str;
            //判断完开始存储信息
            List<RentReturn> list = new();
            if (File.Exists(this.Path))
            {
                string json = File.ReadAllText(this.Path);
                list = JsonSerializer.Deserialize<List<RentReturn>>(json);
            }
            int id = list.Count == 0 ? 1 : list[list.Count - 1].Id+1;
            string rentime = DateTime.Now.ToString();
            RentReturn RR = new RentReturn(id, carid, userid, rentime, "", 0);
            list.Add(RR);
            string newjson = JsonSerializer.Serialize(list, this.option);
            File.WriteAllText(this.Path, newjson);
            return "租借成功";
        }
        //还车记录
        public void ReturnCar()
        {
            Console.WriteLine("请输入租车记录ID: ");
            int id = int.Parse(Console.ReadLine());
            // 判断文件是否存在---> 不存在 ----提示
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("没有租车信息！！！");
                return;
            }
            // 文件存在---->读取文件 -----> 反序列话====》 租车记录列表
            string jsonStr = File.ReadAllText(this.Path);
            List<RentReturn> rrList = JsonSerializer.Deserialize<List<RentReturn>>(jsonStr);
            // 根据id 在租车记录列表中查找记录对象
            RentReturn rrObj = rrList.Find(item => item.Id == id);
            // 找不到 ----> 提示
            if (rrObj == null)
            {
                Console.WriteLine("租车记录ID有误！！！");
                return;
            }
            // 如果 该租车记录 已经是 还车的 则 提示
            if (rrObj.ReturnTime != "")
            {
                Console.WriteLine("该车辆已还！！！");
                return;
            }

            // 找到了租车记录 则根据 车辆id 去获取 时租费， 并修改车辆的状态（改为空闲）
            //  在车辆管理类中添加方法实现 
            CarManager CM = new CarManager();
            double price = CM.UpAndGetInfo(rrObj.CarId);
            // 计算支付金额  归还时间（当前时间） - 租赁时间  结果转为小时数
            //   得到的小时数 * 车辆的时租费
            TimeSpan diff = DateTime.Now - DateTime.Parse(rrObj.RentTime);
            double payMoney = (double)diff.TotalHours * price;
            // 修改租车记录对象 -----》 将租车列表序列化 ---->写回文件
            rrObj.Paymoney = payMoney;
            rrObj.ReturnTime = DateTime.Now.ToString();

            string jsonrrStr = JsonSerializer.Serialize(rrList, this.option);
            File.WriteAllText(this.Path, jsonrrStr);
            Console.WriteLine("***还车成功***");
        }
        // 查看所有租车记录 方法
        public void SearchAll()
        {
            // 判断文件是否存在---> 不存在 ----提示
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("没有租车信息！！！");
                return;
            }
            // 文件存在---->读取文件 -----> 反序列话====》 租车记录列表
            string jsonStr = File.ReadAllText(this.Path);
            List<RentReturn> rrList = JsonSerializer.Deserialize<List<RentReturn>>(jsonStr);
            if (rrList.Count == 0)
            {
                Console.WriteLine("没有租车信息！！！");
                return;
            }
            // 遍历输出
            rrList.ForEach(item =>
            {
                Console.WriteLine($"租车记录ID: {item.Id} -- 车辆ID: {item.CarId} -- 客户ID: {item.UserId} -- 租赁时间: {item.RentTime} -- 还车时间: {item.ReturnTime} -- 费用: {item.Paymoney}");
            });

        }

    }
}
