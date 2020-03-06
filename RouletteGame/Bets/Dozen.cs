using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RouletteGame.Bets
{
    class Dozen
    {
        RouletteBoard board = new RouletteBoard();
        public string DozensBets(int a)
        {
            string output;
            if (a > 0 && a <13)
            {
                output = "1st: [1|2|3|4|5|6|7|8|9|10|11|12]";
            }
            else if (a > 12 && a < 25 )
            {
                output = "2nd: [13|14|15|16|17|18|19|20|21|22|23|24]";
            }
            else if (a > 24)
            {
                output = "3rd: [25|26|27|28|29|30|31|32|33|34|35|36]";
            }
            else
            {
                output = "No winning dozen for 0 or 00.";
            }
            return output;
        }
    }
}
