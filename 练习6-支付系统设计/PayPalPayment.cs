using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习6_支付系统设计
{
    public class PayPalPayment : IPayment
    {
        // 字段
        public string Email { get; set; }  // 绑定邮箱

        // 构造函数：用于初始化邮箱
        public PayPalPayment(string email)
        {
            Email = email;
        }

        // 实现ProcessPayment接口方法
        public bool ProcessPayment(decimal amount)
        {
            if (string.IsNullOrEmpty(Email) || !Email.Contains("@"))
            {
                Console.WriteLine("支付失败：邮箱格式无效");
                return false;
            }
            Console.WriteLine($"使用 PayPal（{Email}）支付{amount:C2}");
            return true;
        }

        // 实现GetPaymentMethod接口方法
        public string GetPaymentMethod()
        {
            return "PayPal 支付";
        }
    }
}
