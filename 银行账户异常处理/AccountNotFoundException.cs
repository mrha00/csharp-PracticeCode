using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行账户异常处理
{
    // 账户未找到异常
    public class AccountNotFoundException : Exception
    {
        // 存储未找到的账号
        public string AccountId { get; }

        // 构造函数
        public AccountNotFoundException(string accountId) : base($"账户 {accountId} 未找到")
        {
            AccountId = accountId;
        }
    }
}
