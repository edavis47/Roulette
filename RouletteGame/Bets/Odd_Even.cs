using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteGame.Bets
{
    class Odd_Even
    {
        public string OddOrEven(int x)
        {
            if ((x % 2 == 0) && (x != 0)) //
            {
                return "Even numbers"; // EVEN
            }
            else if (x % 2 != 0)
            {
                return "Odd numbers"; // ODD
            }
            else
            {
                return "Neither even nor odd numbers because it was 0 or 00"; // 0s
            }
        }
    }
}
