using System;
using System.Collections.Generic;
using System.Text;

namespace UseStructConvertType
{
    public class StructConversation
    {
        public static void ConversationTest()
         {
            RomanNumeral roman;
            BinaryNumeral binary;

            roman = 10;

            // Perform a conversion from a RomanNumeral to a BinaryNumeral:
            //执行从 RomanNumeral 到 BinaryNumeral 的转换。 由于没有从 RomanNumeral 到 BinaryNumeral 的直接转换，
            //所以使用一个转换将 RomanNumeral 转换为 int，并使用另一个转换将 int 转换为 BinaryNumeral。
            binary = (BinaryNumeral)(int)roman;

            // Perform a conversion from a BinaryNumeral to a RomanNumeral:
            // No cast is required:
            //执行从 BinaryNumeral 到 RomanNumeral 的转换。 由于 RomanNumeral 定义了从 BinaryNumeral 的隐式转换，所以不需要转换。
            roman = binary;

            System.Console.WriteLine((int)binary);
            System.Console.WriteLine(binary);

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }
    }
}
