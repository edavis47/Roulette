using RouletteGame.Bets;
using System;
using System.Text;

namespace RouletteGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            do
            {
                try
                {
                    Console.Clear();
                    int spin = rand.Next(0, 38);
                    int rando = int.Parse(RouletteWheel.Numbers[spin]);
                    Console.WriteLine(DisplayResults(rando));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        static string DisplayResults(int a)
        {
            Column column = new Column();
            Corner corner = new Corner();
            Dozen dozen = new Dozen();
            Line line = new Line();
            Low_High lowhigh = new Low_High();
            Odd_Even oddeven = new Odd_Even();
            Red_Black colors = new Red_Black();
            Split split = new Split();
            StraightUp straight = new StraightUp();
            Street street = new Street();

            StringBuilder dislay = new StringBuilder();
            dislay.Append("                          ~ VIRTUAL  ROULETTE  CROUPIER ~\n");
            dislay.Append("                             Press \"ENTER\" to go again.\n");
            dislay.Append("                              Press \"ESC\" key to exit.\n\n");
            dislay.Append($"                       BIN NUMBER : {a}         BIN COLOR : {RouletteWheel.Colors[a]}\n");
            dislay.Append($" WINNING INSIDE BETS - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            dislay.Append($"  Straight(35:1) = {straight.StraightBet(a)}\n");
            dislay.Append($"    Splits(17:1) = {split.SplitBets(a)}\n");
            dislay.Append($"    Street(11:1) = {street.StreetBet(a)}\n");
            dislay.Append($"    Corners(8:1) = {corner.CornerBets(a)}\n");
            dislay.Append($"  Lines/Double Streets(5:1) = {line.LineBet(a)}\n");
            dislay.Append($" WINNING OUTSIDE BETS - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            dislay.Append($"     Color(1:1) = {colors.RedBlack(a)}\n");
            dislay.Append($"  Odd/Even(1:1) = {oddeven.OddOrEven(a)}\n");
            dislay.Append($"  High/Low(1:1) = {lowhigh.LowHighBet(a)}\n");
            dislay.Append($"     Dozen(2:1) = {dozen.DozensBets(a)}\n");
            dislay.Append($"    Column(2:1) = {column.ColumnBets(a)}");
            return dislay.ToString();
        }
    }
}
