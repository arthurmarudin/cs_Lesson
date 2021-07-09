using System;
using Leaderboard;

namespace Game
{
	public class PlayGame
	{
		public string name;
		public int rollTotal;
		
		public static int Throw()
		{
			string dice1 = "+-----+\n|     |\n|  *  |\n|     |\n+-----+";
			string dice2 = "+-----+\n|     |\n| * * |\n|     |\n+-----+";
			string dice3 = "+-----+\n|     |\n| *** |\n|     |\n+-----+";
			string dice4 = "+-----+\n| * * |\n|     |\n| * * |\n+-----+";
			string dice5 = "+-----+\n| * * |\n|  *  |\n| * * |\n+-----+";
			string dice6 = "+-----+\n| * * |\n| * * |\n| * * |\n+-----+";
			
			Random dice = new Random();
			int roll = dice.Next(1, 7);
			Console.WriteLine($"The first dice is rolled. Score: {roll}.");
			
			switch (roll)
			{
				case 1:
					Console.WriteLine(dice1);
					break;
				case 2:
					Console.WriteLine(dice2);
					break;
				case 3:
					Console.WriteLine(dice3);
					break;
				case 4:
					Console.WriteLine(dice4);
					break;
				case 5:
					Console.WriteLine(dice5);
					break;
				case 6:
					Console.WriteLine(dice6);
					break;
			}
			return roll;
				}
		public void DiceRoller()
		{
			Console.WriteLine("What is your name?");
			Users.Name = Console.ReadLine();
			
			Console.WriteLine($"\n{Users.Name}, let's start the game!\n");
			Console.ReadKey();

			int roll1 = Throw();
			Console.ReadKey();
			
			int roll2 = Throw();
			Console.ReadKey();
					
			int roll3 = Throw();
			Console.ReadKey();
			
			Users.RollTotal = roll1 + roll2 + roll3;
			Console.WriteLine($"All dice have been rolled. Your score: {Users.RollTotal}.");
			Console.ReadKey();
			
			if (roll1 == roll2 || roll2 == roll3 || roll3 == roll1)
			{
				if (roll1 == roll2 && roll2 == roll3)
				{
					Console.WriteLine("And you have triplet! +4 bonus to total score!");
					Users.RollTotal += 6;
					Console.ReadKey();
				}
				else
				{
					Console.WriteLine("And you have doubles! +2 bonus to total score!");
					Users.RollTotal += 2;
					Console.ReadKey();
				}
			}
			if (Users.RollTotal > 12)
			{
				Console.WriteLine($"\n{Users.Name}, Congratulations! You win!\nYour total score: {Users.RollTotal}");
			}
			else
			{
				Console.WriteLine($"\n{Users.Name}, you lose, sorry. Try again.\nYour total score: {Users.RollTotal}.");
			}
		}
	}
	public static class Users
	{
		public static string Name { get; set; }
		public static int RollTotal { get; set; }
	}
}