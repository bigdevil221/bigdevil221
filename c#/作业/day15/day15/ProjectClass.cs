using System;
using System.Collections.Generic;
using System.Text;

namespace day15
{
    //数据类
    //车辆数据类
    internal class Car
    {
        public int Id { get; }
        public string Card { get; } //车牌
        public string Type { get; set; } //车辆类型
        public bool Status { get; set; } //租借状态
        public double Price { get; set; }
        public Car(int Id,string Card, string Type, bool Status, double Price)
        {
            this.Id = Id;
            this.Card = Card;
            this.Type = Type;
            this.Status = Status;
            this.Price = Price;
        }
    }
    //用户信息类
    internal class User
    {
        public int Id { get;}
        public string Name { get; set; }
        public string IdCard { get;  }
        //注册时间
        public string RegTime { get; }
        //性别
        public string Gender { get; set; }
        public string PhoneNo { get; set; }
        //座右铭
        public string Motto { get; set; }

        public User(int Id, string Name, string IdCard, string RegTime, string Gender, string PhoneNo, string Motto)
        {
            this.Id= Id;
            this.Name = Name;
            this.IdCard = IdCard;
            this.RegTime = RegTime;
            this.Gender = Gender;
            this.PhoneNo = PhoneNo;
            this.Motto= Motto;
        }

    }
    //租还车信息类
    internal class RentReturn
    {
        public int Id { get;set;  }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public string RentTime { get; set; }
        public string ReturnTime { get; set; }
        public double Paymoney { get; set; }

        public RentReturn(int Id, int CarId, int UserId, string RentTime, string ReturnTime, double Paymoney)
        {
            this.Id = Id;
            this.CarId = CarId;
            this.UserId = UserId;
            this.RentTime = RentTime;
            this.ReturnTime = ReturnTime;
            this.Paymoney = Paymoney;
        }

    }
}
