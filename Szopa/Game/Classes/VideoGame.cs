using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Game.Classes
{
    class VideoGame : IGame
    {
        public void StartGame(int Players)
        {
            string message = "Zaczynamy grę video, ilość graczy to: " + Players;
            using (StreamWriter sw = File.AppendText("game.txt"))
            {
                sw.WriteLine(message);
                Console.WriteLine(message);
            }
        }
        public void Play(IPlayer player, int score)
        {
            Console.WriteLine($"Gracz {player.Name} rzucił kością, jego wynik to: " + score);
            player.AddScore(score);
        }

        public string EndGame()       
        {
            string message = "Gra video zakończona";
            Console.WriteLine(message);
            using (StreamWriter sw = File.AppendText("game.txt"))
            {               
                sw.WriteLine(message);
            }
            return File.ReadAllText("game.txt");
        }      
    }
}


