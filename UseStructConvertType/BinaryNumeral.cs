using System;
using System.Collections.Generic;
using System.Text;

namespace UseStructConvertType
{
    public struct BinaryNumeral
    {
        private int value;

        public BinaryNumeral(int value)  //constructor
        {
            this.value = value;
        }

        static public implicit operator BinaryNumeral(int value)
        {
            return new BinaryNumeral(value);
        }

        static public explicit operator int(BinaryNumeral binary)
        {
            return (binary.value);
        }

        static public implicit operator string(BinaryNumeral binary)
        {
            return ("Conversion to string is not implemented");
        }

    }
}
