namespace 银行账户异常处理
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 创建账户
                var account1 = new BankAccountId("A001", "张三");
                var account2 = new BankAccountId("A002", "李四");

                // 测试存款
                account1.Deposit(1000);
                Console.WriteLine();

                // 测试取款（正常）
                account1.Withdraw(500);
                Console.WriteLine();

                // 测试取款（余额不足）
                account1.Withdraw(600);  // ❌ 触发 InsufficientFundsException
            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine($"金额异常：{ex.Message}");
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"余额不足：{ex.Message}，差额：{ex.Deficit:C}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"未知异常：{ex.Message}");
            }

            Console.WriteLine("\n--- 测试转账（目标账户不存在） ---");
            try
            {
                var account3 = new BankAccountId("A003", "王五");
                // 目标账户为 null（触发 ArgumentNullException）
                account3.Transfer(null, 100);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"参数异常：{ex.Message}");
            }
        }
    }
}
