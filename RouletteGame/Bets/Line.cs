using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteGame.Bets
{
    class Line
    {
        RouletteBoard board = new RouletteBoard();
        RouletteWheel wheel = new RouletteWheel();
        public string LineBet(int a)
        {
            string output;
            if (a < 1)
            {
                output = "No Lines win.";
            }
            //INSIDE STREETS
            else if (board.ColumnNumber(a) == 1 && board.StreetIndex(a) == 3) //FIRST NUM IN INSIDE STREET
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 1]}|{RouletteWheel.Numbers[a + 2]}]" +
                    $" and [{RouletteWheel.Numbers[a - 3]}|{RouletteWheel.Numbers[a - 2]}|{RouletteWheel.Numbers[a - 1]}]" +
                    $" or [{RouletteWheel.Numbers[a + 3]}|{RouletteWheel.Numbers[a + 4]}|{RouletteWheel.Numbers[a + 5]}]";
            }
            else if (board.ColumnNumber(a) == 2 && board.StreetIndex(a) == 3) //SECOND NUM IN INSIDE STREET
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a - 1]}|{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 1]}]" +
                    $" and [{RouletteWheel.Numbers[a - 4]}|{RouletteWheel.Numbers[a - 3]}|{RouletteWheel.Numbers[a - 2]}]" +
                    $" or [{RouletteWheel.Numbers[a + 2]}|{RouletteWheel.Numbers[a + 3]}|{RouletteWheel.Numbers[a + 4]}]";
            }
            else if(board.ColumnNumber(a) == 3 && board.StreetIndex(a) == 3) //THIRD NUM IN INSIDE STREET
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a - 2]}|{RouletteWheel.Numbers[a - 1]}|{RouletteWheel.Numbers[a]}]" +
                    $" and [{RouletteWheel.Numbers[a - 5]}|{RouletteWheel.Numbers[a - 4]}|{RouletteWheel.Numbers[a - 3]}]" +
                    $" or [{RouletteWheel.Numbers[a + 1]}|{RouletteWheel.Numbers[a + 2]}|{RouletteWheel.Numbers[a + 3]}]";
            }
            //FIRST STREET
            else if (board.ColumnNumber(a) == 1 && board.StreetIndex(a) == 1) //FIRST NUM IN FIRST STREET
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 1]}|{RouletteWheel.Numbers[a + 2]}]" +
                    $" and [{RouletteWheel.Numbers[a + 3]}|{RouletteWheel.Numbers[a + 4]}|{RouletteWheel.Numbers[a + 5]}]";
            }
            else if (board.ColumnNumber(a) == 2 && board.StreetIndex(a) == 1) //SECOND NUM IN FIRST STREET
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a - 1]}|{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 1]}]" +
                    $" and [{RouletteWheel.Numbers[a + 2]}|{RouletteWheel.Numbers[a + 3]}|{RouletteWheel.Numbers[a + 4]}]";
            }
            else if (board.ColumnNumber(a) == 3 && board.StreetIndex(a) == 1) //THIRD NUM IN FIRST STREET
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a - 2]}|{RouletteWheel.Numbers[a - 1]}|{RouletteWheel.Numbers[a]}]" +
                    $" and [{RouletteWheel.Numbers[a + 1]}|{RouletteWheel.Numbers[a + 2]}|{RouletteWheel.Numbers[a + 3]}]";
            }
            //LAST STREET
            else if (board.ColumnNumber(a) == 1 && board.StreetIndex(a) == 2) //FIRST NUM IN THIRD STREET
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 1]}|{RouletteWheel.Numbers[a + 2]}]" +
                    $" and [{RouletteWheel.Numbers[a - 1]}|{RouletteWheel.Numbers[a - 2]}|{RouletteWheel.Numbers[a - 3]}]";
            }
            else if (board.ColumnNumber(a) == 2 && board.StreetIndex(a) == 2) //SECOND NUM IN THIRD STREET
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a - 1]}|{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 1]}]" +
                    $" and [{RouletteWheel.Numbers[a - 2]}|{RouletteWheel.Numbers[a - 3]}|{RouletteWheel.Numbers[a - 4]}]";
            }
            else if (board.ColumnNumber(a) == 3 && board.StreetIndex(a) == 2) //THIRD NUM IN THIRD STREET
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a - 2]}|{RouletteWheel.Numbers[a - 1]}|{RouletteWheel.Numbers[a]}]" +
                    $" and [{RouletteWheel.Numbers[a - 3]}|{RouletteWheel.Numbers[a - 4]}|{RouletteWheel.Numbers[a - 5]}]";
            }
            else
            {
                output = "Error in Lines switch.";
            }
            return output;
        }
    }
}
