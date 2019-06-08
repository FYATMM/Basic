using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 类把数据封装起来，存储在堆中，是引用类型
/// 这给数据的生存期提供了很大的灵活性，但是损失性能；但是有托管堆的优化，损失较小
/// 
/// 有时仅需要一个小的数据结构，类提供的功能多了，性能也下降；这时使用结构
/// 
/// 类一般字段都是私有的，通过属性来封装，除了const字段
/// 
/// 结构内容比较简单，也不需要类的全部功能；
/// 不需要很多方法，不要继承，也不想损失性能；只是存储
/// 
/// 构造函数与方法的定义与类完全一样，但是不支持继承
/// 
///VS:
/// 在结构声明中，除非字段被声明为 const 或 static，否则无法初始化。
/// 结构不能声明默认构造函数（没有参数的构造函数）或析构函数。
////注意：从6.0开始可以了
/// 注意：结构在赋值时进行复制。 将结构赋值给新变量时，将复制所有数据，并且对新副本所做的任何修改不会更改原始副本的数据。 在使用值类型的集合（如 Dictionary<string, myStruct>）时，请务必记住这一点。
////注意：所以结构主要用于小的数据结构
////注意：所以把结构作为参数传递给方法时用ref传递，减少性能损失
////注意：但是，被调用的方法可以改变结构的值
/// 结构是值类型，而类是引用类型。
/// 与类不同，结构的实例化可以不使用 new 运算符。
/// 结构可以声明带参数的构造函数。
/// 一个结构不能从另一个结构或类继承，而且不能作为一个类的基。 所有结构都直接继承自 System.ValueType，后者继承自 System.Object。所以可以用object的方法，比如ToString
/// 结构可以实现接口。
/// 结构可用作可以为 null 的类型，因而可向其赋 null 值。
/// </summary>
namespace StructIsValueType
{
    public struct Dimensions
    {
        public double Length;
        public double Width;

        public Dimensions(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Diagonal => Math.Sqrt(Length*Length + Width*Width);
    }
}
