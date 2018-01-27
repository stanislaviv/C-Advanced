using System;
using System.Collections.Generic;


namespace _1.ReverseNumberStack
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(' ');
			Stack<string> stack = new Stack<string>(input);

			while (stack.Count > 0)
			{
				Console.Write(stack.Pop()+" ");
			}

			Console.WriteLine();
		}
	}
}
