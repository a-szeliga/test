using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Classes;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
         {


            IPlayer player1 = new Player("Red Player");
            IPlayer player2 = new Player("Blue Player");
            IPlayer player3 = new Player("Yellow Player");

            /*List<IPlayer> playersList = new List<IPlayer>();
            playersList.Add(player1);
            playersList.Count();
            playersList.Sort();

            foreach (IPlayer player in playersList)
            {
                Console.WriteLine(player.Name);
            }*/


            IPlayer[] players = new IPlayer[3];
            players[0] = player1;
            players[1] = player2;
            players[2] = player3;

            var elements = players.ToList();

            IGame game1 = new BoardGame();
            IGame game2 = new VideoGame();
            GameService bgs = new GameService(game1,players);
            GameService vgs = new GameService(game2, players);

            bgs.LetsPlayTheGame(5);
            vgs.LetsPlayTheGame(5);
            
            Console.ReadLine();
        }
    }
}
