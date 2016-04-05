using System;
using System.Threading;

namespace UserInterface
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter a number that will generate lines blocks");
			string p = Console.ReadLine();

			//Add space so that code doesn't stick together
			try
			{
				//Generate a codefile
				CodeFile.randomCode(int.Parse(p));

				Console.WriteLine("Type 'push' to push the codefile to the repository");

				string gitcommand = Console.ReadLine();

				//Check if the input is equal to push, to push the code file
				if(Framework.evaluateGitCommand(gitcommand, "push"))
				{
					// Some nasty code to print some fancy line... Please don't judge me :(
					for(int i = 1; i < 101; i++)
					{
						if (i == 1)
						{
							Console.WriteLine("Pushing code to GitHub.com...");
							Console.Write("|");
						}
						else if (i == 100)
						{
							Console.WriteLine("|");
							Console.WriteLine("Pushed code to GitHub.com!");
						}
						else
						{
							Console.Write("=");
							Thread.Sleep(5);
						}
					}
				}
				else
				{
					Console.WriteLine("Try again!");
				}

				Main();
			}
			catch (Exception)
			{
				Console.WriteLine("That's not a number, Try again.");
				Main();
			}
		}
	}
}
