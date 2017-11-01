using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab1.ReverseString
{
	class LabReverseString
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			Stack<char> text = new Stack<char>();

			foreach (var letter in input)
			{
				text.Push(letter);
			}

			while (text.Count != 0)
			{
				Console.Write(text.Pop());
			}

			//for (int i = 0; i < input.Length; i++)
			//{
			//	text.Push(input[i]);
			//}

			//for (int i = 0; i < input.Length; i++)
			//{
			//	Console.Write(text.Pop());
			//}	
		}
	}
}
