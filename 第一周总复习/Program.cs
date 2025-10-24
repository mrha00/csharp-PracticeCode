namespace 第一周总复习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 实例化对象
            Rectangle rectangle = new Rectangle();
            rectangle.SetDimensions(5,5);
            Console.WriteLine($"矩形的面积是：{rectangle.GetArea()}\n矩形的周长是：{rectangle.GetPerimeter()}\n");

            Console.WriteLine("---------------------------------------------------------------------------------------------");


            // 实例化对象AreaCalculator
            AreaCalculator areaC = new AreaCalculator();
            Console.WriteLine($"正方形面积：{areaC.CalculateArea(4)}");
            Console.WriteLine($"矩形面积：{areaC.CalculateArea(4.6, 4.2):F2}");
            Console.WriteLine($"圆形面积：{areaC.CalculateArea(4.2):F2}\n");

            Console.WriteLine("---------------------------------------------------------------------------------------------");




            // 实例化Book对象
            Book book1 = new Book();
            book1.ShowInfo();

            Console.WriteLine("\n传入一个参数");
            Book book2 = new Book("C语言");
            book2.ShowInfo();

            Console.WriteLine("\n传入两个参数");
            Book book3 = new Book("C语言", "张三");
            book3.ShowInfo();

            Console.WriteLine("\n传入三个参数");
            Book book4 = new Book("C语言", "张三", 2020);
            book4.ShowInfo();

            Console.WriteLine("---------------------------------------------------------------------------------------------");


            // ref & out
            int x = 5, y = 10;
            Swap(ref x, ref y);
            Console.WriteLine($"交换后：x = { x}, y = { y}\n");
            Console.WriteLine("不使用ref关键字：\n");

            Swap(ref x, ref y);
            Console.WriteLine($"交换后：x = {x}, y = {y}\n");


            int[] nums = [3, 1, 5, 8, 9, 4];
            FindMinMax(nums, out int min, out int max);
            Console.WriteLine($"最小值：{min}，最大值：{max}");
            */

            // 实例化对象
            Employee[] emp = new Employee[]
            {
                new Manager { Name = "张经理", Age = 30, Salary = 9000.00, Department = "IT部"},
                new Salesman { Name = "李销售", Age = 30, Salary = 12000.00, salesVolume = "三十万"}
            };

            // 多态调用
            foreach (Employee employee in emp)
            {
                employee.ShowInfo();
            }

            Console.WriteLine("二维数组-----------------------------------------------------------------------------------------");

            // 二维数组
            int[,] matrix = new int[3, 4];
            matrix[2, 3] = 8;
            // 遍历打印所有元素
            for (int i = 0; i < matrix.GetLength(0); i++)   // 获取行数
            {
                for (int j = 0; j < matrix.GetLength(1); j++)   // 获取列数
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }

            Console.WriteLine("\n二维数组-----------------------------------------------------------------------------------------");

            // 一维/二维字符串数组

            string[] names = new string[3] { "Amy", "Bob", "Cindy" };
            string[,] nameGender = new string[2, 2] { { "Amy", "女" }, { "Bob", "男" } };
            Array.Sort(names); // 按字母排序一维数组



            int[] nums = new int[10] { 9, 2, 5, 1, 7, 4, 8, 3, 6, 0 };
            Array.Sort(nums); // 升序排序
            Array.Reverse(nums); // 降序排序（先升序再反转






















            Console.ReadKey();
        }

        // 编写Swap 使用ref关键字交换两个整数变量的值。然后在Main方法中调用这个方法，并验证交换是否成功。

        /*
        public static void Swap( ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // 计算最大值和最小值
        public static void FindMinMax(int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];
            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
        }
        */
    }
}
