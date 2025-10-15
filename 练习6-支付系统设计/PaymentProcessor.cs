using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习6_支付系统设计
{
    // 支付处理器
    public class PaymentProcessor
    {
        // 方法：处理支付
        public bool Process(IPayment payment, decimal amount)
        {
            // 1. 获取支付方式名称
            string paymentMethod = payment.GetPaymentMethod();

            // 2. 打印支付方式
            Console.WriteLine($"支付方式：{paymentMethod}");

            // 3. 调用支付逻辑（接口方法）
            bool result = payment.ProcessPayment(amount);

            // 4. 返回支付结果
            return result;
        }

        
    }
}
