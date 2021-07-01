using System;
using Game;

namespace Leaderboard
{
    public class TopUsers
    {
        public void ShowLeaderboard()
        {
            Game.Game data = new Game.Game();
            Console.WriteLine($"\n1. {getUsers.name} - {getUsers.rollTotal}");

            Console.ReadKey();
        }
    }
}
