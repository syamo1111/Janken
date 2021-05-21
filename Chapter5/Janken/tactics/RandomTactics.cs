using Janken.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace Janken.Tactics
{
    /// <summary>
    /// ランダムに手を決める戦略クラス。
    /// </summary>
    public class RandomTactics : ITactics
    {
        private static int seed = Environment.TickCount;

        /// <summary>
        /// 戦略を読み、ジャンケンの手を得る。
        /// グー・チョキ・パーのいずれかをPlayerクラスに定義された
        /// 以下の定数で返す。
        /// Player.STONE    … グー
        /// Player.SCISSORS … チョキ
        /// Player.PAPER    … パー
        /// </summary>
        /// <returns>ジャンケンの手</returns>
        public int readTactics()
        {
            int hand = 0;

            seed *= 33;
            Random random = new Random(seed);
            double randomNum = random.NextDouble() * 3;
            if (randomNum < 1)
            {
                hand = Player.STONE;
            }
            else if (randomNum < 2)
            {
                hand = Player.SCISSORS;
            }
            else if (randomNum < 3)
            {
                hand = Player.PAPER;
            }

            return hand;
        }
    }
}
