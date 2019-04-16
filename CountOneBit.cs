using System;
using System.ComponentModel;

namespace CountOneBit
{
    class CountOneBit
    {
        static void Main(string[] args)
        {
            uint num = 55052;
           
            string bitString = Convert.ToString(num, 2).PadLeft(32, '0');
            Console.WriteLine("Number=" + num + ", binary="+bitString);
            Console.WriteLine("Got " + CountBit(num) + " one bit(s).");
        }

        public static int CountBit(uint n)
        {
            int result = 0;
            for (var i = 0; i < 32; i++)
            {
                uint val = (uint)Math.Pow(2, i);
                if ((n & val) > 0)
                    result += 1;

            }
            return result;
        }
    }
}
//////////////////////////////////////////////////////////////
//
// Sample run:
//
// Number=55052, binary=00000000000000001101011100001100
// Got 8 one bits.
