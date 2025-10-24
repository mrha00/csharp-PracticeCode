using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一周总复习
{
    public class Book
    {
        // 私有字段
        private string title;       // 图书标题
        private string author;      // 图书作者
        private int year;        // 出版年份

        // 无参构造方法
        public Book()
        {
            title = "未知";
            author = "未知";
            year = 0;
        }

        // 带一个参数构造方法
        public Book(string title)
        {
            this.title = title;
        }

        // 带两个参数构造方法
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        // 带三个参数构造方法
        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }

        // 公有方法
        public void ShowInfo()
        {
            Console.WriteLine($"书名：{title}，作者：{author}，出版年份：{year}");
        }
    }
}
