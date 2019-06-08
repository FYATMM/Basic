using System;
using System.Collections.Generic;
using System.Text;

namespace StructOverrideToString
{
    public struct StStudent
    {
        public string Name { get; set; }
        public string StudentId { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("姓名：{0}；学号：{1}；年龄：{2}", Name, StudentId, Age);
        }
    }
}
