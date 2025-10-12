namespace 继承and多态
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建一个Dog对象
            Dog dog = new Dog();

            // 设置属性
            dog.Name = "大黄";
            dog.Age = 3;

            // 输出基本信息
            Console.WriteLine($"名字：{dog.Name}");
            Console.WriteLine($"狗龄：{dog.Age}");

            // 调用虚方法 MakeSound
            Console.WriteLine($"叫声：{dog.MakeSound()}");

            // 调用抽象方法 Sleep
            dog.Sleep();

            // 调用虚方法 Eat
            dog.Eat();

            Console.WriteLine("-------------------------------------------------------------------------\n");

            // 创建一个Cat对象
            Cat cat = new Cat();

            // 设置属性
            cat.Name = "橘猫";
            cat.Age = 2;

            // 输出基本信息
            Console.WriteLine($"名字：{cat.Name}");
            Console.WriteLine($"猫龄：{cat.Age}");

            // 调用虚方法 MakeSound
            Console.WriteLine($"叫声：{cat.MakeSound()}");

            // 调用抽象方法
            cat.Sleep();

            // 调用虚方法 Eat
            cat.Eat();

            Console.WriteLine("-------------------------------------------------------------------------\n");

            // 创建一个Bird对象
            Bird bird = new Bird();

            // 设置属性
            bird.Name = "布谷鸟";
            bird.Age = 1;

            // 输出基本信息
            Console.WriteLine($"名字：{bird.Name}");
            Console.WriteLine($"年龄：{bird.Age}");

            // 调用虚方法 MakeSound
            Console.WriteLine($"叫声：{bird.MakeSound()}");

            // 调用抽象方法
            bird.Sleep();

            // 调用虚方法 Eat
            bird.Eat();

            Console.WriteLine("-------------------------------------------------------------------------\n");


            // 创建动物园管理员
            ZooManager zooManager = new ZooManager();

            // 创建一些动物
            dog = new Dog { Name = "大黄", Age = 3};
            cat = new Cat { Name = "橘猫", Age = 2 };
            bird = new Bird { Name = "布谷鸟", Age = 1 };

            // 添加到动物园
            zooManager.AddAnimal(dog);
            zooManager.AddAnimal(cat);
            zooManager.AddAnimal(bird);

            // 管理动物
            zooManager.ManageAnimals();





            Console.ReadKey();

        }
    }
}
