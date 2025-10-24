using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一周总复习
{
    public class AreaCalculator
    {
        // 创建方法重载
        public int CalculateArea(int side) => side * side;   // 计算正方形面积
        public double CalculateArea(double length, double width) => length * width; // 计算矩形面积
        public double CalculateArea(double radius) => Math.PI * radius * radius;    // 计算圆的面积
    }
}
