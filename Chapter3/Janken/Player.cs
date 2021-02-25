using System;
using System.Collections.Generic;
using System.Text;

namespace Janken
{
    public class Player
    {
        public const int STONE = 0;
        public const int SCISSORS = 1;
        public const int PAPER = 2;

        private string name;

        private int winCount = 0;

        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Player(string name)
        {
            this.Name = name;
        }

        public int ShowHand()
        {
            int playerHand = 0;

            Random rnd = new Random();
            double randomNum = rnd.Next(0, 300);
            if (randomNum < 100)
            {
                playerHand = STONE;
            }
            else if (randomNum < 200)
            {
                playerHand = SCISSORS;
            }
            else if (randomNum < 300)
            {
                playerHand = PAPER;
            }

            return playerHand;
        }

        public void NotifyResult(bool result)
        {
            if (result)
            {
                winCount++;
            }
        }

        public int GetWinCount()
        {
            return winCount;
        }
    }
}
