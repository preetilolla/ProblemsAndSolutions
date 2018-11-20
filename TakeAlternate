using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PS
{
	// Use Linq to take alternate numbers and write them to a CSV.
    class TakeAlternate
    {
		static void Main(string[] args)
		{
			var numbers = Enumerable.Range(0, 10);
			StringBuilder sb = new StringBuilder();
			var r = numbers.Where((t, i) => i % 2 == 0).Select(x => x);
			foreach(var i in r)
			{
				sb.Append(Convert.ToString(i));
			}
			// Write sb to a .csv using File.WriteAllText().
			Console.ReadKey();
		}
    }
}
