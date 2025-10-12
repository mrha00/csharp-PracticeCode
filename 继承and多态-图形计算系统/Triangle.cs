using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承and多态_图形计算系统
{
    public class Triangle : Shape
    {
        // 私有字段
        private double _sideA;
        private double _sideB;
        private double _sideC;

        // 公有属性 对外提供访问接口，并且在赋值时验证三角形三边关系
        // 公有属性：SideA（对应字段_sideA）
        public double SideA
        {
            get => _sideA;  // 获取当前A边的值
            set
            {
                if (IsValidTriangle(value, _sideB, _sideC))
                    _sideA = value;  // 合法则更新A边
                else
                    throw new ArgumentException("A边赋值失败：不满足三角形三边关系");
            }
        }

        // 公有属性：SideB（对应字段_sideB）
        public double SideB
        {
            get => _sideB;
            set
            {
                if (IsValidTriangle(_sideA, value, _sideC))
                    _sideB = value;  // 合法则更新B边
                else
                    throw new ArgumentException("B边赋值失败：不满足三角形三边关系");
            }
        }

        // 公有属性：SideC（对应字段_sideC）
        public double SideC
        {
            get => _sideC;
            set
            {
                if (IsValidTriangle(_sideA, _sideB, value))
                    _sideC = value;  // 合法则更新C边
                else
                    throw new ArgumentException("C边赋值失败：不满足三角形三边关系");
            }
        }

        // 使用构造函数
        public Triangle(double a, double b, double c)
        {
            // 构造完成后再调用抽象属性
            if (IsValidTriangle(a, b, c))
            {
                _sideA = a;
                _sideB = b;
                _sideC = c;
            }
            else
            {
                throw new ArgumentException("初始化失败：三边不满足三角形关系");
            }
        }

        // 实现 面积计算 Area 使用海伦公式：V[s (s-a)(s-b)(s-c)]，其中 S=(a+b+c)/2）
        // 重写父类的面积计算（海伦公式）
        public override double Area
        {
            get
            {
                double s = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }
            
        }

        // 重写周长计算
        public override double Perimeter
        {
            get
            {
                return SideA + SideB + SideC;
            }
        }

        // 重写DisplayInfo
        public override void DisPlayInfo()
        {
            Console.WriteLine($"三角形：三边分别为：{SideA}，{SideB}，{SideC}");
            Console.WriteLine($"周长：{Perimeter}，面积：{Area:F2}");
        }

        // 定义辅助方法
        private bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0
                && (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}
