using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口与抽象类4_6
{
    public class Car :Vehicle, IFuelable
    {
        // 派生类：Car（继承Vehicle，实现IFuelable）
        public Car(string brand, string model) : base(brand, model) { }

        // 实现IFuelable的Refuel方法 
        public void Refuel(int amount)
        {
            Console.WriteLine($"为{Brand}--{Model}汽车添加了{amount}单位油量");
        }
    }
}
