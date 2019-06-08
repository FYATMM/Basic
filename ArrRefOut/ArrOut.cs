using System;
using System.Collections.Generic;
using System.Text;

namespace ArrRefOut
{
    public class ArrOut
    {
        public static void FillArray(out int[] arr)
        {
            // Initialize the array:
            arr = new int[5] { 1, 2, 3, 4, 5 };
        }

    }
}
