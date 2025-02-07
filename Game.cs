﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Game
    {
        int playerPosition = 0;
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        Random random = new Random();
        public int DieRoll()
        {
            int dieCount = random.Next(1, 7);
            return dieCount;    
        }
        public void Play()
        {
            int op=random.Next(0, 3);
            if (playerPosition < 100)
            {
                switch (op)
                {
                    case NO_PLAY:
                        playerPosition += 0;
                        if (playerPosition < 0)
                        {
                            playerPosition = 0;
                        }
                        break;
                    case LADDER:
                        playerPosition += DieRoll();
                        break;
                    case SNAKE:                       
                            playerPosition -= DieRoll();                        
                        break;
                }
                Console.WriteLine(playerPosition);
            }
        }
    }
}
