using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习6_支付系统设计
{
    public class CreditCardPayment : IPayment
    {
        public string _CardNumber;    // 卡号
        public string ExpiryDate { get; set; }          // 有效期

        // 公有属性
        public string CardNumber
        {
            get
            {
                // 脱敏显示：保留最后4位，前面用*号代替
                if (string.IsNullOrEmpty(_CardNumber) || _CardNumber.Length < 4)
                    return "****";
                // 拼接格式：****-****-****-1234
                string lastFour = _CardNumber.Substring(_CardNumber.Length - 4);
                return $"****-****-****-{lastFour}";
            }
            set
            {
                // 存储时去除所有分隔符（防空异常）
                _CardNumber = value?.Replace("-", "") ?? string.Empty;
            }
        }

        // 构造函数
        public CreditCardPayment(string cardNumber)
        {
            // 初始化卡号（自动触发脱敏逻辑）
            _CardNumber = cardNumber;
        }

        // 实现接口方法
        public bool ProcessPayment(decimal amount)
        {
            // 模拟支付逻辑
            bool isValidCard = !string.IsNullOrEmpty(CardNumber) && CardNumber != "****";

            if (isValidCard)
            {
                Console.WriteLine($"使用信用卡（{CardNumber}）支付 {amount:C} 元");
            }
            else
            {
                Console.WriteLine("支付失败：无效卡号");
            }

            return isValidCard;
        }

        public string GetPaymentMethod()
        {
            return "信用卡支付";
        }
    }
}
