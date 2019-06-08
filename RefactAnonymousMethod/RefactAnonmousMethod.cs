using System;

namespace RefactoringMethod
{
    /// <summary>
    /// 下面的示例阐释这一语义更改。 如果执行此代码，则将向控制台输出 11。 
    /// 如果使用“提取方法”将代码注释所标记的代码区域提取到其自己的方法中，然后执行重构后的代码，则将向控制台输出 10。
    /// </summary>
    public class RefactAnonmousMethod
    {
        delegate void D();
        D d;
        ////重构匿名方法，提取后
        public static void Refactoring()
        {
            RefactAnonmousMethod p = new RefactAnonmousMethod();
            int i = 10;
            /*begin extraction*/
            //p.d = delegate { Console.WriteLine(i++); };
            i = NewMethod(p, i); //p.d = delegate { Console.WriteLine(i++); };
            /*end extraction*/
            i++;
            p.d();
        }

        private static int NewMethod(RefactAnonmousMethod p, int i)
        {
            p.d = delegate { Console.WriteLine(i++); };
            return i;
        }
    }

}
