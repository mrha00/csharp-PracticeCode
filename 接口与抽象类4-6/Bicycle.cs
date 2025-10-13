using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口与抽象类4_6
{
    public class Bicycle : Vehicle
    {
        /*  派生类 Bicycle（继承Vehicle）
            先调用 Vehicle 类的构造函数，把 brand 和 model 传给它。
            父类的构造函数负责初始化品牌和型号字段
        */
        public Bicycle(string brand, string model) : base(brand, model) { }

        // 重写 Move 方法
        public override void Move()
        {
            Console.WriteLine($"{Brand}--{Model} 自行车正在骑行");
        }
    }
}
