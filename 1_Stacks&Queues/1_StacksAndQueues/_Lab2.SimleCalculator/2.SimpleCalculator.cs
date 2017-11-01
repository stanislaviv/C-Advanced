using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab2.SimleCalculator
{
	class SimpleCalculator
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(' ');
			Stack<string> stack = new Stack<string>(input.Reverse());



			while (stack.Count > 2)
			{
				var firstNumber = int.Parse(stack.Pop());
				var oper = stack.Pop();
				var secondNumber = int.Parse(stack.Pop());

				switch (oper)
				{
					case "+":
						stack.Push((firstNumber+secondNumber).ToString());
						break;

					case "-":
						stack.Push((firstNumber-secondNumber).ToString());
						break;

				}

			}

			Console.WriteLine(stack.Pop());
			


		}
	}
}
