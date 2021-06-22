using System;
using Project1;
using Game;
using Main;
using Users;

namespace topUsers
{
    public class Top
    {
        public void Users()
        {

            DiceRoller data = new DiceRoller();
            Console.WriteLine($"\n1. {getUsers.name} - {getUsers.rollTotal}");

            Console.ReadKey();
            // потом добавить .Sort(); .Reverse();
        }
    }
}
