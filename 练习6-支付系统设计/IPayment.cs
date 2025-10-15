using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习6_支付系统设计
{
    public interface IPayment
    {
        /// <summary>
        /// 处理支付
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>返回 true 表示支付成功， false 表示失败</returns>
        bool ProcessPayment(decimal amount);

        /// <summary>
        /// 返回支付方式名称
        /// </summary>
        /// <returns>返回支付方式的名称：如信用卡，微信，支付宝等等</returns>
        string GetPaymentMethod();
    }
}
