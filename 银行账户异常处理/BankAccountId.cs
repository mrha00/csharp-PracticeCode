using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行账户异常处理
{
    public class BankAccountId
    {
        // 私有字段
        private readonly string _accountId;
        private readonly string _ownerName;
        private decimal _balance;

        // 公有属性（只读）
        public string AccountId => _accountId;
        public string OwnerName => _ownerName;
        public decimal Balance => _balance;

        // 构造函数
        public BankAccountId(string accountId, string ownerName)
        {
            // 验证参数（为空或空字符串则抛出异常）
            if (string.IsNullOrEmpty(accountId))
                throw new ArgumentException("账号不能为空");

            if (string.IsNullOrEmpty(ownerName))
                throw new ArgumentException("户主姓名不能为空");

            _accountId = accountId;
            _ownerName = ownerName;
            _balance = 0;
        }

        // 存款方法
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("存款金额必须大于 0");

            _balance += amount;
            Console.WriteLine($"存款成功，当前余额：{Balance:C}");
        }

        // 取款方法
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("取款金额必须大于 0");

            if (amount > _balance)
            {
                decimal deficit = amount - _balance;
                throw new InsufficientFundsException(deficit);
            }

            _balance -= amount;
            Console.WriteLine($"取款成功，当前余额：{Balance:C}");
        }

        // 转账方法
        public void Transfer(BankAccountId targetAccount, decimal amount)
        {
            if (targetAccount == null)
                throw new ArgumentNullException(nameof(targetAccount), "目标账户不能为空");

            // 先取款，再存款（保证原子性）
            Withdraw(amount);
            targetAccount.Deposit(amount);
            Console.WriteLine($"转账成功：{amount:C} 已转入账户 {targetAccount.AccountId}");
        }
    }
}
