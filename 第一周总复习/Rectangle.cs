using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一周总复习
{
    public class Rectangle
    {
        // 私有字段
        private double length;
        private double width;

        // 公有方法
        public void SetDimensions(double l, double w)
        {
            length = l;
            width = w;
        }

        // 返回矩形的面积
        public double GetArea() => length * width;

        // 返回矩形的周长
        public double GetPerimeter() => 2 * (length + width);
    }
}
