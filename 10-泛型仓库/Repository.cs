using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_泛型仓库
{
    //创建泛型类
    public class Repository<T> where T : class, new()
    {
        // 私有字段
        private List<T> _items = new List<T>();

        // 添加元素方法
        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "不能添加空元素");
            _items.Add(item);
        }

        // 移出元素
        public bool Remove(T item)
        {
            return _items.Remove(item);
        }

        // 根据条件查找元素
        public T Find(Func<T, bool> predicate)
        {
            return _items.FirstOrDefault(predicate);
        }

        // 获取所有元素（返回副本）
        public List<T> GetAll()
        {
            return new List<T>(_items);
        }
    }
}
