using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDispenser
{
    public class Program
    {
        internal List<double> cart = new List<double>();
        internal List<string> menu = new List<string>();

        static void Main(string[] args)
        {
            //Greet the user
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hey! And welcome to CruXial's 'Food Dispenser'");
            Console.WriteLine("Press <ENTER> to continue!\n\n");

            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("\n");

                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            //Inform the user
            Console.WriteLine("Available commands:\n!balance\n!stop");

            var Balance = 0;
            var cokePrice = 2.23;

            Console.ForegroundColor = ConsoleColor.Yellow;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("\n");
                Console.WriteLine("Execute a command..");
                Console.WriteLine("\n");

                Console.ForegroundColor = ConsoleColor.Yellow;

                var readLine = Console.ReadLine();

                if(readLine.ToLower() == "!stop")
                {
                    Console.WriteLine("See ya, Come again!");

                    break;
                }

                if (readLine.ToLower() == "!balance")
                {
                    Console.WriteLine($"You currently have ${Balance} on your account.");
                }

                if (readLine.ToLower() == "!addmoney")
                {
                    Console.WriteLine("How much money do you want to add?");
                    Console.WriteLine("10");
                    Console.WriteLine("50");
                    Console.WriteLine("100");

                    string input = Console.ReadLine();

                    string[] values = new[] { "10", "50", "100" };
                    if (!values.Any(x => input.Contains(x)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please specify a valid value!");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    if (input.ToLower() == "10")
                    {
                        Balance = Balance + 10;

                        Console.WriteLine($"$10 has been added to your account! You now have ${Balance}");
                    }

                    if (input.ToLower() == "50")
                    {
                        Balance = Balance + 50;

                        Console.WriteLine($"$50 has been added to your account! You now have ${Balance}");
                    }

                    if (input.ToLower() == "100")
                    {
                        Balance = Balance + 100;

                        Console.WriteLine($"$100 has been added to your account! You now have ${Balance}");
                    }
                }
                if (readLine.ToLower() == "!menu")
                {
                    menu = new List<string> { "Coke ($2,23)\n", "MtnDew ($1,3)\n" };

                    Console.WriteLine(String.Join("", menu));
                    Console.WriteLine("\n \n");

                    Task.Delay(1000);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Would you like to add something to your cart?");

                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        Console.WriteLine("Type the name of the item you want to add to your cart");

                        switch (Console.ReadLine().ToLower())
                        {
                            case "coke":
                                
                                break;

                            default:
                                Console.WriteLine("Invalid item!");
                                break;
                        }

                    }
                }

                if(readLine.ToLower() == "!test")
                {
                    if (int.TryParse(Console.ReadLine(), out int amount))
                    {

                        cart.Add(amount * cokePrice);

                        Console.WriteLine($"{amount} cokes has been added to your cart!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please specify a valid number!");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }

                    if(Console.ReadLine().ToLower() == "paste")
                    {
                        Console.WriteLine(String.Join("", cart));

                        cart.Clear();
                    }
                }
            } 
            //end of loop
        }

        static void errorMessage(string[] args)
        {
            Console.WriteLine($"You have ran straight into a wild error! Invalid: {0}");
        }

        static void CokePrice(string[] args)
        {
            Console.WriteLine("Alrighty! How many do you want to add?");

            if (int.TryParse(Console.ReadLine(), out int amount))
            {

                cart.Add(cokePrice * amount);

                Console.WriteLine($"{amount} cokes has been added to your cart!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please specify a valid number!");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
        }
    }
}