using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendigMachine01
{
    class Drink : DrinksAbstract
    {
        Program machine = new Program();

        public override void BuyDrinks()
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What typ of drink do you want to buy?");
                Console.WriteLine($"Your current money: {Cash.CashPool}kr.");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($" [J] to buy a {Program.Names[3]} for {Cash.Prices[3]}kr.");
                Console.WriteLine($" [C] to buy a {Program.Names[4]} for {Cash.Prices[4]}kr.");
                Console.WriteLine($" [W] to buy a {Program.Names[5]} for {Cash.Prices[5]}kr.");
                Console.WriteLine($" [B] to go back.");

                var choose = Console.ReadKey(true);
                switch (choose.Key)
                {
                    case ConsoleKey.J:
                        if (Cash.CashPool >= Cash.Prices[3])
                        {
                            Cash.CashPool = Cash.CashPool - Cash.Prices[3];
                            a++;
                            Console.WriteLine($"You have bought the {Program.Names[3]} for {Cash.Prices[3]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            cash.NoCash();
                        }
                        break;
                    case ConsoleKey.C:
                        if (Cash.CashPool >= Cash.Prices[4])
                        {
                            Cash.CashPool = Cash.CashPool - Cash.Prices[4];
                            b++;
                            Console.WriteLine($"\nYou have bought the {Program.Names[4]} for {Cash.Prices[4]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            cash.NoCash();
                        }
                        break;
                    case ConsoleKey.W:
                        if (Cash.CashPool >= Cash.Prices[5])
                        {
                            Cash.CashPool = Cash.CashPool - Cash.Prices[5];
                            c++;
                            Console.WriteLine($"You have bought the {Program.Names[5]} for {Cash.Prices[5]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            cash.NoCash();
                        }
                        break;
                    case ConsoleKey.B:
                        End = true;
                        break;
                    default:
                        Program.WrongInput();
                        break;
                }
            }
        }

 

        public override void UseDrinks()
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What kind of drink do you want to use?");
                Console.WriteLine($"Your current money: {Cash.CashPool}kr.");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($" [J] to use the {Program.Names[3]}, you have {a} left.");
                Console.WriteLine($" [C] to use the {Program.Names[4]}, you have {b} left.");
                Console.WriteLine($" [W] to use the {Program.Names[5]}, you have {c} left.");
                Console.WriteLine(" [B] to go back.");

                var choose = Console.ReadKey(true);
                switch (choose.Key)
                {
                    case ConsoleKey.J:
                        if (a > 0)
                        {
                            a--;
                            Console.WriteLine($"You drank the {Program.Names[3]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"You do not have any {Program.Names[3]}");
                        }
                        break;
                    case ConsoleKey.C:
                        if (b > 0)
                        {
                            b--;
                            Console.WriteLine($"You drank the {Program.Names[4]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"You do not have any {Program.Names[4]}");
                        }
                        break;
                    case ConsoleKey.W:
                        if (c > 0)
                        {
                            c--;
                            Console.WriteLine($"You drank the {Program.Names[5]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"You do not have any {Program.Names[5]}");
                        }
                        break;
                    case ConsoleKey.B:
                        End = true;
                        break;
                    default:
                        Program.WrongInput();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        public override void ExamineDrinks()
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What kind of drink do you want to examine?");
                Console.WriteLine($"Your current money: {Cash.CashPool}kr.");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($" [J] to examine the {Program.Names[3]}, {Cash.Prices[3]}kr.");
                Console.WriteLine($" [C] to examine the {Program.Names[4]}, {Cash.Prices[4]}kr.");
                Console.WriteLine($" [W] to examine the {Program.Names[5]}, {Cash.Prices[5]}kr.");
                Console.WriteLine(" [B] to go back.");

                var choose = Console.ReadKey(true);
                switch (choose.Key)
                {
                    case ConsoleKey.J:
                        Console.WriteLine("\n" + Program.Desc[3]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine("\n" + Program.Desc[4]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.W:
                        Console.WriteLine("\n" + Program.Desc[5]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.B:
                        End = true;
                        break;
                    default:
                        Program.WrongInput();
                        break;
                }
            }
        }
    }
}


