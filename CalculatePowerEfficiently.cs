using System;
using System.Collections.Generic;
using System.Text;

namespace PS
{
	class PowerXNEfficiently
	{
		public static void Main(string[] args)
		{
			float x = Convert.ToInt32(Console.ReadLine());
			int n = Convert.ToInt32(Console.ReadLine());

			// Console.WriteLine(power(x, n));
			Console.WriteLine(powerIterative(x, n));
			Console.ReadKey();
		}

		static float powerIterative(float x, int y)
		{
			float res = 1; // Initialize result 

			while (y > 0)
			{
				// If y is odd, multiply 
				// x with result 
				if ((y & 1) == 1)
				{
					res = res * x;
				}

				// n must be even now 
				y = y >> 1; // y = y/2 
				x = x * x; // Change x to x^2 
			}
			return res;
		}

		static float power(float x, int y)
		{
			float temp;
			if (y == 0)
			{
				return 1;
			}
			temp = power(x, y / 2);
			if (y % 2 == 0)
			{
				return temp * temp;
			}
			else
			{
				if (y > 0)
				{
					return x * temp * temp;
				}
				else
				{
					return (temp * temp) / x;
				}
			}
		}
	}
}
