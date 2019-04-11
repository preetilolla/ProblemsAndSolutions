using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS
{
	// Get nth ugly number. Ugly number is one whose only prime factors are 2, 3, 5.
	class DP_1
	{
		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(getNthUglyNumber(n));
			Console.ReadKey();
		}

		public static int getNthUglyNumber(int n)
		{
			int next = 1;

			int[] ugly = new int[n];
			int i2 = 0, i3 = 0, i5 = 0;
			ugly[0] = 1;
			int nextMultiple2 = 2;
			int nextMultiple3 = 3;
			int nextMultiple5 = 5;

			for (int i = 1; i < n; i++)
			{
				next = Math.Min(nextMultiple2, Math.Min(nextMultiple3, nextMultiple5));
				ugly[i] = next;
				if (next == nextMultiple2)
				{
					i2++;
					nextMultiple2 = ugly[i2] * 2;
				}
				if (next == nextMultiple3)
				{
					i3++;
					nextMultiple3 = ugly[i3] * 3;
				}
				if (next == nextMultiple5)
				{
					i5++;
					nextMultiple5 = ugly[i5] * 5;
				}
			}

			return next;
		}
	}
}

namespace PS
{
    // Dynamic Programming - Get nth ugly number. Ugly number is one whose only prime factors are 2, 3, 5.
    class DP_1
    {
		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(getNthUglyNumber(n));
			Console.ReadKey();
		}

		public static int getNthUglyNumber(int n)
        {
            int next = 1;

            int[] ugly = new int[n];
            int i2 = 0, i3 = 0, i5 = 0;
            ugly[0] = 1;
            int nextMultiple2 = 2;
            int nextMultiple3 = 3;
            int nextMultiple5 = 5;

            for (int i = 1; i < n; i++)
            {
                next = Math.Min(nextMultiple2, Math.Min(nextMultiple3, nextMultiple5));
                ugly[i] = next;
                if (next == nextMultiple2)
                {
                    i2++;
                    nextMultiple2 = ugly[i2] * 2;
                }
                if (next == nextMultiple3)
                {
                    i3++;
                    nextMultiple3 = ugly[i3] * 3;
                }
                if (next == nextMultiple5)
                {
                    i5++;
                    nextMultiple5 = ugly[i5] * 5;
                }
            }

            return next;
        }
    }
}
