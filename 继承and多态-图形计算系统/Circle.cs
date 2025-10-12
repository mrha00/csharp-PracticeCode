using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承and多态_图形计算系统
{
    public class Circle : Shape
    {
        // 公有字段
        public double _radius;

        // 公有属性 Radius
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("半径必须大于0");
                }
                _radius = value;
            }
        }

        // 创建无构造函数
        public Circle()
        {
            _radius = 1;   // 构造完成后再调用抽象属性
        }
        public Circle(double radius)
        {
            Radius = radius;   // 构造完成后再调用抽象属性
        }

        public override double Area
        {
            get
            {
                return Math.PI * _radius * _radius; // 面积 = 2 x π x 半径²
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * _radius; // 周长 = 2 × π × 半径
            }
        }

        // 重写虚方法 DisPlayInfo
        public override void DisPlayInfo()
        {
            // 指定图形类型为圆形，再拼接面积和周长
            Console.WriteLine($"图形类型：圆形，面积：{Area:F2}，周长：{Perimeter:F2}");
        }

    }
}
