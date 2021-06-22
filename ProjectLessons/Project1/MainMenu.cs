using System;
using Game;

namespace Main
{
	public class MainMenu
	{
		public void menuItem(int item)
		{
            switch (item)
			{
				case 1:
				Console.WriteLine("\nYou choice menu item - Play Game.");
                break;
				case 2:
				Console.WriteLine("\nYou choice menu item - Rules.");
				break;
				case 3:
				Console.WriteLine("\nYou choice menu item - Settings.");
				break;
				case 4:
				Console.WriteLine("\nYou choice menu item - Exit.");
				break;
				default:
				Console.WriteLine("\nError. Please enter a valid value.");
				break;

			}
					if (item == 1)
					{
						Console.WriteLine("\nStart Game.");
						DiceRoller game = new DiceRoller();
						game.Roller();
					}
					else if (item == 2)
					{
						Console.WriteLine("\nGame rules:");
                        Rules();
					}
					else if (item == 3)
					{
						Console.WriteLine("\nGame settings:");
						//и сюда вставляем методы/классы
					}
					else if (item == 4)
					{
						Console.WriteLine("\nGoodbye.");
					}
		}
		public static void Rules()
        {
			Console.WriteLine("\nRules:\nFor the game, 3 dice rolls are given.\nIf the player gets more than 12 points in total, then he wins the game, if not, he loses.");
		}
	}
}