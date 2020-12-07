using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleWriter
{
	public class KeyListener
	{
		public void StartListener() 
		{
			Thread ConsoleKeyListener = new Thread(new ThreadStart(startProcess));
			ConsoleKeyListener.Name = "KeyListener";
			ConsoleKeyListener.Start();
		}

        public static void startProcess()
        {
			bool isRunning = true;

			while (isRunning)
			{
				Console.BackgroundColor = ConsoleColor.Blue;
				Thread.Sleep(100);
				Console.BackgroundColor = ConsoleColor.Red;
				Thread.Sleep(100);
			}
			
		}
    }
}
