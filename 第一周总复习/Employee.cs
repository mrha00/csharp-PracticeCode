using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一周总复习
{
    public class Employee
    {
        // 字段 
        private string _name;       // 姓名
        private int _age;           // 年龄
        private double _salary;      // 薪水

        // 属性
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public double Salary { get => _salary; set => _salary = value; }

        // 显示方法
        public virtual void ShowInfo()
        {
            Console.WriteLine($"姓名：{Name}，年龄：{Age}，薪水：{Salary}");
        }
    }
}
