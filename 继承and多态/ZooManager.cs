using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承and多态
{
    public class ZooManager
    {
        // 定义一个动物列表List
        private List<Animal> _animals;

        // 使用构造函数 初始化列表
        public ZooManager()
        {
            _animals = new List<Animal>();
        }

        // 添加动物方法
        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
            Console.WriteLine($"已添加动物：{animal.Name}（{animal.Age}岁）");
        }

        // 管理动物（调用所有动物的方法）
        public void ManageAnimals()
        {
            Console.WriteLine("\n=== 开始管理动物园动物 === \n");
            foreach (var animal in _animals)
            {
                Console.WriteLine($"【{animal.Name}（{animal.Age}岁）】");

                // 调用动物的方法
                Console.WriteLine($"叫声：{animal.MakeSound()}");
                animal.Eat();
                animal.Sleep();
                Console.WriteLine("\n");
            }
            Console.WriteLine("=== 动物园管理结束 ===");
        }
    }
}
