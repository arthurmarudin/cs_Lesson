using System;
using Game;


namespace Main
{
	public class MainMenu
	{
		public void menuItem(int x)
		{
            switch (x)
			{
				case 1:
				Console.WriteLine("\nYou choice menu item - Play Game.");
                break;
				case 2:
				Console.WriteLine("\nYou choice menu item - Play Game.");
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
					if (x == 1)
					{
						Console.WriteLine("\nStart Game.");
						DiceRoller game = new DiceRoller();
						game.Roller();
					}
					else if (x == 2)
					{
						Console.WriteLine("\nGame rules:");
						//и сюда вставляем методы/классы
					}
					else if (x == 3)
					{
						Console.WriteLine("\nGame settings:");
						//и сюда вставляем методы/классы
					}
					else if (x == 4)
					{
						Console.WriteLine("\nGoodbye.");
					}
		}
	}
}