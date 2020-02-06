using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Random;

namespace Game.Classes
{
    public class GameService
    {
        private readonly IGame _game;
        private readonly IPlayer[] _players;

        public GameService(IGame game, IPlayer[] players)
        {
            _game = game;
            _players = players;
        }

        public void LetsPlayTheGame(int rounds)
        { 
            Random random = new Random();
            for (int i = 0; i < rounds; i++)
            {
                 _game.StartGame(_players.Length);
 
                for (int j = 0; j < _players.Length; j++)
                { 
                    _game.Play(_players[j], random.Next(1, 6));
                }
            }
            _game.EndGame();
            ShowPlayerScore();


        }
        public void ShowPlayerScore()
        {
            for (int i = 0; i < _players.Length; i++)
            {
                _players[i].DisplayScore();
            }

        }       
    }
}

