using System;
using System.Collections.Generic;
using System.Text;

namespace refP
{
   public class SwappingStrings
    {
        public static void Swap(ref string s1, ref string s2)
        // The string parameter is passed by reference.
        // Any changes on parameters will affect the original variables.
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
            System.Console.WriteLine("Inside the method: {0} {1}", s1, s2);
        }

    }
}
