using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_WeekTwo
{
    // 静态类
    public static class GenericHelper
    {
        /// <summary>
        /// 查找集合中的最大值
        /// </summary>
        /// <typeparam name="T">集合元素类型</typeparam>
        /// <param name="list"></param>
        /// <returns>集合中最大值</returns>
        public static T FindMax<T>(List<T> list) where T : IComparable<T>
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list), "集合不能为空");

            if (list.Count == 0)
                throw new InvalidOperationException("集合中无元素，无法查找最大值");

            T max = list[0];        // 定义初始值
            foreach (T item in list)
            {
                if (item.CompareTo(max) > 0)    // 判断item是否大于max 成立则替换
                {
                    max = item;
                }
            }
            return max;
        }

        // 交换变量值方法
        public static void Swap<T>(ref T a, ref T b)
        {
            (a, b) = (b, a);    // 使用元祖结构交换变量值
        }

        /// <summary>
        /// 根据条件筛选集合中的元素
        /// </summary>
        /// <typeparam name="T">集合元素类型</typeparam>
        /// <param name="list">要筛选的集合</param>
        /// <param name="predicate">筛选条件委托（返回bool的函数）</param>
        /// <returns>满足条件的新集合</returns>
        /// <exception cref="ArgumentNullException">
        /// 当集合或条件委托为null时抛出
        /// </exception>
        /// <remarks>
        /// 功能类似于LINQ的Where方法，但这是手动实现的版本
        /// </remarks>
        public static List<T> Filter<T>(List<T> list, Func<T, bool> predicate)
        {
            // 参数校验
            if (list == null)
                throw new ArgumentNullException(nameof(list), "集合不能为空");
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate), "条件筛选委托不能为空");

            // 创建新集合存储筛选结果
            List<T> filteredList = new List<T>();

            // 遍历原始集合（注意：原代码有误，应该是遍历list而非filteredList）
            foreach (T item in list)  // 修正：遍历输入集合list
            {
                // 检查当前元素是否满足条件
                if (predicate(item))
                {
                    filteredList.Add(item);  // 满足条件则加入结果集
                }
            }

            return filteredList;  // 返回筛选后的新集合
        }
    }
}
