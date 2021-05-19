using System;
using System.Collections.Generic;
using System.Text;

namespace Janken
{
    public class Judge
    {
        /// <summary>
        /// じゃんけんを開始する
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        public void StartJanken(Player player1, Player player2)
        {
            Console.WriteLine("【ジャンケン開始】");

            for (int cnt = 0; cnt < 3; cnt++)
            {
                Console.WriteLine(Environment.NewLine + "【" + (cnt + 1) + "回戦目】");

                Player winner = JudgeJanken(player1, player2);

                if (winner != null)
                {
                    Console.WriteLine(winner.Name + "が勝ちました！");

                    winner.NotifyResult(true);
                }
                else
                {
                    Console.WriteLine("引き分けです！");
                }
            }

            Console.WriteLine(Environment.NewLine + "【ジャンケン終了】" + Environment.NewLine);

            Player finalWinner = JudgeFinalWinner(player1, player2);

            Console.Write(
                player1.GetWinCount() + "対" + player2.GetWinCount() + "で");

            if (finalWinner != null)
            {
                Console.WriteLine(finalWinner.Name + "の勝ちです！");
            }
            else
            {
                Console.WriteLine("引き分けです！");
            }
        }

        private Player JudgeJanken(Player player1, Player player2)
        {
            Player winner = null;

            int player1hand = player1.ShowHand();
            int player2hand = player2.ShowHand();

            PrintHand(player1hand);
            Console.WriteLine(" vs. ");
            PrintHand(player2hand);

            if ((player1hand == Player.STONE    && player2hand == Player.SCISSORS)
            || (player1hand == Player.SCISSORS  && player2hand == Player.PAPER)
            || (player1hand == Player.PAPER     && player2hand == Player.STONE))
            {
                winner = player1;
            }
            else if ((player1hand == Player.STONE    && player2hand == Player.PAPER)
                 || (player1hand == Player.SCISSORS  && player2hand == Player.STONE)
                 || (player1hand == Player.PAPER     && player2hand == Player.SCISSORS))
            {
                winner = player2;
            }

            return winner;
        }

        private Player JudgeFinalWinner (Player player1, Player player2)
        {
            Player winner = null;

            int player1WinCount = player1.GetWinCount();
            int player2WinCount = player2.GetWinCount();

            if (player1WinCount > player2WinCount)
            {
                winner = player1;
            }
            else if (player1WinCount < player2WinCount)
            {
                winner = player2;
            }

            return winner;
        }

        private void PrintHand(int hand)
        {
            switch (hand)
            {
                case Player.STONE:
                    Console.WriteLine("グー");
                    break;

                case Player.SCISSORS:
                    Console.WriteLine("チョキ");
                    break;

                case Player.PAPER:
                    Console.WriteLine("パー");
                    break;

                default:
                    break;
            }
        }
    }
}
