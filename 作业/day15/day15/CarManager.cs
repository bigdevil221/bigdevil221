using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;

namespace day15
{
    //车辆管理类
    internal class CarManager
    {
        //直接赋初始值 之后之后实例化不用传参
        private string path { get; } = "./car.json";
        private JsonSerializerOptions option { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            //序列化时中文不变
            Encoder=System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        //所有车辆管理类方法
        //添加车辆
        public string Addcar()
        {
            Console.WriteLine("请输入车牌号:");
            string card=Console.ReadLine();
            Console.WriteLine("请输入车辆类型:");
            string type = Console.ReadLine();
            Console.WriteLine("请输入每小时的费用:");
            double price = double.Parse( Console.ReadLine());
            List<Car> cars = new();
            if (File.Exists(this.path))
            {
                string jsonstr = File.ReadAllText(this.path);
                cars=JsonSerializer.Deserialize<List<Car>>(jsonstr);
                //如果存在则需要判断输入的车牌号是否已经存在
                if (cars.Exists(item => item.Card == card)) return "车牌已存在，请重新输入";
            }
            //实例化一个car 然后把它添加到list中
            Car caropj = new Car(cars.Count + 1, card, type, true, price);
            cars.Add(caropj);
            //序列化
            string newjsonstr = JsonSerializer.Serialize(cars, this.option);
            File.WriteAllText(this.path, newjsonstr);
            Console.WriteLine("111111111111111");
            return "新增车辆成功";
        }
        //查询所有车辆
        public void SearchAll()
        {
            if (!File.Exists(this.path))
            {
                Console.WriteLine("没有车辆信息，请先添加");
                return;
            }
            string json = File.ReadAllText(this.path);
            List<Car> cars = JsonSerializer.Deserialize<List<Car>>(json);
            foreach (var item in cars)
            {
                string status = item.Status ? "空闲" : "已出租";
                Console.WriteLine($"id:{item.Id}==车牌:{item.Card}==类型:{item.Type}==状态:{status}==时租费:{item.Price}");
            }

        }
        //查看某辆车
        public void SearchOne()
        {
            Console.WriteLine("请输入车辆Id");
            int carId=int.Parse(Console.ReadLine());
            if (!File.Exists(this.path))
            {
                Console.WriteLine("没有车辆信息，请先添加");
                return;
            }
            string json=File.ReadAllText(this.path);
            List<Car> cars = JsonSerializer.Deserialize<List<Car>>(json);
            Car car = cars.Find(item => item.Id == carId);
            if (car == null)
            {
                Console.WriteLine("没有车辆信息，请先添加");
                return;
            }
            string status = car.Status ? "空闲" : "已出租";
            Console.WriteLine($"id:{car.Id}==车牌:{car.Card}==类型:{car.Type}==状态:{status}==时租费:{car.Price}");
        }
        //查看所有空闲车辆
        public void SearchFree()
        {
            if (!File.Exists(this.path))
            {
                Console.WriteLine("没有车辆信息，请先添加");
                return;
            }
            var json = File.ReadAllText(this.path);
            List<Car> cars=JsonSerializer.Deserialize<List<Car>>(json);
            List<Car> freecars= cars.FindAll(item => item.Status == true);
            //先判断一下有没有，如果有再遍历输出
            if (freecars==null)
            {
                Console.WriteLine("全部已租赁");
                return;
            }
            foreach (Car item in freecars) {
                string status = item.Status ? "空闲" : "已租赁";
                Console.WriteLine($"id:{item.Id}==车牌:{item.Card}==类型:{item.Type}==状态:{status}==时租费:{item.Price}");
            }
        }
        //根据id修改车辆方法
        public (string, bool) UpdateStatus(int id)
        {
            if (!File.Exists(this.path)) return ("暂无车辆", false);
            string json = File.ReadAllText(this.path);
            List<Car> cars=JsonSerializer.Deserialize<List<Car>>(json);
            Car car = cars.Find(item => item.Id == id);
            if (car==null) return("暂无对应id车辆", false);
            if (!car.Status) return ("该车辆已被租出！！！", false);
            car.Status = false;
            string newjson = JsonSerializer.Serialize(cars, this.option);
            File.WriteAllText(this.path, newjson);
            return ("租车成功！！！", true);
        }
        // 修改状态并获取 时租费
        public double UpAndGetInfo(int id)
        {
            // 读文件---》 反序列化 ---》车辆列表 ---》根据id查找---》修改状态 并获取数据返回
            string jsonStr = File.ReadAllText(this.path);
            List<Car> cars = JsonSerializer.Deserialize<List<Car>>(jsonStr);

            Car car = cars.Find(item => item.Id == id);

            // 修改车辆状态
            car.Status = true;
            // 将修改后的 cars列表 序列化 写回文件
            string resStr = JsonSerializer.Serialize(cars, this.option);
            File.WriteAllText(this.path, resStr);
            return car.Price;
        }
    }
}
