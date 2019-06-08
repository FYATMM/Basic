using System;

namespace ExtendMethod
{
    /// <summary>
    /// 希望用一个方法扩展string类型
    /// 计算字符个数:
    /// GetWordCount方法利用String.Split方法把字符串分割到字符串数组中，
    /// 使用Length属性计算数组中元素的个数
    /// </summary>
    public static class ExtandString
    {
        /// <summary>
        /// 关键字this定义了要扩展的类型
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int GetWordCount(this string s) => s.Split().Length;
    }
}
