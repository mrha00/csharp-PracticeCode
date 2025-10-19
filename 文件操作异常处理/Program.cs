namespace 文件操作异常处理
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建文件路径并保存在filePath
            string filePath = @"C:\Users\Administrator\Desktop\测试文本.txt";
            string filePath1 = @"C:\Users\Administrator\Desktop\读取文本.txt";
            string content = "哈哈哈还剩多少电视电话手机号";

            // 测试读取不存在的文件
            Console.WriteLine("读取不存在的文件：");
            string result = FileProcessor.ReadFile("nonexistent.txt");

            Console.WriteLine("\n————————————————————————————————————————————————\n");

            // 测试写入文件
            Console.WriteLine("\n 写入文件：");
            FileProcessor.WriteFile(filePath, content);
            Console.WriteLine("\n写入的内容是：");
            string a = FileProcessor.ReadFile("C:\\Users\\Administrator\\Desktop\\测试文本.txt");
            Console.WriteLine(a);

            Console.WriteLine("\n————————————————————————————————————————————————\n");

            // 测试读取存在的文件
            Console.WriteLine("读取存在的文件：");
            string readContent = FileProcessor.ReadFile(filePath1);
            if (readContent != null)
            {
                Console.WriteLine("读取到的内容是：\n");
                Console.WriteLine(readContent);
            }

            Console.WriteLine("\n————————————————————————————————————————————————\n");

            // 测试写入被占用的文件
            Console.WriteLine("尝试写入被占用的文件（需手动占用文件）：");
            // 手动打开文件，再运行WriteFile
            FileStream fs = new FileStream(
                        @"C:\Users\Administrator\Desktop\测试文本.txt",
                        FileMode.Open,
                        FileAccess.Read,
                        FileShare.None); // 不允许别人访问
                                Console.ReadLine(); // 程序暂停，占用文件
            // 1️⃣ 创建 FileStream 并锁定文件
            Console.WriteLine("已占用文件，不允许其他程序访问...");
            FileStream fs1 = new FileStream(
                filePath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.None); // 不允许别人访问该文件

            try
            {
                // 2️⃣ 尝试写入（会失败）
                Console.WriteLine("\n尝试写入被占用的文件：");
                FileProcessor.WriteFile(filePath, content);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"写入失败：文件被占用 - {ex.Message}");
            }
            finally
            {
                // 3️⃣ 释放文件锁
                fs1.Close();
                Console.WriteLine("\n文件锁已释放。");
            }


            Console.ReadKey();
        }
    }
}
