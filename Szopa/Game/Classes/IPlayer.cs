using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Score { get; set; }
        void DisplayScore();
        void AddScore(int score);
    }
}
