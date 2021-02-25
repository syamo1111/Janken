using System;

namespace Janken
{
    class Program
    {
        static void Main(string[] args)
        {
            Judge saito = new Judge();

            Player murata = new Player("村田さん");

            Player yamada = new Player("山田さん");

            saito.StartJanken(murata, yamada);
        }
    }
}
