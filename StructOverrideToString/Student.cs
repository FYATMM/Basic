using System;

namespace StructOverrideToString
{
    public class Student
    {
        public static void StudentTest()
        {
            //定义5个Student变量 
            StStudent[] studentArry = new StStudent[5];

            //赋值
            studentArry[0] = new StStudent()
            { Name = "张三", Age = 20, StudentId = "ST0001" };
            studentArry[1] = new StStudent()
            { Name = "李四", Age = 21, StudentId = "ST0002" };
            studentArry[2] = new StStudent()
            { Name = "王五", Age = 22, StudentId = "ST0003" };
            studentArry[3] = new StStudent()
            { Name = "赵六", Age = 22, StudentId = "ST0004" };
            studentArry[4] = new StStudent()
            { Name = "何七", Age = 21, StudentId = "ST0005" };

            //输出
            foreach (var student in studentArry)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
