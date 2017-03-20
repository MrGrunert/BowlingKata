using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public class Game
    {
        private int score = 0;

        public void roll(int pins)
        {
            score += pins;
        }

        public int scoreGame()
        {
            return score;
        }

       //add this to test gitpus
       // test igen då..

    }
}
