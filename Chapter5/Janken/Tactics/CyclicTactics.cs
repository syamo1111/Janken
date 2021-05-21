using System;
using System.Collections.Generic;
using System.Text;

namespace Janken.Tactics
{
    public class CyclicTactics : ITactics
    {
        int hand = -1;

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
            hand = (hand + 1) % 3;


            return hand;
        }
    }
}
