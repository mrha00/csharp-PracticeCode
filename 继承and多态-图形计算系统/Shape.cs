using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承and多态_图形计算系统
{
    public abstract class Shape
    {
        // 创建抽象属性
        public abstract double Area { get; }    // 计算图形面积

        public abstract double Perimeter { get; }   // 计算图形周长

        // 虚方法 打印图形类型 面积和周长
        public virtual void DisPlayInfo()
        {
            Console.WriteLine("图形类型：" + this.GetType().Name);
            Console.WriteLine($"面积：{Area}");
            Console.WriteLine($"周长：{Perimeter}");
            Console.WriteLine();
        }
    }
}
