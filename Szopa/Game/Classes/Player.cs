using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public class Player : IPlayer
    {
        public string Name { get; set; }
        public int Score { get; set; }


        public Player(string name)
        { Name = name; }

        public void AddScore(int score)
        {
            Score = score + Score;

        }
        public void DisplayScore()
        {
            Console.WriteLine("Wynik gracza " + Score);
        }
    }
}
