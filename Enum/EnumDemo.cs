using System;
using System.Collections.Generic;
using System.Text;

namespace Enum
{
    public class EnumDemo
    {
        public static void EnumTest()
        {
            Console.WriteLine("-----------------------------------枚举常量值-----------------------------------");
            EnumConsColor c1 = EnumConsColor.Blue;
            Console.WriteLine(c1);

            Console.WriteLine("-----------------------------------强制类型转换：数字<->枚举值-----------------------------------");
            EnumConsColor c2 = (EnumConsColor)2;
            Console.WriteLine(c2);
            int number = (int)c2;
            Console.WriteLine(number);

            Console.WriteLine("-----------------------------------枚举的布尔量用法-----------------------------------");
            DaysOfWeek mondayAndWednesday = DaysOfWeek.Monday | DaysOfWeek.Wednesday;
            Console.WriteLine(mondayAndWednesday);
            DaysOfWeek dw = new DaysOfWeek();
            dw = (DaysOfWeek)3;
            Console.WriteLine(dw);

            Console.WriteLine("-----------------------------------枚举类的方法用法-----------------------------------");
            Console.WriteLine("-----------------------------------TryParse-----------------------------------");


            Console.WriteLine("-----------------------------------GetName-----------------------------------");

            Console.WriteLine("-----------------------------------GetValues-----------------------------------");
        }
    }
}
