using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Lab.SumMatrixElements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] rowsAndColumns = Console.ReadLine()
				.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int[,] matrix = new int[rowsAndColumns[0], rowsAndColumns[1]];



			for (int rows = 0; rows < rowsAndColumns[0]; rows++)
			{

				var rowvalues = Console.ReadLine()
					.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();

				for (int columns = 0; columns < rowsAndColumns[1]; columns++)
				{
					matrix[rows, columns] = rowvalues[columns];
				}
			}

			int sum = 0;

			for (int rows = 0; rows < matrix.GetLength(0); rows++)
			{
				for (int columns = 0; columns < matrix.GetLength(1); columns++)
				{
					sum += matrix[rows, columns];
				}
			}

			Console.WriteLine(matrix.GetLength(0));
			Console.WriteLine(matrix.GetLength(1));
			Console.WriteLine(sum);



		}
	}
}
