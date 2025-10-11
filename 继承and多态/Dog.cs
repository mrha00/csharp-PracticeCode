using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承and多态
{
    public class Dog : Animal
    {
        public override string MakeSound()
        {
            return "旺旺";
        }

        // 实现父类抽象方法
        public override void Sleep()
        {
            Console.WriteLine($"{Name}趴在狗窝睡觉");
        }

        // 
    }
}
