using System;
using System.Collections.Generic;
using System.Text;

namespace ArrRefOut
{
    public class ArrRefOutTest
    {
        public static void RefOutDifferentTest()
        {
            ////OutTest
            //与所有 out 参数一样，在使用数组类型的 out 参数前必须先为其赋值；即必须由被调用方为其赋值
            int[] theArray1; // Initialization is not required           
            ArrOut.FillArray(out theArray1); // Pass the array to the callee using out:            
            Console.WriteLine("Array elements are:");// Display the array elements:
            for (int i = 0; i < theArray1.Length; i++)
            {
                Console.Write(theArray1[i] + " ");
            }

            Console.WriteLine();

            ////RefTest
            //与所有 ref 参数一样，数组类型的 ref 参数必须由调用方明确赋值。 因此，不需要由被调用方明确赋值。 
            //可以将数组类型的 ref 参数更改为调用的结果。 例如，可以为数组赋以 null 值，或将其初始化为另一个数组。
            int[] theArray2 = { 1, 2, 3, 4, 5 };// Initialize the array:
            ArrRef.FillArray(ref theArray2);// Pass the array using ref:            
            Console.WriteLine("Array elements are:");// Display the updated array:
            for (int i = 0; i < theArray2.Length; i++)
            {
                Console.Write(theArray2[i] + " ");
            }

        }
    }
}
