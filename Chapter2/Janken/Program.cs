using System;

namespace Janken
{
    class Program
    {
        public const int STONE = 0;
        public const int SCISSORS = 1;
        public const int PAPER = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("【じゃんけん開始】");

            int player1WinCount = 0;
            int player2WinCount = 0;

            for (int cnt=0; cnt < 3; cnt++)
            {
                int player1Hand = 0;

                Random rnd1 = new Random();
                double randomNum = rnd1.Next(0, 300);
                if (randomNum < 100)
                {
                    player1Hand = STONE;

                    Console.WriteLine("グー");
                }
                else if (randomNum < 200)
                {
                    player1Hand = SCISSORS;

                    Console.WriteLine("チョキ");
                }
                else if (randomNum < 300)
                {
                    player1Hand = PAPER;

                    Console.WriteLine("パー");
                }

                int player2Hand = 0;

                Random rnd2 = new Random();
                randomNum = rnd2.Next(0, 300);
                if (randomNum < 100)
                {
                    player2Hand = STONE;

                    Console.WriteLine("グー");
                }
                else if (randomNum < 200)
                {
                    player2Hand = SCISSORS;

                    Console.WriteLine("チョキ");
                }
                else if (randomNum < 300)
                {
                    player2Hand = PAPER;

                    Console.WriteLine("パー");
                }

                if ((player1Hand == STONE && player2Hand == SCISSORS)
                    || (player1Hand == SCISSORS && player2Hand == PAPER)
                    || (player1Hand == PAPER && player2Hand == STONE))
                {
                    player1WinCount++;

                    Console.WriteLine("プレイヤー1が勝ちました！");
                }
                else if ((player1Hand == STONE && player2Hand == PAPER)
                         || (player1Hand == SCISSORS && player2Hand == STONE)
                         || (player1Hand == PAPER && player2Hand == SCISSORS))
                {
                    player2WinCount++;

                    Console.WriteLine("プレイヤー2が勝ちました！");
                }
                else
                {
                    Console.WriteLine("引き分けです！");
                }
            }

            Console.WriteLine("【じゃんけん終了】");

            if (player1WinCount > player2WinCount)
            {
                Console.WriteLine(player1WinCount + "対" + player2WinCount + "でプレイヤー1の勝ちです！");
            }
            else if (player1WinCount < player2WinCount)
            {
                Console.WriteLine(player1WinCount + "対" + player2WinCount + "でプレイヤー2の勝ちです！");
            }
            else if (player1WinCount == player2WinCount)
            {
                Console.WriteLine(player1WinCount + "対" + player2WinCount + "で引き分けです！");
            }
        }
    }
}
