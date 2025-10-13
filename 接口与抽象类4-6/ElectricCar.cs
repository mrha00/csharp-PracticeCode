using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口与抽象类4_6
{
    public class ElectricCar : Vehicle, IMaintainable
    {
        // 派生类 ElectricCar（继承Vehicle）
        public ElectricCar(string brand, string model) : base(brand, model)
        {

        }

        // 实现 IMaintainable接口方法
        public void Maintenance()
        {
            Console.WriteLine($"{Brand}--{Model}正在进行电池维护");
        }
    }
}
