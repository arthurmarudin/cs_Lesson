using System;
using Game;

namespace Leaderboard
{
    public class TopUsers
    {
        public void ShowLeaderboard()
        {
            Console.WriteLine($"\n1. {Users.Name} - {Users.RollTotal}");
            Console.ReadKey();
        }
    }
}