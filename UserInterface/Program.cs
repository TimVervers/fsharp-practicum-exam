using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number that will generate lines blocks");
			string p = Console.ReadLine();

			//Check if parsing is possible, or in f#??
			foreach (var item in CodeFile.randomCode(int.Parse(p)))
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();
		}
	}
}
