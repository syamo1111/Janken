using System;
using Janken.Players;
using Janken.Tactics;

namespace Janken
{
    class Program
    {
        static void Main(string[] args)
        {
            Judge judge = new Judge();

            Player murata = new Murata("村田さん");

            ITactics murataTactics = new StoneOnlyTactics();
            murata.Tactics = murataTactics;

            Player yamada = new Yamada("山田さん");

            ITactics yamadaTactics = new RandomTactics();
            yamada.Tactics = yamadaTactics;

            judge.StartJanken(murata, yamada);
        }
    }
}
