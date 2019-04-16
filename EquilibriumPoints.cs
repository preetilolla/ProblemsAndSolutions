using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PS
{
	class EquilibriumPoints
	{
		static public void Main()
		{
			long n = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				int l = Convert.ToInt32(Console.ReadLine());
				string str = Console.ReadLine();
				string[] s = str.Length == 1 ? new[] { str } : str.Split(' ');
				Console.WriteLine(getEP(s, l));
			}
			Console.ReadKey();
		}

		public static long getEP(string[] a, int n)
		{
			int[] arr = a.Select(int.Parse).ToArray();
			long lsum = arr[0], rsum = arr[n - 1], l = 0, r = n - 1;

			if (lsum == rsum)
			{
				return n;
			}
			l++;
			r--;
			while (l != r)
			{
				if (lsum > rsum)
				{
					rsum += arr[r];
					r--;
				}
				else if (lsum < rsum)
				{
					lsum += arr[l];
					l++;
				}
				else
				{
					break;
				}
			}
			return l + 1;
		}
	}
}
