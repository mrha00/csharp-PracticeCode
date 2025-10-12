using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承and多态
{
    public class Bird : Animal
    {
        // 重写MakeSound 虚方法
        public override string MakeSound()
        {
            return "叽叽叫";
        }

        // 实现 Sleep 抽象方法
        public override void Sleep()
        {
            Console.WriteLine("小鸟站在树枝睡觉");
        }
    }
}
