using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 第一周总复习
{
    public class Manager : Employee
    {
        // 字段
        private string department;      // 部门

        // 属性
        public string Department { get => department; set => department = value; }

        // 重写ShowInfo方法
        public override void ShowInfo()
        {
            Console.WriteLine($"姓名：{Name}，年龄：{Age}，薪水：{Salary}，部门：{Department}");
        }
    }
}
