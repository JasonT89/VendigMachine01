using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendigMachine01
{
    class Program
    {
        public static string[] Names = new string[9] { "Salad", "Pineapple", "Hot-Dog", "Juice", "Coffee", "Water", "Samsung ", "Nokia ", "Iphone", };

        public static string[] Desc = new string[9] {"Iceberg lettuce", "Fruit from hot countries.", "Hot sausage with bread.", "Soft lemon drink.", "Energy drink that is bitter and with liqour.", "Plain water from Mount Everest.", "Phone Android.", "Phone iOS.", "Phone Android." };

        static void Main(string[] args)
        {
            Cash cash = new Cash();
            DoWhat doWhat = new DoWhat();
            Change change = new Change();

            bool EndProgram = false;
            while (EndProgram == false)
            {
                Console.Clear();

                Console.WriteLine("\t\t\t\t\tWHAT DO YOU WANT TO DO?");
                Console.WriteLine("\n\t[A] - Add Cash, [B]- Buy products, [U] - Use products, [E] to examine products, [S] - Stop shopping");    
                Console.WriteLine("\t---------------------------------------------------------------------------------------------------");
                Console.WriteLine($"\t\t\t\t\tYou currently have: {Cash.CashPool}kr.");
                

                var startChoose = Console.ReadKey(true);

                switch (startChoose.Key)
                {
                    case ConsoleKey.A:
                        cash.AddCash();                       
                        break;
                        
                    case ConsoleKey.B:
                        doWhat.BuyWhat();
                        break;

                    case ConsoleKey.U:
                        doWhat.UseWhat();
                        break;

                    case ConsoleKey.E:                                          
                        doWhat.ExamineWhat();
                        break;

                    case ConsoleKey.S:
                        EndProgram = true;
                        change.CashChange();
                        Console.ReadKey();
                        break;


                    default:
                        WrongInput();
                        break;
                        
                }
                
            }

        }
        public static void WrongInput()
        {
            Console.WriteLine("Wrong input, try again.");
            Console.ReadKey(true);
        }

    }
}
