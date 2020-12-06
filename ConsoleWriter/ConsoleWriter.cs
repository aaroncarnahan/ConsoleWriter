using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWriter
{
	public class ConsoleWriter
	{
		public void Run() 
		{
			bool isRunning = true;

			while (isRunning)
			{
				string userInput = Console.ReadLine();

				if (userInput == "exit")
				{
					Console.WriteLine("Are you sure you want to exit the program without saving?");
					string userAnswer = Console.ReadLine();
					if (userAnswer == "no" || userAnswer == "n")
					{
						Console.WriteLine("You chose to keep running the program");
					}
					else if (userAnswer == "yes" || userAnswer == "y")
					{
						isRunning = false;
					}
				}
			}
		}
	}
}
