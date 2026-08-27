using System;
using System.Collections.Generic;
using System.Text;

namespace text3
{
    internal class Employee
    {
        //员工编号
        public int Empld {  get; set; }
        //员工姓名
        public string EmpName { get; set; }
        //所属部门
        public string Department { get; set; }
        //员工薪资
        public double Salary { get; set; }

        //初始化构造函数
        public Employee(int Empld, string EmpName, string Department, double Salary)
        {
            this.Empld = Empld;
            this.EmpName = EmpName;
            this.Department = Department;
            this.Salary = Salary;
        }
    }
}
