using System;
using System.Collections.Generic;
using System.Text;

namespace Freestyle.Difficulties
{
    public class Difficulties
    {
        public static void FreestyleEz()
        {
            Random random = new Random();

            switch (random.Next(1, 6 + 1))
            {
                case 1:
                    Console.WriteLine("Bomb");
                    break;

                case 2:
                    Console.WriteLine("Plane");
                    break;

                case 3:
                    Console.WriteLine("Line");
                    break;

                case 4:
                    Console.WriteLine("Lake");
                    break;

                case 5:
                    Console.WriteLine("Shore");
                    break;

                case 6:
                    Console.WriteLine("Bowling");
                    break;
            }
        }

        public static void FreestyleMed()
        {
            Random random = new Random();

            switch (random.Next(1, 6 + 1))
            {
                case 1:
                    Console.WriteLine("School");
                    break;

                case 2:
                    Console.WriteLine("Shot");
                    break;

                case 3:
                    Console.WriteLine("Skate");
                    break;

                case 4:
                    Console.WriteLine("Drone");
                    break;

                case 5:
                    Console.WriteLine("Set");
                    break;

                case 6:
                    Console.WriteLine("Code");
                    break;
            }
        }

        public static void FreestyleHard()
        {
            Random random = new Random();

            switch (random.Next(1, 6 + 1))
            {
                case 1:
                    Console.WriteLine("Honey");
                    break;

                case 2:
                    Console.WriteLine("University");
                    break;

                case 3:
                    Console.WriteLine("Neighbour");
                    break;

                case 4:
                    Console.WriteLine("City");
                    break;

                case 5:
                    Console.WriteLine("Alaska");
                    break;

                case 6:
                    Console.WriteLine("Bastard");
                    break;
            }
        }
    }
}
