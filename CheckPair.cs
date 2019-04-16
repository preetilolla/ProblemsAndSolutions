using System;
using System.Linq;
using System.Collections.Generic;

namespace PS
{
    // Given an array A[] and a number x, check for pair in A[] with sum as x. Time Complexity = O(n), Space Complexity = O(n)
    class CheckPair
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Enter n - ");
			int n = Convert.ToInt16(Console.ReadLine());
			int[] arr = new int[n];
			string[] a = Console.ReadLine().Split(' ');
			arr = a.Select(int.Parse).ToArray();
			Console.WriteLine("Enter x = ");
			int x = Convert.ToInt16(Console.ReadLine());
			printPairs(arr, n, x);
			Console.ReadKey();
		}
		static void printPairs(int[] arr, int n, int x)
        {
            HashSet<int> h = new HashSet<int>();
            for(int i = 0; i < n ; i++)
            {
                int t = x - arr[i];
                if(t >= 0 && h.Contains(t))
                {
                    Console.WriteLine("{0}, {1}", arr[i], t);
                }
                h.Add(arr[i]);
            }
        }

    }
}
