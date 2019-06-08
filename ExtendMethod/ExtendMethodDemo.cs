using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 扩展类的方式：
/// 1.继承
/// 2.扩展方法（类是密封的）
/// </summary>
////LINQ中用了许多扩展方法
///<summary>
///扩张方法也可以用于扩展接口
///
/// 必须是静态的，是类的一部分，但实际上没有放在类的源代码中
/// 
/// 关键字this定义了要扩展的类型
/// 
/// 虽然是静态方法，但是使用和标准的实例方法的语法一致。
/// 这么做的好处是，更容易调用的语法
/// 另一个好处是，该方法的实现可以用另一个类取代，而不需要更改代码，只需要运行新的编译器
/// 
/// 编译器如何找到扩展方法呢：this关键字指定的类型去匹配：
/// 如果有同名的实例方法，扩展方法永远不会被调用；
/// 在命名空间中找，如果多个打开的命名空间有相同的扩展方法，报错
/// 如果调用代码在一个名称空间中，这个名称空间最优
///</summary>
namespace ExtendMethod
{
    public class ExtendMethodDemo
    {
        public static void ExtendMethodTest()
        {
            string fox = "the quick brown fox jumped over the lazy dogs down " + "987654321 times";
            int wodCount = fox.GetWordCount();
            Console.WriteLine($"{wodCount} words");
        }
     
    }
}
