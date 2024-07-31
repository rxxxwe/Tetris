using System;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = 2;
            int y1 = 3;
            char c1 = '*';

            Console.SetCursorPosition(x1, y1);
            Console.Write(c1);

            Console.ReadLine();
        }
    }
}