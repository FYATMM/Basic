using System;
/// <summary>
/// 引用类型有null值，但是值类型不能为空
/// 有些情况有问题，比如数据库中
/// java使用映射，把数据库的值类型映射为引用类型；但是引用类型需要垃圾收集器清理，额外的开销
/// C#使用可控类型，是值类型，但是必须是结构，用户自定义的结构也可以使用可控类型
/// 唯一的开销是一个判断它是否为空的bool量
/// 
/// VS:
/// 可以为 null 的类型表示可被赋值为 null 值的值类型变量。 无法创建基于引用类型的可以为 null 的类型。 （引用类型已支持 null 值。）
/// 语法 T? 是 Nullable<T> 的简写，此处的T 为值类型。 这两种形式可以互换。
/// 为可以为 null 的类型赋值的方法与为一般值类型赋值的方法相同，如 int? x = 10; 或 double? d = 4.108。 对于可以为 null 的类型，也可向其赋 null: int? x = null.值
/// 如果基础类型的值为 null，请使用 Nullable<T>.GetValueOrDefault 方法返回该类型所赋的值或默认值，例如 int j = x.GetValueOrDefault();
/// 将 HasValue 和 Value 只读属性用于测试是否为空和检索值，如下面的示例所示：if(x.HasValue) j = x.Value;
/// 如果此变量包含值，则 HasValue 属性返回 true；或者如果是 null 则返回 false。
/// 如果已赋值，则 Value 属性返回该值。 否则，将引发 System.InvalidOperationException。
/// HasValue 的默认值为 false。 Value 属性没有默认值。
/// 还可以将 == 和 != 操作数用于可为 null 的类型，如下面的示例所示：if (x != null) y = x;
/// 使用 ?? 算符分配默认值，在将当前值为 null 的可以为 null 的类型赋值给不可以为 null 的类型时，将应用该默认值，如 int? x = null; int y = x ?? -1;
/// 不允许使用嵌套的可以为 null 的类型。 将不编译下面一行：Nullable<Nullable<int>> n;
/// 
/// 在对可以为 null 的类型执行比较时，如果其中一个可以为 null 的类型的值为 null，但另外一个类型的值不为 null，则除 !=（不等于）外，所有比较的结果都将为 false。 
/// 一定不要以为由于一个特定比较的结果为 false，相反的情况就会为 true。 在以下示例中，10 不大于、小于或等于 null。 只有 num1 != num2 的计算结果为 true。
/// 
/// 这是不允许的，因为 null 在条件上下文中的含义并不清楚。 若要在条件语句中使用 bool?，请首先检查其 HasValue 属性以确保其值不是 null，然后将它强制转换为 bool。 
/// 有关更多信息，请参见 bool。 如果对使用 null 值的 bool? 执行强制转换，则在条件测试中将引发 InvalidOperationException。
/// 
///不能使用 GetType 方法或 is 运算符在运行时获得可以为 null 的类型变量的类型信息，得到的结果是表示基础类型而不是可以为 null 的类型本身的 Type 对象。
///可以为 null 的类型调用 GetType，则在该类型被隐式转换为 Object 时将执行装箱操作。 因此， GetType 总是返回表示基础类型而不是可以为 null 的类型的 Type 对象。
///
/// </summary>
namespace NullForValues
{
    public class NullableType
    {
        public static void NullableTest()
        {
            int x1 = 1;
            Console.WriteLine($"x1:{x1}");
            //可控类型可以赋值为null
            int? x2 = null;
            Console.WriteLine($"x2:{x2}");
            //int可以赋值给int？
            int? x3 = x1;
            Console.WriteLine($"x3:{x3}");
            //但是int？不能赋值给int，需要类型转换
            int x4 = (int)x3;
            Console.WriteLine($"x4:{x4}");

            //己：
            Console.WriteLine("可控类型测试，请输入数字");
            string input = Console.ReadLine();
            int result;
            int? y = null;
            if (int.TryParse(input, out result))
            {
                y = result;
                Console.WriteLine("输入数字正确");
            } else if (y== null)
            {
                Console.WriteLine("输入为空值null");
            }
           

            //如果类型转换时x3为null，会抛出异常
            //使用可控类型的HasValue和Value属性
            int x5;
            if (y.HasValue)
            {
                x5 = y.Value;
            }
            else
            {
                x5 = -1;
            }
            Console.WriteLine($"x5:{x5}");
            //if else简化
            int x6 = y.HasValue ? y.Value : -1;
            Console.WriteLine($"x6:{x6}");
            //C#帮我们简化了，合并了操作符，使用？？
            int x7 = y ?? -1;
            Console.WriteLine($"x7:{x7}");

            //此运算符还可用于多个可以为 null 的类型
            int? e = null;
            int? f = null;
            
            // g = e or f, unless e and f are both null, in which case g = -1.如果e为空，找f，f也为空就返回默认值-1
            int g = e ?? f ?? -1;
            Console.WriteLine(g);

            //安全地将 bool? 强制转换为 bool
            //bool? 类型不能用于条件语句，如 if、for 或 while。
            bool? test = null;
            // Other code that may or may not
            // give a value to test.
            if (!test.HasValue) //check for a value
            {
                // Assume that IsInitialized
                // returns either true or false.
                test = true;
            }
            if ((bool)test) //now this cast is safe
            {
                Console.WriteLine("这样才能把可为null的bool类型安全转化为bool类型，才能用于条件语句");
            }

            //使用下面的代码来确定 Type 对象是否表示可以为 null 的类型。
            System.Type type = typeof(int?);
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                Console.WriteLine("这样才能准确判断是不是可为null的int类型");
            }


        }
    }
}
