using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendigMachine01
{
    class Food : FoodAbstract
    {
        Program machine = new Program();

        public override void BuyFood()
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("Buy Food here: ?");
                Console.WriteLine($"Your current money: {Cash.CashPool}kr.");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($" [S] to buy a {Program.Names[0]} for {Cash.Prices[0]}kr.");
                Console.WriteLine($" [P] to buy a {Program.Names[1]} for {Cash.Prices[1]}kr.");
                Console.WriteLine($" [H] to buy a {Program.Names[2]} for {Cash.Prices[2]}kr.");
                Console.WriteLine($" [B] to go back.");

                var choose = Console.ReadKey(true);

                switch (choose.Key)
                {
                    case ConsoleKey.S:
                        if (Cash.CashPool >= Cash.Prices[0])
                        {
                            Cash.CashPool = Cash.CashPool - Cash.Prices[0];
                            a++;
                            Console.WriteLine($"You have bought the {Program.Names[0]} for {Cash.Prices[0]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            cash.NoCash();
                        }
                        break;
                    case ConsoleKey.P:
                        if (Cash.CashPool >= Cash.Prices[1])
                        {
                            Cash.CashPool = Cash.CashPool - Cash.Prices[1];
                            b++;
                            Console.WriteLine($"You have bought the {Program.Names[1]} for {Cash.Prices[1]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            cash.NoCash();
                        }
                        break;
                    case ConsoleKey.H:
                        if (Cash.CashPool >= Cash.Prices[2])
                        {
                            Cash.CashPool = Cash.CashPool - Cash.Prices[2];
                            c++;
                            Console.WriteLine($"You have bought the {Program.Names[2]} for {Cash.Prices[2]}kr.");
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
        public override void UseFood()
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What kind of food do you want to use?");
                Console.WriteLine($"Your current money: {Cash.CashPool}kr.");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($" [S] to use the {Program.Names[0]}, you have {a} left.");
                Console.WriteLine($" [P] to use the {Program.Names[1]}, you have {b} left.");
                Console.WriteLine($" [H] to use the {Program.Names[2]}, you have {c} left.");
                Console.WriteLine(" [B] to go back.");

                var choose = Console.ReadKey(true);
                switch (choose.Key)
                {
                    case ConsoleKey.S:
                        if (a > 0)
                        {
                            a--;
                            Console.WriteLine($"You ate the {Program.Names[0]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"You do not have any {Program.Names[0]}");
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.P:
                        if (b > 0)
                        {
                            b--;
                            Console.WriteLine($"You ate the {Program.Names[1]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"You dt have any {Program.Names[1]}");
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.H:
                        if (c > 0)
                        {
                            c--;
                            Console.WriteLine($"You ate the {Program.Names[2]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"You do not have any {Program.Names[2]}");
                            Console.ReadKey();
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
        public override void ExamineFood()              
        {
            End = false;
            while (End == false)                        
            {
                Console.Clear();
                Console.WriteLine("What kind of food do you want to examine?");                 
                Console.WriteLine($"Your current money: {Cash.CashPool}kr.");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($" [S] to examine the {Program.Names[0]}, {Cash.Prices[0]}kr.");
                Console.WriteLine($" [P] to examine the {Program.Names[1]}, {Cash.Prices[1]}kr.");
                Console.WriteLine($" [H] to examine the {Program.Names[2]}, {Cash.Prices[2]}kr.");
                Console.WriteLine(" [B] to go back.");

                var choose = Console.ReadKey(true);                 
                switch (choose.Key)
                {
                    case ConsoleKey.S:                                  
                        Console.WriteLine("\n" + Program.Desc[0]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine("\n" + Program.Desc[1]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.H:
                        Console.WriteLine("\n" + Program.Desc[2]);
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
