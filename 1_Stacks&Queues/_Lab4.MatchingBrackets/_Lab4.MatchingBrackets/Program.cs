using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab4.MatchingBrackets
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Stack<int> indices = new Stack<int>();

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i].Equals('('))
				{
					indices.Push(i);
				}
				else if (input[i].Equals(')'))
				{
					int startIndex = indices.Pop();
					string result = input.Substring(startIndex, i - startIndex);
					Console.WriteLine(result);
				}
			}
		}
	}
}
