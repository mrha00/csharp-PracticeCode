using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习6_支付系统设计
{
    // 银行转账支付
    public class BankTransferPayment : IPayment
    {
        // 私有字段存储完整账号
        private string _accountNumber;
        private string _bankName;

        // 构造函数
        public BankTransferPayment(string bankName, string accountNumber)
        {
            _accountNumber = accountNumber;
            _bankName = bankName;           // 自动触发脱敏逻辑
        }

        // 银行名称属性
        public string BankName
        {
            get => _bankName;
            set => _bankName = value;
        }

        // 脱敏账号属性
        public string AccountNumber
        {
            get
            {
                if (string.IsNullOrEmpty(_accountNumber) || _accountNumber.Length < 4)
                {
                    return "****";  // 默认值（条件未通过判断为无效账号）
                }
                return "****" + _accountNumber.Substring(_accountNumber.Length - 4);
            }
            private set
            {
                // 存储时去除空格和特殊字符
                _accountNumber = value?.Replace(" ", "").Replace("-", "") ?? string.Empty;
            }
        }

        // 实现ProcessPayment接口方法
        public bool ProcessPayment(decimal amount)
        {
            // 模拟支付逻辑：银行名称非空则成功
            bool isSuccess = !string.IsNullOrEmpty(BankName);

            // 打印支付信息
            if (isSuccess)
            {
                Console.WriteLine($"使用银行转账 （{_bankName} 银行，账号 {AccountNumber}）支付 {amount:C} 元");
            }
            else
            {
                Console.WriteLine("支付失败：银行名称不能为空");
            }
            return isSuccess;
        }

        // 实现GetPaymentMethod接口方法
        public string GetPaymentMethod()
        {
            return "银行转账支付";
        }
    }
}
