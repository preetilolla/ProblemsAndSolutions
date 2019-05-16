using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PS
{
	class EquilibriumPointInArray
	{
		// Equilibrium Point = An index such that the sum of elements at lower indexes is equal to the sum of elements at higher indexes.
		static public void Main()
		{
			Console.Write("Enter array elements - ");
			string str = Console.ReadLine();
			int[] arr = str.Split(' ').Select(int.Parse).ToArray();
			int n = arr.Length;
			int i = 0, j = n - 1;
			int leftSum = 0, rightSum = 0;
			for (i = 0; i < n; i++)
			{
				leftSum += arr[i];
				rightSum += arr[j];
				if (leftSum == rightSum)
				{
					Console.WriteLine("Equilibrium point = " + (i + 1));
					break;
				}
				j--;
			}
			Console.ReadKey();
		}
	}
}
