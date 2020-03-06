using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RouletteGame.Bets
{
    class Column
    {
        RouletteBoard board = new RouletteBoard();
        public string ColumnBets(int a)
        {
            if (board.ColumnNumber(a) == 1)
            {
                return ArrayToString(board.Column1);
            }
            else if (board.ColumnNumber(a) == 2)
            {
                return ArrayToString(board.Column2);
            }
            else if ((board.ColumnNumber(a) == 3))
            {
                return ArrayToString(board.Column3);
            }
            else
            {
                return "No winning columns for 0 or 00";
            }
        }
        static string ArrayToString(int[] array)
        {
            string output = "";
            for (int i = 0; i < array.Length; i++)
            {
                if(i == 0)
                {
                    output += $"[{array[i]}|";
                }
                else if (i == array.Length - 1)
                {
                    output += $"{array[i]}]";
                }
                else
                {
                    output += $"{array[i]}|";
                }
            }
            return output;
        }
    }
}
