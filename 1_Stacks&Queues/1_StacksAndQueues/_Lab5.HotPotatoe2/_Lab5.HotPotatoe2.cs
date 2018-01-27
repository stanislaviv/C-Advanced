﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab5.HotPotatoe2
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Queue<string> queue = new Queue<string>(input.Split(' '));
			int number = int.Parse(Console.ReadLine());

			while (queue.Count > 1)
			{
				for (int i = 0; i < number - 1; i++)
				{
					string reminder = queue.Dequeue();
					queue.Enqueue(reminder);
				}

				Console.WriteLine($"Removed {queue.Dequeue()}");
			}

			Console.WriteLine($"Last is {queue.Dequeue()}");

		}
	}
}
