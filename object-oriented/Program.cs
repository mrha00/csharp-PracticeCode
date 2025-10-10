using object_oriented;
using System.Diagnostics;

// 创建实例并调用全参
Person p = new Person("Tom", 25, "1234");
p.Introduce();

Console.WriteLine("全参构造----------------------------------------------------------------------------\n");

// 调用无参构造
Person p2 = new Person();
p2.Introduce();
Console.WriteLine("无参构造----------------------------------------------------------------------------\n");

// 调用仅姓名构造
Person p3 = new Person("Tom");
p3.Introduce();
Console.WriteLine("仅姓名构造----------------------------------------------------------------------------\n");

// 创建Student实例
Student s = new Student("Tom", 25, "1234" ,"大二","软件技术");
s.Introduce();
Console.WriteLine("重写父类方法----------------------------------------------------------------------------\n");


// 创建Calculator实例
Calculator c = new Calculator();
// 测试int双参Add 
int result = c.Add(10, 20);
Console.WriteLine($"10+20=  {result}");

// 测试double双参Add
double result2 = c.Add(10.5, 20.5);
Console.WriteLine($"10.5+20.5=  {result2}");

//  测试int三参Add 
int result3 = c.Add(10, 20, 30);
Console.WriteLine($"10+20+30=   {result}");

// 测试字符串Add
string result4 = c.Add("Hello", " World");
Console.WriteLine($"Hello拼接World：   {result4}");

Console.ReadKey();