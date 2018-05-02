using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendigMachine01
{
    class DoWhat
    {
        Food food = new Food();
        Drink drink = new Drink();
        Phone phone = new Phone();
        Program machine = new Program();

        public void BuyWhat()
        {
            bool End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What do you want to buy?");
                Console.WriteLine($"Your current money: {Cash.CashPool}kr.");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(" [F] to buy food.");
                Console.WriteLine(" [D] to buy drinks.");
                Console.WriteLine(" [P] to buy phones.");
                Console.WriteLine(" [B] to go back.");

                var choose = Console.ReadKey();
                switch (choose.Key)
                {
                    case ConsoleKey.F:
                        food.BuyFood();
                        break;
                    case ConsoleKey.D:
                        drink.BuyDrinks();
                        break;
                    case ConsoleKey.P:
                        phone.BuyPhone();
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

        public void UseWhat()
        {
            bool End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What do you want to use?");
                Console.WriteLine($"Your current money: {Cash.CashPool}kr.");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(" [F] to use food.");
                Console.WriteLine(" [D] to use drinks.");
                Console.WriteLine(" [P] to use phone.");
                Console.WriteLine(" [B] to go back.");

                var choose = Console.ReadKey();
                switch (choose.Key)
                {
                    case ConsoleKey.F:
                        food.UseFood();
                        break;
                    case ConsoleKey.D:
                        drink.UseDrinks();
                        break;
                    case ConsoleKey.P:
                        phone.UsePhone();
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
        public void ExamineWhat()
        {
            bool End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What do you want do examine?");                             
                Console.WriteLine($"Your current money: {Cash.CashPool}kr.");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(" [F] to examine foods.");
                Console.WriteLine(" [D] to examine drinks.");
                Console.WriteLine(" [P] to examine phone.");
                Console.WriteLine(" [B] to go back.");

                var choose = Console.ReadKey();
                switch (choose.Key)
                {
                    case ConsoleKey.F:                                          
                        food.ExamineFood();
                        break;
                    case ConsoleKey.D:                                         
                        drink.ExamineDrinks();
                        break;
                    case ConsoleKey.P:                                          
                        phone.ExaminePhone();
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
