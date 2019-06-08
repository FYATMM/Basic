using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 通过值传递引用
/// </summary>
namespace refP
{
    public class ValuesRef
    {
        public static void ValueRefTest(ref int i)
        {
            // Rest the mouse pointer over i to verify that it is an int.
            // The following statement would cause a compiler error if i
            // were boxed as an object.
            i = i + 44;
        }

        public static void ArrChange(int[] pArray)
        {
            pArray[0] = 888;  // This change affects the original element.
            pArray = new int[5] { -3, -1, -2, -3, -4 };   // This change is local.
            System.Console.WriteLine("Inside the method, the first element is: {0}", pArray[0]);
        }

    }
}
