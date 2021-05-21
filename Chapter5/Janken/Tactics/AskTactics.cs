using Janken.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace Janken.Tactics
{
    /// <summary>
    /// 標準入力によりジャンケンの手をユーザに聞く戦略クラス。
    /// </summary>
    public class AskTactics : ITactics
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
            Console.WriteLine("ジャンケンの手を入力してください。");
            Console.WriteLine("0: グー");
            Console.WriteLine("1: チョキ");
            Console.WriteLine("2: パー\n");
            Console.Write("? ");

            int hand = 0;

            while (true)
            {
                try
                {
                    string inputStr = Console.ReadLine();

                    hand = int.Parse(inputStr);

                    if (hand == Player.STONE || hand == Player.SCISSORS || hand == Player.PAPER)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("入力が正しくありません。再度入力してください。");
                        Console.Write("? ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("入力が正しくありません。再度入力してください。");
                    Console.Write("? ");
                }

            }

            return hand;
            
        }
    }
}
