using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_泛型仓库
{
    // 创建实体类（商品）
    public class Product
    {
        // 属性
        public int Id { get; set; }             // 商品ID
        public string Name { get; set; }        // 商品名称
        public decimal Price { get; set; }      // 商品价格
        public int Stock { get; set; }          // 商品库存

        // 创建无参构造函数（需满足泛型需求）
        public Product() { }

        // 带参数构造函数
        public Product(int id, string name, decimal price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }

        // 重写ToString
        public override string ToString()
        {
            return $"商品[ID：{Id}，名称：{Name}，价格：{Price}，库存：{Stock}]";
        }
    }
}
