using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件操作异常处理
{
    public class FileProcessor
    {
        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <param name="path"></param>
        /// <returns>文件内容字符串</returns>
        public static string ReadFile(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path), "文件路径不能为空");
            try
            {
                // 用 using 自动释放 StreamReader 资源
                using (StreamReader reader = new StreamReader(path))
                {
                    return reader.ReadToEnd();
                }
            }
            catch(FileNotFoundException ex)         // 找不到文件时抛出异常
            {
                Console.WriteLine($"错误：文件未找到 - {ex.Message}");
            }
            catch (DirectoryNotFoundException ex)   // 目录不存在时抛出异常
            {
                Console.WriteLine($"错误：目录不存在 - {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)  // 权限不足时抛出异常
            {
                Console.WriteLine($"错误：权限不足 - {ex.Message}");
            }
            catch (IOException ex)                  // 写入或读取发生异常抛出
            {
                Console.WriteLine($"错误：IO操作异常 - {ex.Message}");
            }
            catch (Exception ex)                    // 抛出 All 异常
            {
                Console.WriteLine($"未知错误 - {ex.Message}");
            }
            return null; // 发生异常时返回null
        }

        /// <summary>
        /// 写入文件（覆盖现有内容）
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <param name="content">要写入的内容</param>
        public static void WriteFile(string path, string content)
        {
            try
            {
                // 用 using 自动释放 StreamReader 资源
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(content);          // 写入内容
                    Console.WriteLine("文件写入成功！");
                }
            }
            catch (UnauthorizedAccessException ex)  // 权限不足时抛出异常
            {
                Console.WriteLine($"错误：权限不足 - {ex.Message}");
            }
            catch (IOException ex)                  // 写入或读取发生异常抛出
            {
                Console.WriteLine($"错误：IO操作异常 - {ex.Message}");
            }
            catch (Exception ex)                    // 抛出 All 异常
            {
                Console.WriteLine($"未知错误 - {ex.Message}");
            }
        }
    }
}
