using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 
/// </summary>
namespace StructIsValueType
{
    public class UseStruct
    {
        public static void StructTest()
        {
            Dimensions point1;

            point1.Width = 6.0;
            point1.Length = 3.0;
            Console.WriteLine($" point1's width:{point1.Width}\n point1's length : {point1.Length}\n point1's diagonal : {point1.Diagonal}");

            //与类的new不一样，不分配堆内存，只调用构造函数，并初始化，如果没有传入参数，就初始化为默认值0
            Dimensions point2 = new Dimensions();
            Console.WriteLine($" point2's width:{point2.Width}\n point2's length : {point2.Length}\n point2's diagonal : {point2.Diagonal}");

            //用new传递参数初始化
            Dimensions point4 = new Dimensions(3.0,4.0);
            Console.WriteLine($" point4's width:{point4.Width}\n point4's length : {point4.Length}\n point4's diagonal : {point4.Diagonal}");

            //不使用new操作符时，按变量定义，就必须赋值后才能使用
            //Dimensions point3;
            //Console.WriteLine($" point3's width:{point3.Width}\n point3's length : {point3.Length}\n point3's diagonal : {point3.Diagonal}");
        }
    }
}
