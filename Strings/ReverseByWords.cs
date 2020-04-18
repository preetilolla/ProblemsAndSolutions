using System;
using System.Text;
public class GFG
{
	static public void Main()
	{
		int t = Convert.ToInt32(Console.ReadLine());
		for (int i = 0; i < t; i++)
		{
			reverseByWords(Console.ReadLine());
		}
		Console.ReadKey();
	}
	static void reverseByWords(string str)
	{
		int start = 0, end = 0;
		
		StringBuilder sb = new StringBuilder(str);
		string s = string.Empty;
		for (int i = 0; i < str.Length; i++)
		{
			if (str[i] == '.')
			{
				end = i;
				s = reverseString(str.Substring(start, end - start));
				sb.Remove(start, end - start);
				sb.Insert(start, s);
				start = i + 1;
			}
			if(i == str.Length - 1)
			{
				s = reverseString(str.Substring(start, i - start + 1));
				sb.Remove(start, i - start + 1);
				sb.Insert(start, s);
			}
		}
		
		char[] arr = sb.ToString().ToCharArray();

		Array.Reverse(arr);

		Console.WriteLine(arr);
	}
  
	static string reverseString(string s)
	{
		char[] arr = s.ToCharArray();
		Array.Reverse(arr);
		return new string(arr);
	}
}
