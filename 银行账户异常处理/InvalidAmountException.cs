using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行账户异常处理
{
    // 金额无效异常
    public class InvalidAmountException : Exception
    {
        // 构造方法
        public InvalidAmountException(string message) : base(message)   // 让父类的构造函数初始化自身的核心字段
        {
            
        }
    }
}
