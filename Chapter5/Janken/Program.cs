using System;
using Janken.Players;

namespace Janken
{
    class Program
    {
        static void Main(string[] args)
        {
            Judge judge = new Judge();

            Player murata = new Murata("村田さん");

            Tactics murataTactics = new RandomTactics();
            murata.Tactics = murataTactics;

            Player yamada = new Yamada("山田さん");

            Tactics yamadaTactics = new RandomTactics();
            yamada.Tactics = yamadaTactics;

            judge.StartJanken(murata, yamada);
        }
    }
}
