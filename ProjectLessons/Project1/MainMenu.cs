using System;
using Leaderboard;

namespace Project1
{
	class MainMenu
	{
		public static void Main(string[] args)
		{
			Menu main = null;
			while (true)
			{
				Console.WriteLine("\nMain menu:\n");
				Console.WriteLine("1. Play game\n2. Rules\n3. Top users\n4. Settings\n5. Exit");
				Console.WriteLine("\n..please enter the number of the menu item..\n");
				int playerChoice = Convert.ToInt32(Console.ReadLine());
				
				main = new Menu();
				main.MenuItem(playerChoice);

				if (playerChoice == 5)
				{
					break;
				}
			}
		}
	}
	public class Menu
	{
		public void MenuItem(int item)
		{
			switch (item)
			{
				case 1:
					Console.WriteLine("\nYou choice menu item - \"Play Game\".");
					Console.WriteLine("\nStart Game.");
					Game.PlayGame game = new Game.PlayGame();
					game.DiceRoller();
					break;
				case 2:
					Console.WriteLine("\nYou choice menu item - \"Rules\".");
					Rules();
					break;
				case 3:
					Console.WriteLine("\nYou choice menu item - \"Top users\".");
					TopUsers top = new TopUsers();
					top.ShowLeaderboard();
					break;
				case 4:
					Console.WriteLine("\nYou choice menu item - \"Settings\".");
					break;
				case 5:
					Console.WriteLine("\nYou choice menu item - \"Exit\".");
					Console.WriteLine("\nGoodbye.");
					break;
				default:
					Console.WriteLine("\nError. Please enter a valid value.");
					break;
			}
		}
		public static void Rules()
		{
			Console.WriteLine("\nRules:\nFor the game, 3 dice rolls are given.\nIf the player gets more than 12 points in total, then he wins the game, if not, he loses.");
		}
	}
}