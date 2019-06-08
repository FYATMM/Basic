using System;
/// <summary>
/// “封装字段”重构操作能够从现有字段中快速创建属性，然后通过对新属性的引用无缝更新代码
/// 
/// 当某个 字段是 public 时，其他对象可以直接访问该字段并可对其进行修改，而拥有该字段的对象不会检测到。 通过使用 属性封装该字段，可以禁止对字段的直接访问。
/// 
/// 若要创建新属性，“封装字段”操作会更改想要封装到 private 的字段的访问修饰符，并为该字段生成 get 和 set 访问器。 在某些情况下，仅生成 get 访问器（如当字段声明为只读时）。
/// 
/// 重构引擎将通过对“封装字段”对话框的“更新引用”部分中指定区域中的新属性的引用更新你的代码。
/// 
/// </summary>
namespace EncapsulateField
{
    public class EncapsulateFieldDemo
    {
        private int width;//public int width;
        public int Width { get => width; set => width = value; }
    }
}
