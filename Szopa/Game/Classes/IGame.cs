using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public interface IGame
    {
        void StartGame(int players);
        void Play(IPlayer players, int score);
        string EndGame();
    }
}

