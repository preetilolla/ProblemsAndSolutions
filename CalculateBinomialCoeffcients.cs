using System;
using System.Collections.Generic;
using System.Text;

namespace PS
{
	// C(n, k) = n! / (k! * (n - k)!)
	// It is the number of ways to choose a fc-element subset from an n-element set.
	// Can be decomposed into sub problems as C(n, k) = C(n - 1, k) + C(n - 1, k - 1).
	// Dynamic Programming Approach to calculate the coefficients as the sub problems are overlapping.
	// TC = O(nk), SC = O(nk).

	class CalculateBinomialCoefficients
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter n = ");
			int n = Convert.ToInt32(Console.ReadLine());

			Console.Write("\nEnter k = ");
			int k = Convert.ToInt32(Console.ReadLine());

			Console.Write("\nResult = " + GetBinomialCoefficients(n, k));
			Console.ReadKey();
		}

		public static int GetBinomialCoefficients(int n, int k)
		{
			int[,] dp = new int[n + 1, k + 1];
			return ComputeRecursively(n, k, dp);
		}

		static int ComputeRecursively(int n, int k, int[,] dp)
		{
			if (k == 0 || n == k)
			{
				return 1;
			}
			if (dp[n, k] == 0)
			{
				dp[n, k] = ComputeRecursively(n - 1, k - 1, dp) + ComputeRecursively(n - 1, k, dp);
			}
			return dp[n, k];
		}
	}
}
