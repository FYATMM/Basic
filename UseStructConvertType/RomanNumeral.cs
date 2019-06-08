using System;
using System.Collections.Generic;
using System.Text;

namespace UseStructConvertType
{
    public struct RomanNumeral
    {
        private int value;

        public RomanNumeral(int value)  //constructor
        {
            this.value = value;
        }

        static public implicit operator RomanNumeral(int value)
        {
            return new RomanNumeral(value);
        }

        static public implicit operator RomanNumeral(BinaryNumeral binary)
        {
            return new RomanNumeral((int)binary);
        }

        static public explicit operator int(RomanNumeral roman)
        {
            return roman.value;
        }

        static public implicit operator string(RomanNumeral roman)
        {
            return ("Conversion to string is not implemented");
        }

    }
}
