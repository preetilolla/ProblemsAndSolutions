using System;
using System.Linq;

/*
Given a list of non negative integers, arrange them in such a manner that they form the largest number possible.

3 30 34 5 9 --> 9534330

Input:
*/
public class GFG
{
	static public void Main()
	{
		long n = Convert.ToInt32(Console.ReadLine());
		for (int i = 0; i < n; i++)
		{
			int l = Convert.ToInt32(Console.ReadLine());
			string str = Console.ReadLine();
			string[] s = str.Length == 1 ? new[] { str } : str.Split(' ');
			getLargest(s, l);
		}
	}

	public static void getLargest(string[] a, int n)
	{
		Console.WriteLine();
		Array.Sort(a, (x, y) =>
		{
			string xy = x + y;
			string yx = y + x;
			return String.Compare(xy, yx) > 0 ? -1 : 1;
		});
		for (int i = 0; i < n; i++)
		{
			Console.Write(a[i]);
		}
	}

}

