using Janken.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace Janken.Tactics
{
    /// <summary>
    /// 「グーが大好き！」戦略クラス。
    /// </summary>
    public class StoneOnlyTactics : ITactics
    {
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
            return Player.STONE;
        }
    }
}
