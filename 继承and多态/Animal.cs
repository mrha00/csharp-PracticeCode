using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承and多态
{
    public abstract class Animal
    {
        // 公有字段
        public string name;
        public int age;

        // 抽象方法
        public abstract void Sleep();

        // 属性
        public string Name { get; set; }
        public int Age { get; set; }
        
        // 虚方法
        public virtual string MakeSound()
        {
            return "未知动物叫声";
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name}正在进食");
        }
    }
}
