using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteGame.Bets
{
    class Low_High
    {
        public string LowHighBet(int a)
        {
            if (a > 0 && a < 19)
            {
                return "Low Numbers[1 - 18]";
            }
            else if (a > 18)
            {
                return "High Numbers[19 - 36]";
            }
            else
            {
                return "Neither low nor high number group wins for 0 or 00.";
            }
        }
    }
}
