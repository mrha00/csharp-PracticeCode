using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented
{
    internal class Student : Person     // 继承 Person
    {
        // 创建私有字段
        private string _grade;  // 年级
        private string _major;  // 专业

        // 创建公有属性
        public string Grade
        {
            get { return _grade; }
            set { _grade = value; } 
        }

        public string Major
        {
            get { return _major; }
            set { _major = value; }
        }

        // 构造函数
        public Student() : base() { }
        public Student(string name, int age, string id, string grade, string major) : base(name, age, id)
        {
            Grade = grade;
            Major = major;
        }


        // 重写Introduce方法（重写父类方法）
        public override void Introduce()
        {
            Console.WriteLine($"我的名字是{Name}，年龄是{Age}，ID是{Id}，专业是{_grade}，年级是{_major}");
        }
    }
}
