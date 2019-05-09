using System;
using System.Collections.Generic;
using System.Text;

namespace PS
{
    class ReverseBitsOfANumber
    {
		public static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());

			// Console.WriteLine(power(x, n));
			Console.WriteLine(reverseBits(n));
			Console.ReadKey();
		}

		public static int reverseBits(int num)
        {
            uint x = unchecked((uint)num);
            uint y = 0;
            while (x != 0)
            {
                y <<= 1;    // Shift accumulated result left
                y |= x & 1; // Set the least significant bit if it is set in the input value
                x >>= 1;    // Shift input value right
            }
            return unchecked((int)y);
        }
    }
}
