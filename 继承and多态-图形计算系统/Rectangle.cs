using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承and多态_图形计算系统
{
    public class Rectangle : Shape
    {
        // 私有字段
        private double _width;
        private double _height;

        // 公有属性
        public double Width 
        { 
            get => _width;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("宽度必须大于0");
                }
                _width = value;
            }
        }
        public double Height 
        {
            get => _height;
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("高度必须大于0");
                }
                _height = value;
            }
        }

        // 无构造函数
        public Rectangle()
        {
            // 构造完成后再调用抽象属性
            _width = 1;
            _height = 1;
        }
        public Rectangle(double width, double height)
        {
            // 构造完成后再调用抽象属性
            Width = width;
            Height = height;
        }

        // 实现 Area（面积计算方法）
        public override double Area
        {
            get => _width * _height;    // 面积 = 宽x高
        }

        public override double Perimeter
        {
            get => 2 * (_width + _height);   // 周长 = 2 x 宽+高
        }

        // 虚方法 DisplayInfo 指定图形类型为 矩形
        public override void DisPlayInfo()
        {
            Console.WriteLine($"图形类型：矩形，面积：{Area:F2}，周长：{Perimeter:F2}");
        }
    }
}
