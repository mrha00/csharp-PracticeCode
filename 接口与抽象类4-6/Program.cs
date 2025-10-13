namespace 接口与抽象类4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建交通工具实例
            Vehicle car = new Car("丰田", "卡罗拉");
            Vehicle bicycle = new Bicycle("凤凰单车", "CT5");
            Vehicle electricCar = new ElectricCar("小米", "Su_7");

            Console.WriteLine("=== 测试汽车（Car） ===\n");
            car.Move();
            car.Stop();
            ((IFuelable)car).Refuel(80);    // 强制转换为IFuelable调用Refuel

            Console.WriteLine("\n=== 测试自行车（Bicycle） ===\n");
            bicycle.Move();
            bicycle.Stop();

            Console.WriteLine("\n=== 测试电动车（Maintenance） ===\n");
            electricCar.Move();
            electricCar.Stop();
            ((IMaintainable)electricCar).Maintenance();     // 强制转换为IMaintainable调用Maintenance




            Console.ReadKey();
        }
    }
}
