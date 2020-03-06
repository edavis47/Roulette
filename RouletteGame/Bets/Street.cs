using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteGame.Bets
{
    class Street
    {
        RouletteBoard board = new RouletteBoard();
        RouletteWheel wheel = new RouletteWheel();
        public string StreetBet(int a)
        {
            string output = "";
            if (board.ColumnNumber(a) == 1)
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output += $"[{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 1]}|{RouletteWheel.Numbers[a + 2]}]";
            }
            else if (board.ColumnNumber(a) == 2)
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output += $"[{RouletteWheel.Numbers[a - 1]}|{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 1]}]";
            }
            else if (board.ColumnNumber(a) == 3)
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output += $"[{RouletteWheel.Numbers[a - 2]}|{RouletteWheel.Numbers[a - 1]}|{RouletteWheel.Numbers[a + 2]}]";
            }
            else
            {
                return "No winning Street.";
            }
            return output;
        }
    }
}