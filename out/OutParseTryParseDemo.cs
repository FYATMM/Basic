using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 返回多个值的3个方法
/// 1.把要返回的所有信息，定义为一个类或结构的成员
/// 2.使用元组类型
/// 3.使用out关键字
/// </summary>
namespace outP
{
    public class OutParseTryParseDemo
    {
        public static void ParseOutTest()
        {
            ParseOut.ParseTest();
            ParseOut.ParseTryCatchTest();
            ParseOut.TypParseOut();
        }
    }
}
