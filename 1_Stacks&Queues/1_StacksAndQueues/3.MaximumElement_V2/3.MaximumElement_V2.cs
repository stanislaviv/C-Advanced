using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MaximumElement_V2
{
	class Program
	{
		static void Main(string[] args)
		{
			int commandsCount = int.Parse(Console.ReadLine());

			Stack<int> numbers = new Stack<int>();
			Stack<int> maxNumbers = new Stack<int>();

			maxNumbers.Push(int.MinValue);

			for (int i = 0; i < commandsCount; i++)
			{
				var command = Console.ReadLine().Split().Select(int.Parse).ToArray();

				switch (command[0])
				{
					case 1:
						var element = command[1];
						numbers.Push(element);

						if (element >= maxNumbers.Peek())
						{
							maxNumbers.Push(element);
						}
						break;

					case 2:
						var poppedElement = numbers.Pop();
						if (maxNumbers.Peek() == poppedElement)
						{
							maxNumbers.Pop();
						}
						break;

					case 3:
						int maxElement = maxNumbers.Peek();
						Console.WriteLine(maxElement);
						break;
				}


			}
		}
	}
}
