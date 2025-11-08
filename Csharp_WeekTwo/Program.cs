using System.Security.Claims;

namespace Csharp_WeekTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 测试FindMax
            TestFindMax();

            // 测试Swap
            TestSwap();

            // 测试
            TestFilter();

            Console.WriteLine("所有测试全部通过");

            Console.ReadKey();
        }

        // 比大小
        static void TestFindMax()
        {
            Console.WriteLine("===== 测试 FinMax =====");

            // int 类型测试
            var intList = new List<int> { 3,5,7,9,1,7,8};
            int intMax = GenericHelper.FindMax(intList);
            Console.WriteLine($"int 最大值：{intMax}");

            // strign 类型测试（按字典序）
            var strList = new List<string> { "Apple", "Banana", "Cherry" };
            string strMax = GenericHelper.FindMax(strList);
            Console.WriteLine($"string 最大值：{strMax}");

            // double 类型测试
            var doubleList = new List<double> { 3.14, 2.71, 1.681 };
            double doubleMax = GenericHelper.FindMax(doubleList);
            Console.WriteLine($"double 最大值：{doubleMax}");
        }

        // 交换变量值
        static void TestSwap()
        {
            Console.WriteLine("\n===== 测试 Swap =====");

             // int 类型交换
             int x = 10, y = 20;
            Console.WriteLine($"交换前：x = {x}，y = {y}");
            GenericHelper.Swap(ref x, ref y);
            Console.WriteLine($"交换后 ：x = {x}，y = {y}");

            // string 类型交换
            string s1 = "World！", s2 = "Hello!";
            Console.WriteLine($"交换前：s1 = {s1}，s2 = {s2}");
            GenericHelper.Swap(ref s1, ref s2);
            Console.WriteLine($"交换后：s1 = {s1}，s2 = {s2}");

            // doubel 类型交换
            double d1 = 3.14, d2 = 1.596;
            Console.WriteLine($"交换前：d1 = {d1}，d2 = {d2}");
            GenericHelper.Swap(ref d1, ref d2);
            Console.WriteLine($"交换后：d1 = {d1}，d2 = {d2}");
        }

        // 筛选符合类型
        static void TestFilter()
        {
            Console.WriteLine("\n===== 测试 Filter =====");

            // int 类型筛选（偶数）
            var intList = new List<int> { 1, 2, 3, 4, 5 };
            var evenNumbers = GenericHelper.Filter(intList, x => x % 2 == 0);
            Console.WriteLine($"int 筛选偶数: [{string.Join(", ", evenNumbers)}] (预期: 2, 4)");

            // string 类型筛选（长度 > 5）
            var strList = new List<string> { "Apple", "Banana", "Cherry", "Grape" };
            var longWords = GenericHelper.Filter(strList, s => s.Length > 5);
            Console.WriteLine($"string 筛选长单词: [{string.Join(", ", longWords)}] (预期: Banana, Cherry)");

            // double 类型筛选（大于 3.0）
            var doubleList = new List<double> { 1.1, 2.2, 3.3, 4.4 };
            var largeNumbers = GenericHelper.Filter(doubleList, d => d > 3.0);
            Console.WriteLine($"double 筛选大于3.0: [{string.Join(", ", largeNumbers)}] (预期: 3.3, 4.4)");
        }
    }
}
