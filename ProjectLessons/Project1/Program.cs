using System;
using Game;
using Main;

namespace Project1
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Main menu:\n");
			Console.WriteLine("1. Play game\n2. Rules\n3. Settings\n4. Exit");
			Console.WriteLine("\n..please enter the number of the menu item..\n");
			int playerChoice = Convert.ToInt32(Console.ReadLine());

            MainMenu main = new MainMenu();
            main.menuItem(playerChoice);
		}

	}
}
