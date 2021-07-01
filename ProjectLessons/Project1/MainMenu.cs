using System;
using Leaderboard;

namespace Project1
{
	class MainMenu
	{
        public static void Main(string[] args)
		{
			while (true)
            {
				Console.WriteLine("\nMain menu:\n");
				Console.WriteLine("1. Play game\n2. Rules\n3. Top users\n4. Settings\n5. Exit");
				Console.WriteLine("\n..please enter the number of the menu item..\n");
				int playerChoice = Convert.ToInt32(Console.ReadLine());

				Menu main = new Menu();
				main.menuItem(playerChoice);
				if (playerChoice == 5)
                {
					break;
                }
            }
        }
    }
	public class Menu
	{
		public void menuItem(int item)
		{
			switch (item)
			{
				case 1:
					Console.WriteLine("\nYou choice menu item - \"Play Game\".");
					break;
				case 2:
					Console.WriteLine("\nYou choice menu item - \"Rules\".");
					break;
				case 3:
					Console.WriteLine("\nYou choice menu item - \"Top users\".");
					break;
				case 4:
					Console.WriteLine("\nYou choice menu item - \"Settings\".");
					break;
				case 5:
					Console.WriteLine("\nYou choice menu item - \"Exit\".");
					break;
				default:
					Console.WriteLine("\nError. Please enter a valid value.");
					break;
			}
			if (item == 1)
			{
				Console.WriteLine("\nStart Game.");
                Game.Game game = new Game.Game();
				game.DiceRoller();
			}
			else if (item == 2)
			{
				Console.WriteLine("\nGame rules:");
				Rules();
			}
			else if (item == 3)
			{
				Console.WriteLine("\nTop users:");
				TopUsers top = new TopUsers();
				top.ShowLeaderboard();
			}
			else if (item == 4)
			{
				Console.WriteLine("\nGame settings:");
				//и сюда вставляем методы/классы
			}
			else if (item == 5)
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