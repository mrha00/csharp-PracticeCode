namespace 继承and多态_图形计算系统
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 实例化 圆形 Circle 
            Circle circle = new Circle();
            circle.Radius = 5.5;
            circle.DisPlayInfo();

            Console.WriteLine("------------------------------------------------------------------------\n");

            // 实例化 矩形 Rectangle
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5.5;
            rectangle.Height = 5.5;
            rectangle.DisPlayInfo();

            Console.WriteLine("------------------------------------------------------------------------\n");

            // 实例化 三角形
            Triangle triangle = new Triangle(4, 5, 6);

            // 调用子类 DisplayInfo 方法
            triangle.DisPlayInfo();
            
            // 测试多态
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle(5));          // 半径5的圆形
            shapes.Add(new Rectangle(4, 6));    //宽4、高6的矩形
            shapes.Add(new Triangle(3, 4, 5));  // 直角三角形

            Console.WriteLine("\n=== 图形信息汇总 ===\n");
            foreach (var shape in shapes)
            {
                shape.DisPlayInfo();
                Console.WriteLine("--------------------------------------\n");
            }

            Console.ReadKey();
        }
    }
}
