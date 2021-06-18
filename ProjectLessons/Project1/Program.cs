using System;
using Game;

namespace Project1
{
    class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Main menu:\n");
			Console.WriteLine("1. Play game\n2. Settings\n3. Exit");
			Console.WriteLine("\n..please enter the number of the menu item..\n");
			int playerChoice = Convert.ToInt32(Console.ReadLine());

			switch (playerChoice)
			{
				case 1:
					Console.WriteLine("\nYou choice menu item - Play Game.");
					break;
				case 2:
					Console.WriteLine("\nYou choice menu item - Settings.");
					break;
				case 3:
					Console.WriteLine("\nYou choice menu item - Exit.");
					break;
				default:
					Console.WriteLine("\nError. Please enter a valid value.");
					break;
			}

			if (playerChoice == 1)
			{
				Console.WriteLine("\nStart Game.");
	DiceRoller game = new DiceRoller();
game.Roller();
			}
			else if (playerChoice == 2)
			{
				Console.WriteLine("\nGame settings:");
				//и сюда вставляем методы/классы
			}
			else if (playerChoice == 3)
			{
				Console.WriteLine("\nGoodbye.");
			}
		}
	/*
		public static void Settings()
		{
			Console.WriteLine("\n1. Sound.\n2. Music.\n3.Haptic.");
			int playerSettingChoice = Convert.ToInt32(Console.ReadLine());

		}
	*/
}
			}
		