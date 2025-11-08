using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_泛型仓库
{
    // 创建实体类（客户）
    public class Customer
    {
        // 属性
        public int Id { get; set; }         // 客户ID
        public string Name { get; set; }    // 客户名称
        public string Phone { get; set; }   // 客户号码
        public string Email { get; set; }   // 客户邮箱

        // 依旧创建无参构造函数
        public Customer() { }

        // 带参构造函数
        public Customer(int id, string name, string phone, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
        }

        // 重写 Tostring
        public override string ToString()
        {
            return $"客户[ID：{Id}，名称：{Name}，号码：{Phone}，邮箱：{Email}]";
        }
    }
}
