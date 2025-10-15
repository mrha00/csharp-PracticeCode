namespace 练习6_支付系统设计
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建支付实例
            IPayment creditCard = new CreditCardPayment("4532756279624589");
            IPayment payPal = new PayPalPayment("user@example.com");
            IPayment bankTransfer = new BankTransferPayment("中国银行", "1234567890");

            // 创建支付处理器
            PaymentProcessor processor = new PaymentProcessor();

            // 测试支付
            Console.WriteLine("信用卡支付测试：");
            bool result1 = processor.Process(creditCard, 100.00m);
            Console.WriteLine($"支付结果：{(result1 ? "成功" : "失败")}");

            Console.WriteLine("\nPayPal 支付测试：");
            bool result2 = processor.Process(payPal, 50.00m);
            Console.WriteLine($"支付结果：{(result2 ? "成功" : "失败")}");

            Console.WriteLine("\n银行转账支付测试：");
            bool result3 = processor.Process(bankTransfer, 200.00m);
            Console.WriteLine($"支付结果：{(result3 ? "成功" : "失败")}");
        }
    }
}
