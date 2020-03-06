using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteGame.Bets
{
    class Split
    {
        RouletteBoard board = new RouletteBoard();
        public string SplitBets(int a)
        {
            string output;
            if (a < 1)
            {
                output = "No Splits win.";
            }
            //ALL INSIDE STREETS
            //FIRST COLUMN IN INSIDE STREETS
            else if (board.ColumnNumber(a) == 1 && board.StreetIndex(a) == 3)
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a - 3]}]" +
                    $" and [{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 1]}]" +
                    $" and [{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 3]}]";
            }
            //SECOND COLUMN IN INSIDE STREETS
            else if (board.ColumnNumber(a) == 2 && board.StreetIndex(a) == 3)
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a - 3]}]" +
                    $" and [{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a - 1]}]" +
                    $" and [{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 1]}]" +
                    $" and [{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 3]}]";
            }
            //THIRD COLUMN IN INSIDE STREETS
            else if (board.ColumnNumber(a) == 3 && board.StreetIndex(a) == 3)
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a - 3]}]" +
                    $" and [{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a - 1]}]" +
                    $" and [{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 3]}]";
            }

            //FIRST STREET
            //FIRST COLUMN IN FIRST STREET
            else if (board.ColumnNumber(a) == 1 && board.StreetIndex(a) == 1)
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 1]}]" +
                    $" and [{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 3]}]";
            }
            //SECOND COLUMN IN FIRST STREET
            else if (board.ColumnNumber(a) == 2 && board.StreetIndex(a) == 1)
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a - 1]}]" +
                    $" and [{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 1]}];" +
                    $" and [{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 3]}]";
            }
            //THIRD COLUMN IN FIRST STREET
            else if (board.ColumnNumber(a) == 3 && board.StreetIndex(a) == 1)
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a - 1]}]" +
                    $" and [{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 3]}]";
            }

            //LAST STREET
            //FIRST COLUMN IN LAST STREET
            else if (board.ColumnNumber(a) == 1 && board.StreetIndex(a) == 2)
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a - 3]}]" +
                    $" and [{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 1]}]";
            }
            //SECOND COLUMN IN LAST STREET
            else if (board.ColumnNumber(a) == 2 && board.StreetIndex(a) == 2)
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a - 3]}]" +
                    $" and [{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a - 1]}]" +
                    $" and [{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a + 1]}]";
            }
            //THIRD COLUMN IN LAST STREET
            else if (board.ColumnNumber(a) == 3 && board.StreetIndex(a) == 2)
            {
                a += 1; // TO CONVERT NUMBER TO ARRAY INDEX
                output = $"[{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a - 3]}]" +
                    $" and [{RouletteWheel.Numbers[a]}|{RouletteWheel.Numbers[a - 1]}]";
            }
            else
            {
                output = "Error in Splits switch.";
            }
            return output;
        }
    }
}
