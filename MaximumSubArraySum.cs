using System;

// Dynamic Programming Problem
public static class MaximumSubArraySum
{
	public static int MaxSequence(int[] arr)
	{
		int current = 0, max = 0;
		for (int i = 0; i < arr.Length; i++)
		{
			if (current + arr[i] < 0)
			{
				current = 0;
			}
			else
			{
				current += arr[i];
				max = Math.Max(max, current);
			}
		}
		return max;
	}
}
