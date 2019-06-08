using System;
/// <summary>
/// “重命名”是 Visual Studio 集成开发环境 (IDE) 中的一项重构功能，
/// 为重命名代码符号（如字段、局部变量、方法、命名空间、属性和类型）的标识符提供了一种简单的方法。 “
/// 重命名”功能可用来更改注释和字符串中的名称，还可用于更改标识符的声明和调用。
/// 
/// ***在使用 Visual Studio 的“源代码管理”时，请在尝试执行重命名重构前，获取最新版本的源文件。
/// 
/// 重命名已实现或已重写的成员
/// 对于实现/重写其他类型中成员的成员，或者由其他类型中的成员实现/重写的成员，“重命名”这些成员时，Visual Studio 会显示一个对话框，
/// 说明该重命名操作将导致级联更新。 如果单击“继续”，则重构引擎将递归查找并重命名相应基类型和派生类型中的所有成员，这些基类型和派生类型与要重命名的成员之间存在实现/重写关系。
/// 
/// 重命名匿名类型的属性
/// 重命名匿名类型中的属性时，重命名操作将传播到具有相同属性的其他匿名类型中的属性。
/// var a = new { ID = 1};
/// var b = new { ID = 2 };
/// 在前面的代码中，重命名 ID 会同时更改两个语句中的 ID，因为两者的基础匿名类型相同。
///var companyIDs = from c in companylist  select new { ID = c.ID, Name = c.Name };
///var orderIDs = from o in orderlist select new { ID = o.ID, Item = o.Name };
///在前面的代码中，重命名 ID 只会重命名 ID 的一个实例，因为 companyIDs 和 orderIDs 的属性不同。
///
/// </summary>
namespace RefactoringName
{
    /// <summary>
    /// 在上面的示例中，重命名 C.Method() 也将重命名 Ibase.Method()，这是因为 C.Method() 实现 Ibase.Method()。 
    /// 接着，重构引擎通过递归查找发现 Ibase.Method() 是由 Derived.Method() 实现的，因此将重命名 Derived.Method()。 
    /// 重构引擎不会重命名 Base.Method()，因为 Derived.Method() 并不重写 Base.Method()。 
    /// 如果在“重命名”对话框没有选中“重命名重载”，则重构引擎将到此停止。
    /// 
    /// *要想显示出，重命名重载，必须在有重载的声明的地方重命名
    /// 
    /// 如果选中了“重命名重载”，则重构引擎将重命名 
    /// Derived.Method(int i)（因为它重载 Derived.Method()）、
    /// Base.Method(int i)（因为它由 Derived.Method(int i) 重载）
    /// 和 Base.Method()（因为它是 Base.Method(int i) 的重载方法）。
    /// </summary>
    public class RefactoringNameDemo
    {
    }
}
