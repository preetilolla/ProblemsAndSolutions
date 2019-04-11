using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PS
{
	// Given an array where every element occurs three times, except one element which occurs only once. Find the element that occurs once. 
	// Time complexity is O(n) and O(1) extra space.
	class UniqueNumber
	{
		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] arr = Console.ReadLine().Split(' ');
			int[] a = arr.Select(s => int.Parse(s)).ToArray();

			Console.WriteLine(getUnique(a));
			Console.ReadKey();
		}
		public static int getUnique(int[] a)
		{
			int u = a[0];
			for (int i = 1; i < a.Length; i++)
			{
				u = u ^ a[i];
			}
			return u;

		}

	}
}
