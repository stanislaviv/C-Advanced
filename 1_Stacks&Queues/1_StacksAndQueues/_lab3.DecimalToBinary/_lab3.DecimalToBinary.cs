using System;
using System.Collections.Generic;

namespace _lab3.DecimalToBinary
{
	class Program
	{
		static void Main(string[] args)
		{
			int input = int.Parse(Console.ReadLine());
			Stack<int> stack = new Stack<int>();

			if (input > 0)
			{
				while (input != 0)
				{
					int reminder = input % 2;
					stack.Push(reminder);
					input /= 2;
				}

				while (stack.Count!=0)
				{
					Console.Write(stack.Pop());
				}

				Console.WriteLine();
			}
			else
			{
				Console.WriteLine(0);
			}


		}
	}
}
