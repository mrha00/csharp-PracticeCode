using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented
{
    internal class Person
    {
        // 私有字段
        private string _name;
        private int _age;
        private string _id;

        // 公有属性
        public string Name
        {
            get { return _name; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 150)
                {
                    throw new ArgumentOutOfRangeException("年龄必须在 0-150 之间");
                }
                _age = value;
            }
        }

        public string Id
        {
            get { return _id; }
        }

        // 构造函数：3 个重载版本
        // 1. 无参构造函数
        public Person() : this("Alice", 0, "0000")
        {
        }

        // 仅姓名
        public Person(string name) : this(name, 0, "0000")
        {
        }

        // 全参数构造函数
        public Person(string name, int age, string id)
        {
            _name = name;
            Age = age;      // 利用属性值赋值，验证出发逻辑
            _id = id;
        }

        // 方法
        public virtual void Introduce()
        {
            Console.WriteLine($"我的名字是{Name}，年龄是{Age}，ID{Id}");
        }
    }
}
