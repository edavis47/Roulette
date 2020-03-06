using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteGame
{
    class RouletteBoard
    {
        public int[] Column1 = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        public int[] Column2 = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        public int[] Column3 = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
        public int ColumnNumber(int x)
        {
            if (Array.Exists(Column1, element => element == x)) // COLUMN 1
            {
                return 1;
            }
            else if (Array.Exists(Column2, element => element == x)) //COLUMN 2
            {
                return 2;
            }
            else if (Array.Exists(Column3, element => element == x)) //COLUMN 3
            {
                return 3;
            }
            else
            {
                return x;
            }
        }
        
        public int[] firstStreet = new int[] { 1, 2, 3 };
        public int[] lastStreet = new int[] { 34, 35, 36 };
        public int StreetIndex(int x)
        {
            if (Array.Exists(firstStreet, element => element == x)) //First Street
            {
                return 1;
            }
            else if (Array.Exists(lastStreet, element => element == x)) //Last Street
            {
                return 2;
            }
            else // Middle Streets
            {
                return 3;
            }
        }
    }
}
