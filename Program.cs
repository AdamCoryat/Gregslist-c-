using System;
using Gregslist.Controllers;

namespace Gregslist
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hellowworld");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            

            new MenuController().Run();

        }
    }
}
