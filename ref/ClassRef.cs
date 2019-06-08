using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 通过引用传递因引用
/// 
/// 通过引用传递引用类型可以使所调用方法将对象替换为引用参数所引用的对象。 对象的存储位置按引用参数的值传递到方法。 
/// 如果更改参数存储位置中的值（以指向新对象），你还可以将存储位置更改为调用方所引用的位置。
/// </summary>
namespace refP
{
    public class ClassRef
    {
        public static void ChangeByReference(ref RefProduct itemRef)
        {
            //如果更改参数存储位置中的值（以指向新对象），你还可以将存储位置更改为调用方所引用的位置。
            //新建了一个对象，把引用指向新的地址
            // The following line changes the address that is stored in  
            // parameter itemRef. Because itemRef is a ref parameter, the
            // address that is stored in variable item in Main also is changed.
            itemRef = new RefProduct("Stapler", 99999);

            // You can change the value of one of the properties of
            // itemRef. The change happens to item in Main as well.
            itemRef.ItemID = 12345;
        }

        public static void RefArrChange(ref int[] pArray)
        {
            // Both of the following changes will affect the original variables:
            pArray[0] = 888;
            pArray = new int[5] { -3, -1, -2, -3, -4 };
            System.Console.WriteLine("Inside the method, the first element is: {0}", pArray[0]);

        }
    }
}
