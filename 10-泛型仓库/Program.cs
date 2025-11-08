namespace _10_泛型仓库
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 商品测试
            repoTest();

            // 客户测试
            custTest();

            // 订单测试
            orderTest();

            Console.WriteLine("==== 所有测试均已完成 ====");


            Console.ReadKey();
        }

        // 创建商品测试仓库
        public static void repoTest()
        {
            Console.WriteLine("=== 测试商品仓库 ===");
            // 1. 创建仓库
            Repository<Product> repo = new Repository<Product>();

            // 2.添加商品
            Product p1 = new Product(1, "iPhone", 6000m, 20);
            Product p2 = new Product(2, "AirPods", 1299m, 100);
            repo.Add(p1);
            repo.Add(p2);

            // 查看所有商品
            List<Product> allProducts = repo.GetAll();
            Console.WriteLine("所有商品");
            foreach (Product product in allProducts)
            {
                Console.WriteLine($"  - {product}");
            }

            // 4. 查找高价商品
            Product expensive = repo.Find(p => p.Price > 5000);
            Console.WriteLine($"高价商品：{expensive}");

            // 5. 移出商品
            repo.Remove(p2);
            Console.WriteLine("移出AirPods后的商品：");
            foreach (Product product in repo.GetAll())
            {
                Console.WriteLine($"  - {product}");
            }
        }

        // 创建客户测试仓库
        public static void custTest()
        {
            Console.WriteLine("\n=== 测试客户仓库 ===");
            // 1. 创建仓库
            Repository<Customer> cust = new Repository<Customer>();

            // 2.添加客户
            Customer c1 = new Customer(1, "张三", "13800138000", "zhangsan@example.com");
            Customer c2 = new Customer(2, "李四", "13900139000", "lisi@example.com");
            Customer c3 = new Customer(3, "王五", "13700137000", "wangwu@test.com");
            cust.Add(c1);
            cust.Add(c2);
            cust.Add(c3);

            // 查看所有客户
            List<Customer> allCustomer = cust.GetAll();
            Console.WriteLine("所有客户");
            foreach (Customer customer in allCustomer)
            {
                Console.WriteLine($"  - {customer}");
            }

            // 4. 查找指定客户
            Customer niu = cust.Find(p => p.Name  == "牛");
            Console.WriteLine($"查找到指定客户：{niu}");

            // 5. 移出客户
            cust.Remove(c2);
            Console.WriteLine("移出马后的客户：");
            foreach (Customer customer in cust.GetAll())
            {
                Console.WriteLine($"剩余客户：{customer}");
            }
        }

        // 创建测试仓库
        public static void orderTest()
        {
            Console.WriteLine("=== 测试订单仓库 ===");
            // 1. 创建仓库
            Repository<Order> order = new Repository<Order>();

            // 2.添加订单
            Order o1 = new Order(1, 1, new DateTime(2024, 1, 15), 6999.98m);
            Order o2 = new Order(2, 2, new DateTime(2024, 1, 16), 199.98m);
            Order o3 = new Order(3, 1, new DateTime(2024, 1, 17), 399.99m);
            order.Add(o1);
            order.Add(o2);
            order.Add(o3);

            // 查看所有订单
            List<Order> allOrders = order.GetAll();
            Console.WriteLine("\n所有订单:");
            foreach (Order ord in allOrders)
            {
                Console.WriteLine($"  - {ord}");
            }

            // 查找大额订单（金额 > 1000）
            Console.WriteLine("\n查找大额订单（金额 > 1000）:");
            Order bigOrder = order.Find(o => o.TotaAmount > 1000);
            if (bigOrder != null)
            {
                Console.WriteLine($"  找到: {bigOrder}");
            }

            // 查找客户1的所有订单
            Console.WriteLine("查找客户1的所有订单:");
            Order customer1Order = order.Find(o => o.CustomerId == 1);
            if (customer1Order != null)
            {
                Console.WriteLine($"  找到: {customer1Order}");
            }

            // 查找今天之后的订单（模拟）
            Console.WriteLine("查找2024年1月16日及之后的订单:");
            Order recentOrder = order.Find(o => o.OrderDate >= new DateTime(2024, 1, 16));
            if (recentOrder != null)
            {
                Console.WriteLine($"  找到: {recentOrder}");
            }

            Console.WriteLine();
        }
    }
}
