using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承and多态
{
    public class Cat : Animal
    {
        // 重写MakeShoud
        public override string MakeSound()
        {
            return "喵喵";
        }

        // 实现Sleep抽象方法
        public override void Sleep()
        {
            Console.WriteLine("小猫蜷缩在沙发睡觉");
        }

    }
}
