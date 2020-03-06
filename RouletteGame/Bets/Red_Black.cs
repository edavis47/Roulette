using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteGame.Bets
{
    class Red_Black
    {
        public string RedBlack(int a)
        {
            RouletteWheel wheel = new RouletteWheel();
            if (a > 0) // Red or Black
            {
                return RouletteWheel.Colors[a]; 
            }
            else //0 or 00
            {
                return "Neither Red nor Black colors because it was 0 or 00, which are green."; 
            }
            
        }
    }
}
