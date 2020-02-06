using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Game.Classes
{
     class BoardGame : IGame
    {
        //IPlayer[] players = new IPlayer[players.Length];
        public void StartGame(int Players)
        {
            string message = "Zaczynamy grę planszową, ilość graczy to: " + Players;
            Console.WriteLine(message);
            using (StreamWriter sw = File.AppendText("game.txt"))
            {
              sw.WriteLine(message);            
            }
        }

        public void Play(IPlayer player, int score)
        {
            using (StreamWriter sw = File.AppendText("game.txt"))
            {
                Console.WriteLine($"Gracz {player.Name} rzucił kością, jego wynik to: " + score);
                player.AddScore(score);
            }
        }
        public string EndGame()
        {
            string message = "Gra planszowa zakończona";
            
            using (StreamWriter sw = File.AppendText("game.txt"))
            {   Console.WriteLine(message);
                sw.WriteLine(message);
            }
            //return message;
            return File.ReadAllText("game.txt");
        }
    }

}
