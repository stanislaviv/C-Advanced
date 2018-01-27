using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BasicStackOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] parameters = Console.ReadLine().Split(' ');
			int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			Stack<int> stack = new Stack<int>(numbers);

			int numbersToBePopped = int.Parse(parameters[1]);
			int numberToBeChecked = int.Parse(parameters[2]);

			for (int i = 0; i < numbersToBePopped; i++)
			{
				stack.Pop();
			}

			if (stack.Count > 0)
			{
				if (stack.Contains(numberToBeChecked))
				{
					Console.WriteLine("true");
				}
				else
				{
					Console.WriteLine(stack.Min());
				}
			}
			else
			{
				Console.WriteLine(0);
			}


		}
	}
}
