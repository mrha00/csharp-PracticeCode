using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行账户异常处理
{
    // 余额不足异常
    public class InsufficientFundsException : Exception
    {
        // 字段
        public decimal Deficit { get; }

        // 构造函数
        public InsufficientFundsException(decimal deficit) : base($"余额不足，差额：{deficit}")
        {
            Deficit = deficit;
        }
    }
}
