﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003.Lab.GroupNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine()
				.Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			var sizes = new int[3];

			foreach (var number in numbers)
			{
				sizes[Math.Abs(number % 3)]++;
			}

			int[][] jaggedArray = new int[3][];
			for (int counter = 0; counter < sizes.Length; counter++)
			{
				jaggedArray[counter] = new int[sizes[counter]];
			}
			  
			int[] index = new int[3];
			foreach (var number in numbers)
			{
				var remainder = Math.Abs(number % 3);
				jaggedArray[remainder][index[remainder]] = number;
				index[remainder]++;
			}

			for (int rows = 0; rows < jaggedArray.Length; rows++)
			{
				for (int columns = 0; columns < jaggedArray[rows].Length; columns++)
				{
					Console.Write(jaggedArray[rows][columns] + " ");
				}
				Console.WriteLine();

				//Console.WriteLine(string.Join(" ",jaggedArray[rows]));
			}


		}
	}
}
