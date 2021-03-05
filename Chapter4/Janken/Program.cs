using System;
using Janken.Players;

namespace Janken
{
    class Program
    {
        static void Main(string[] args)
        {
            Judge saito = new Judge();

            Player murata = new Murata("村田さん");

            Player yamada = new Yamada("山田さん");

            saito.StartJanken(murata, yamada);
        }
    }
}
