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


        private int winCount = 0;

        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 戦略
        /// </summary>
        public Tactics Tactics { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Player(string name)
        {
            this.Name = name;
        }

        public int ShowHand()
        {
            // 戦略を読んでじゃんけんの手を決める
            int hand = Tactics.readTactics();

            // 決定した手を返す
            return hand;
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
