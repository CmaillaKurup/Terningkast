using System;

namespace Terningkast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Random random = new Random();
            int terningskast = random.Next(1, 7);

            switch(terningskast)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du slog en 1'er");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Du slog en 2'er");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Du slog en 3'er");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Du slog en 4'er");
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Du slog en 5'er");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Du slog en 6'er");
                    break;
            }
        }
    }
}