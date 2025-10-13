using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口与抽象类4_6
{
    // 使用abstract修饰为抽象类
    public abstract class Vehicle : IMovable
    {
        // 公有字段
        public string Brand { get; set; }   // 品牌
        public string Model { get; set; }   // 型号

        // 构造函数
        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        // 实现 IMovable接口的Move方法和Stop
        public virtual void Move()
        {
            Console.WriteLine($"{Brand}--{Model}正在移动");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"{Brand}-{Model}已停止");
        }
    }
}
