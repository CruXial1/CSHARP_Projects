using System;
using System.Collections.Generic;
using System.Threading;
using Freestyle.Difficulties;

namespace Freestyle_Console
{
    class Program : Difficulties
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("CruXial's simple freestyle assistant v 1.0 \n \n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Hello there and welcome, to procced press <ENTER>");

            if(Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("\n");
                return;
            }
            
            Console.WriteLine("\nType one of the following difficulties: \n Easy \n Medium \n Hard\n\n");

            Console.Write("Your preferred difficulty here: ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            var readLine = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;

            if (readLine.ToLower() == "easy")
            {
                Console.WriteLine("\n");
                while (true)
                {
                    FreestyleEz();
                    Thread.Sleep(3000);
                }
            }

            if (readLine.ToLower() == "medium")
            {
                Console.WriteLine("\n");
                while (true)
                {
                    FreestyleMed();
                    Thread.Sleep(3000);
                }
            }

            if (readLine.ToLower() == "hard")
            {
                Console.WriteLine("\n");
                while (true)
                {
                    FreestyleHard();
                    Thread.Sleep(3000);
                }
            }

            return;
        }
    }
}