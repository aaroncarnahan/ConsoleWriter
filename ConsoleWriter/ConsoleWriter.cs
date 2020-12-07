using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleWriter
{
	public class ConsoleWriter
	{

		public void StartProgram()
		{
			Thread mainProgram = new Thread(new ThreadStart(Run));
			mainProgram.Name = "MainProgram";
			mainProgram.Start();
		}

		public static void Run() 
		{
			bool isRunning = true;

			while (isRunning)
			{

				// CCHANGE CONSOLE TITLE
				Console.Title = "ConsoleWriter Ver. 0.1";
				// CHANGE CONSOLE TITLE END

				// GET AND CHANGE DIRECTORY START
				string path = Directory.GetCurrentDirectory();
				Console.WriteLine("Current directory is: " + path);
				Console.ReadKey();
				// GET AND CHANGE DIRECTORY END

				// STREAMWRITER START
				Int64 x;
				//Open the File
				StreamWriter sw = new StreamWriter("C:\\Code\\ConsoleWriter\\ConsoleWriter\\Test1.txt", true, Encoding.UTF8);
				//Writeout the numbers 1 to 10 on the same line.
				for (x = 0; x < 10; x++)
				{
					sw.Write(x);
				}
				//close the file
				sw.Close();
				// STREAMWRITER END

				// EXIT BLOCK START
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
				// EXIT BLOCK END
			}
		}
	}
}
