using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented
{
    internal class Calculator
    {
        // 方法重载
        public int Add(int a, int b)
        {
            return a + b;   // 返回两个整数的和
        }

        public double Add(double a, double b)
        {
            return a + b;   // 返回两个双精度浮点数的和
        }

        public int Add(int a, int b, int c)
        {
            return a + b;   // 返回三整数两和
        }

        public string Add(string a, string b)
        {
            return $"{a}{b}";   // 返回两个字符串的拼接结果
        }
    }
}
