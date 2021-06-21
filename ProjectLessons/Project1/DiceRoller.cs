using System;
using Main;

	namespace Game
	{
		public class DiceRoller
		{
			public void Roller()
			{
				string dice1 = "+-----+\n|     |\n|  *  |\n|     |\n+-----+";
				string dice2 = "+-----+\n|     |\n| * * |\n|     |\n+-----+";
				string dice3 = "+-----+\n|     |\n| *** |\n|     |\n+-----+";
				string dice4 = "+-----+\n| * * |\n|     |\n| * * |\n+-----+";
				string dice5 = "+-----+\n| * * |\n|  *  |\n| * * |\n+-----+";
				string dice6 = "+-----+\n| * * |\n| * * |\n| * * |\n+-----+";

				Console.WriteLine("Hey! I suggest playing the game Dice Roller.");
				Console.WriteLine("\nRules:\nFor the game, 3 dice rolls are given.\nIf the player gets more than 12 points in total, then he wins the game, if not, he loses.");
				Console.ReadKey();
				Console.WriteLine("What is your name?");
				string name = Console.ReadLine();

				Random dice = new Random();
				Console.WriteLine($"\n{name}, let's start the game!\n");
				Console.ReadKey();
				int roll1 = 1;
				Console.WriteLine($"The first dice is rolled. Score: {roll1}.");
				switch (roll1)
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
				Console.ReadKey();
				int roll2 = dice.Next(1, 7);
				Console.WriteLine($"The second dice is rolled. Score: {roll2}.");
				switch (roll2)
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
				Console.ReadKey();
				int roll3 = dice.Next(1, 7);
				Console.WriteLine($"The third dice is rolled. Score: {roll3}.");
				switch (roll3)
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
				Console.ReadKey();
				int rollTotal = roll1 + roll2 + roll3;
				Console.WriteLine($"All dice have been rolled. Total score: {rollTotal}.");
				Console.WriteLine();

				if (roll1 == roll2 || roll2 == roll3 || roll3 == roll1)
				{
					if (roll1 == roll2 && roll2 == roll3)
					{
						Console.WriteLine("And you have triplet! +4 bonus to total score!");
						rollTotal += 6;
					}
					else
					{
						Console.WriteLine("And you have doubles! +2 bonus to total score!");
						rollTotal += 2;
					}
				}
				if (rollTotal > 12)
				{
					Console.WriteLine($"\n{name}, Congratulations! You win!\nYou score: {rollTotal}");
				}
				else
				{
					Console.WriteLine($"\n{name}, you lose, sorry. Try again.\nYou score: {rollTotal}.");
				}
			}
		}
	}