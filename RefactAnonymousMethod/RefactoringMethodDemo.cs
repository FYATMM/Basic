using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 
/// 分部类型
/// 如果类是分部类型，则“提取方法”将紧跟源成员之后生成新方法。 “提取方法”确定新方法的签名，并在新方法中的代码不引用实例数据时创建静态方法。
/// 
/// 泛型类型参数
/// 当您提取的方法具有不受约束的泛型类型参数时，除非已为该参数赋值，否则生成的代码将不向该参数添加 ref 修饰符。 如果提取的方法将支持引用类型作为泛型类型实参，
/// 则应该向方法签名中的形参手动添加 ref 修饰符。
/// 
/// 匿名方法
/// 如果您尝试提取匿名方法（该方法包括对在匿名方法之外声明或引用的局部变量的引用）的一部分，则 Visual Studio 将警告您可能有语义更改。
/// 当匿名方法使用局部变量的值时，将在执行匿名方法时获取该值。 将匿名方法提取到其他方法中时，将在调用提取方法时获取局部变量的值。
/// 
/// </summary>
namespace RefactoringMethod
{
    public class RefactoringMethodDemo
    {
        public static void RefactoringMethodTest()
        {
            RefactAnonmousMethod.Refactoring();
        }
    }
}
