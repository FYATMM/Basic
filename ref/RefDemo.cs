using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 
/// 通过引用传递的效果是，对所调用方法中的参数进行的任何更改都反映在调用方法中。 例如，如果调用方传递本地变量表达式或数组元素访问表达式，
/// 所调用方法会将对象替换为 ref 参数引用的对象，然后调用方的本地变量或数组元素将开始引用新对象。
/// 
/// 当通过引用传递时，不会对值类型装箱。
/// 
/// 若要使用 ref 参数，方法定义和调用方法均必须显式使用 ref 关键字
/// 
/// 传递到 ref 形参的实参必须先经过初始化，然后才能传递。 这与 out 形参不同
/// 
/// 类的成员不能具有仅在 ref 和 out 方面不同的签名。 如果类型的两个成员之间的唯一区别在于其中一个具有 ref 参数，而另一个具有 out 参数，则会发生编译错误。
/// 但是，当一个方法具有 ref 或 out 参数，另一个方法具有值参数时，则可以完成重载
/// 
/// 属性不是变量。 它们是方法，不能传递到 ref 参
/// 
/// 你不能将 ref 和 out 关键字用于以下几种方法：
/// 异步方法，通过使用 async 修饰符定义。
/// 迭代器方法，包括 yield return 或 yield break 语句。
/// </summary>
namespace refP
{
    public class RefDemo
    {
        public static void RefTest()
        {
            //值传递引用类型参数
            int val = 1;
            ValuesRef.ValueRefTest(ref val);
            Console.WriteLine(val);

            Console.WriteLine();

            //通过值传递引用类型
            //由于该参数是对 arr 的引用，所以有可能更改数组元素的值。 但是，尝试将参数重新分配到不同的内存位置时，该操作仅在方法内有效，并不影响原始变量 arr。
            //在上个示例中，数组 arr 为引用类型，在未使用 ref 参数的情况下传递给方法。 在此情况下，将向方法传递指向 arr 的引用的一个副本。 输出显示方法有可能更改数组元素的内容，在这种情况下，从 1 改为 888。 
            //但是，在 Change 方法内使用 new 运算符来分配新的内存部分，将使变量 pArray 引用新的数组。 因此，这之后的任何更改都不会影响原始数组 arr（它是在 Main 内创建的）。
            //实际上，本示例中创建了两个数组，一个在 Main 内，一个在 Change 方法内。
            int[] arr = { 1, 4, 5 };
            Console.WriteLine("Inside Main, before calling the method, the first element is: {0}", arr[0]);
            ValuesRef.ArrChange(arr);
            Console.WriteLine("Inside Main, after calling the method, the first element is: {0}", arr[0]);

            Console.WriteLine();

            //引用类型的引用
            //ref 关键字添加到方法标头并调用。 在方法影响出现在调用过程的原始变量的任何更改。
            //方法内发生的所有更改都影响 Main 中的原始数组。 实际上，使用 new 运算符对原始数组进行了重新分配。 因此，调用 Change 方法后，对 arr 的任何引用都将指向 Change 方法中创建的五个元素的数组。
            System.Console.WriteLine("Inside Main, before calling the method, the first element is: {0}", arr[0]);
            ClassRef.RefArrChange(ref arr);
            System.Console.WriteLine("Inside Main, after calling the method, the first element is: {0}", arr[0]);

            Console.WriteLine();

            //引用类型的引用
            // Declare an instance of Product and display its initial values.
            RefProduct item = new RefProduct("Fasteners", 54321);
            Console.WriteLine("Original values in Main.  Name: {0}, ID: {1}\n",item.ItemName, item.ItemID);

            // Send item to ChangeByReference as a ref argument.
            ClassRef.ChangeByReference(ref item);
            Console.WriteLine("Back in Main.  Name: {0}, ID: {1}\n", item.ItemName, item.ItemID);

            //交换字符串是通过引用传递引用类型参数的很好的示例
            string str1 = "John";
            string str2 = "Smith";
            Console.WriteLine("Inside Main, before swapping: {0} {1}", str1, str2);

            SwappingStrings.Swap(ref str1, ref str2);   // Passing strings by reference
            Console.WriteLine("Inside Main, after swapping: {0} {1}", str1, str2);

        }



    }
}
