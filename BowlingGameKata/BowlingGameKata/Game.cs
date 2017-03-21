﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public class Game
    {
       
        private int [] rolls = new int[21];
        private int currentRoll = 0;

        public void roll(int pins)
        {
            rolls[currentRoll] = pins;
            currentRoll++;
        }

        public int scoreGame()
        {
            int score = 0;
            for (int i = 0; i < rolls.Length; i++)
            {
                score += rolls[i];
            }
            return score;
        }

      

    }
}
