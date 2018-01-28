using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003.Lab.CreatingJaggedArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int rows = int.Parse(Console.ReadLine());

			int[][] jaggedArray = new int[rows][];

			for (int rowsCounter = 0; rowsCounter < rows; rowsCounter++)
			{
				jaggedArray[rowsCounter] = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
			}


			for (int rowsCounter = 0; rowsCounter < jaggedArray.Length; rowsCounter++)
			{
				var row = jaggedArray[rowsCounter];

				for (int index = 0; index < row.Length; index++)
				{
					Console.Write(row[index]);
					//Console.WriteLine(jaggedArray[rowsCounter][index]);
				}
				Console.WriteLine();
			}
		}
	}
}
