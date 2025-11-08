using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_泛型仓库
{
    // 创建实体类（订单）
    public class Order
    {
        // 属性
        public int Id { get; set; }                 // 订单ID
        public int CustomerId { get; set; }         // 顾客ID
        public DateTime OrderDate { get; set; }     // 订单时间
        public decimal TotaAmount { get; set; }     // 订单总价

        // 依依旧创建无参构造函数
        public Order() { }

        // 创建带参构造函数
        public Order(int id, int customerid, DateTime orderdate, decimal totaAmount)
        {
            this.Id = id;
            this.CustomerId = customerid;
            this.OrderDate = orderdate;
            this.TotaAmount = totaAmount;
        }

        // 重写 ToString
        public override string ToString()
        {
            return $"订单[订单ID：{Id}，顾客ID：{CustomerId}，订单时间：{OrderDate}，订单总价：{TotaAmount}]";
        }
    }
}
