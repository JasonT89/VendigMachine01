using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendigMachine01
{
    class Phone : PhoneAbstract
    {
        Program machine = new Program();

        public override void BuyPhone()
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What kind of phone do you want to buy?");
                Console.WriteLine($"Your current money: {Cash.CashPool}kr.");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($" [S] to buy a {Program.Names[6]} for {Cash.Prices[6]}kr.");
                Console.WriteLine($" [N] to buy a {Program.Names[7]} for {Cash.Prices[7]}kr.");
                Console.WriteLine($" [I] to buy a {Program.Names[8]} for {Cash.Prices[8]}kr.");               
                Console.WriteLine($" [B] to go back.");


                var choose = Console.ReadKey(true);
                switch (choose.Key)
                {
                    case ConsoleKey.S:
                        if (Cash.CashPool >= Cash.Prices[6])
                        {
                            Cash.CashPool = Cash.CashPool - Cash.Prices[6];
                            a++;
                            Console.WriteLine($"You have bought the {Program.Names[6]} for {Cash.Prices[6]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            cash.NoCash();
                        }
                        break;
                    case ConsoleKey.N:
                        if (Cash.CashPool >= Cash.Prices[7])
                        {
                            Cash.CashPool = Cash.CashPool - Cash.Prices[7];
                            b++;
                            Console.WriteLine($"You have bought the {Program.Names[7]} for {Cash.Prices[7]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            cash.NoCash();
                        }
                        break;
                    case ConsoleKey.I:
                        if (Cash.CashPool >= Cash.Prices[8])
                        {
                            Cash.CashPool = Cash.CashPool - Cash.Prices[8];
                            c++;
                            Console.WriteLine($"You have bought the {Program.Names[8]} for {Cash.Prices[8]}kr.");
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

       
        public override void UsePhone()
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What kind of phone do you want to use?");
                Console.WriteLine($"Your current money: {Cash.CashPool}kr.");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($" [S] to use the {Program.Names[6]}, you have {a} left.");
                Console.WriteLine($" [N] to use the {Program.Names[7]}, you have {b} left.");
                Console.WriteLine($" [I] to use the {Program.Names[8]}, you have {c} left.");
                Console.WriteLine(" [B] to go back.");

                var choose = Console.ReadKey(true);
                switch (choose.Key)
                {
                    case ConsoleKey.S:
                        if (a > 0)
                        {
                            a--;
                            Console.WriteLine($"You used the {Program.Names[6]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"You do not have any {Program.Names[6]}");
                        }
                        break;
                    case ConsoleKey.N:
                        if (b > 0)
                        {
                            b--;
                            Console.WriteLine($"You used the {Program.Names[7]}");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"You do not have any {Program.Names[7]}");
                        }
                        break;
                    case ConsoleKey.I:
                        if (c > 0)
                        {
                            c--;
                            Console.WriteLine($"You used the {Program.Names[8]}");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"You do not have any {Program.Names[8]}");
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
        public override void ExaminePhone()
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What kind of phone do you want to examine?");
                Console.WriteLine($"Your current money: {Cash.CashPool}kr.");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($" [S] to examine the {Program.Names[6]}, {Cash.Prices[6]}kr.");                                
                Console.WriteLine($" [N] to examine the {Program.Names[7]}, {Cash.Prices[7]}kr.");
                Console.WriteLine($" [I] to examine the {Program.Names[8]}, {Cash.Prices[8]}kr.");
                Console.WriteLine(" [B] to go back.");

                var choose = Console.ReadKey(true);
                switch (choose.Key)
                {
                    case ConsoleKey.S:
                        Console.WriteLine("\n" + Program.Desc[6]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.I:
                        Console.WriteLine("\n" + Program.Desc[7]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.N:
                        Console.WriteLine("\n" + Program.Desc[8]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.B:
                        End = true;
                        break;
                    default:
                        Program.WrongInput();
                        Console.ReadKey();
                        break;
                }
            }
        }

    }
}
