using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopProblem
{
    internal class Gambler
    {
      public static void GamblerBet()
      {
            int stakePrDay = 100;
            int betPrGame = 1;
      }
        public static void Startbet()
        {
            int GamblerWin = 0;
            int Gamblerloos = 0;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == GamblerWin)
                Console.WriteLine("Gambler Is Won");
            else
                Console.WriteLine("Gambler Is Lost");
        }

    }
}
