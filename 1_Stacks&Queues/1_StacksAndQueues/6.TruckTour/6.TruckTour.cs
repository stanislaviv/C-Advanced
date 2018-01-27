﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.TruckTour
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			var queue = new Queue<int[]>();

			for (int i = 0; i < n; i++)
			{
				var pump = Console.ReadLine().Split().Select(int.Parse).ToArray();

				queue.Enqueue(pump);
			}

			for (int currentStart = 0; currentStart < n - 1; currentStart++)
			{
				int fuel = 0;
				bool isSolution = true;



				for (int pumpsPassed = 0; pumpsPassed < n; pumpsPassed++)
				{
					var currentPump = queue.Dequeue();
					var pumpFuel = currentPump[0];
					int nextPumpDistance = currentPump[1];

					queue.Enqueue(currentPump);

					fuel += pumpFuel - nextPumpDistance;

					if (fuel < 0)
					{
						currentStart += pumpsPassed;
						isSolution = false;
						break;
					}
				}

				if (isSolution)
				{
					Console.WriteLine(currentStart);
					Environment.Exit(0);
				}
			}

		}
	}
}
