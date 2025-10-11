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



            Console.ReadKey();

        }
    }
}
