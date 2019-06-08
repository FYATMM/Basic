using System;
using System.Collections.Generic;
using System.Text;

namespace Enum
{
    //设置Flags属性，把多个选项分配给一个变量，而不仅仅是一个枚举常量，分配给常量的值必须是不同的位
    //[Flags]
    public enum DaysOfWeek
    {
        Monday = 0x1,
        Tuesday = 0x2,
        Wednesday = 0x04,
        Tursday = 0x08,
        Friday = 0x10,
        Saturday = 0x20,
        Sunday = 0x40,

        //单个位来包括多个值
       Weekend = Saturday | Sunday,
       WorkDay = 0x1f,
        AllWeek = WorkDay | Weekend
    }
}
