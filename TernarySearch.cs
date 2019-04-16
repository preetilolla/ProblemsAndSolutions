using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PS
{
    // Apply Ternary Search to Unimodal function to get the value of x for which f(x) is minimum.
    class TernarySearch
    {
		public static void Main(string[] args)
		{
			int n;
			n = Convert.ToInt32(Console.ReadLine());
			string[] i = Console.ReadLine().Split(' ');
			double l = Convert.ToDouble(i[0]);
			double r = Convert.ToDouble(i[1]);
			Console.WriteLine(ts(l, r));
			Console.ReadKey();
		}

		static double func(double x)
        {
            return 2 * x * x - 12 * x + 7; // f(x)
        }

        static double ts(double start, double end)
        {
            double l = start, r = end;

            for (int i = 0; i < 200; i++)
            {
                double l1 = (l * 2 + r) / 3;
                double l2 = (l + 2 * r) / 3;
                if (func(l1) < func(l2))
                {
                    r = l1;
                }
                else
                {
                    l = l2;
                }
            }

            double x = l;
            return func(x);
        }
    }
}
