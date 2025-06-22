using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arrInt = { 4, 5, 8, 3, 5, 9, 2, 1, 6, 7 };
			int max = 0;
			for (int i = 0; i < arrInt.Length; i++)
			{
				if (arrInt[i] > max)
				{
					max = arrInt[i];
				}
			}
			Console.WriteLine("max là " + max);
		}
	}
}
