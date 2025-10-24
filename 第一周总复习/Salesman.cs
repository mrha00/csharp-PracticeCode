using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一周总复习
{
    public class Salesman : Employee
    {
        public string salesVolume { get; set; }

        // 重写ShowInfo方法
        public override void ShowInfo()
        {
            Console.WriteLine($"姓名：{Name}，年龄：{Age}，薪水：{Salary}，销售额：{salesVolume}");
        }
    }
}
