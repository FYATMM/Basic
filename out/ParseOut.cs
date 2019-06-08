using System;
using System.Collections.Generic;
using System.Text;

namespace outP
{
    /// <summary>
    /// 通过值类型的Parse方法，当用户输入数字的时候，返回该数字
    /// 但是如果用户输入的没有数字，就会抛出异常，可以捕获异常进行处理
    /// 也可以用TryParse方法，解析成功就通过out返回一个参数，并返回解析成功与否的bool值
    /// </summary>
    public class ParseOut
    {
        //直接使用Parse，不是期望的数据类型，抛出异常
        public static void ParseTest()
        {
            Console.WriteLine("Parse测试，请输入数字：");
            string input1 = Console.ReadLine();            
            int n = int.Parse(input1);            
            Console.WriteLine($"n:{n}");
        }

        //通过TryCatch处理异常
        public static void ParseTryCatchTest()
        {
            Console.WriteLine("Parse TryCatch测试，请输入数字：");
            string input1 = Console.ReadLine();
            
            try
            {
                int n = int.Parse(input1);
                Console.WriteLine($"n:{ n }");
            }
            catch
            {
                Console.WriteLine("not a number");
            }         
        }

        //c#简化这个过程，提供了解析成功与否的返回值，可以用来处理
        public static void TypParseOut()
        {
            Console.WriteLine("TryParse测试，请输入数字：");
            string input2 = Console.ReadLine();
            int result;
            
            if (int.TryParse(input2, out result))
            {
                Console.WriteLine($"n:{ result }");
            }
            else
            {
                Console.WriteLine("not a number");
            }
        }
    }
}
