using System;
using System.Collections.Generic;
using System.Text;

namespace ArrRefOut
{
    public class ArrRef
    {
        public static void FillArray(ref int[] arr)
        {
            // Create the array on demand:
            if (arr == null)
            {
                arr = new int[10];
            }
            // Fill the array:
            arr[0] = 1111;
            arr[4] = 5555;            
        }

    }
}
