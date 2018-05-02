using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendigMachine01
{
    class Cash
    {
        public static int[] SortOfCash = new int[8] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public static int CashPool = 0;
        public static int[] Prices = new int[9] { 30, 60, 105, 255, 330, 15, 455, 625, 85 };

        public void AddCash()
        {
            bool End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("CHOOSE CASH: ");
                Console.WriteLine("\n1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr, 1000kr");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Enter 0 to go Back");
                Console.WriteLine($"\nYou got: {CashPool}kr ");

                string ChooseCash = Console.ReadLine();

                if (int.TryParse(ChooseCash, out int result) && result == 1)
                {
                    CashPool = CashPool + SortOfCash[0];
                }
                else if (int.TryParse(ChooseCash, out result) && result == 5)
                {
                    CashPool = CashPool + SortOfCash[1];
                }
                else if (int.TryParse(ChooseCash, out result) && result == 10)
                {
                    CashPool = CashPool + SortOfCash[2];
                }
                else if (int.TryParse(ChooseCash, out result) && result == 20)
                {
                    CashPool = CashPool + SortOfCash[3];
                }
                else if (int.TryParse(ChooseCash, out result) && result == 50)
                {
                    CashPool = CashPool + SortOfCash[4];
                }
                else if (int.TryParse(ChooseCash, out result) && result == 100)
                {
                    CashPool = CashPool + SortOfCash[5];
                }
                else if (int.TryParse(ChooseCash, out result) && result == 500)
                {
                    CashPool = CashPool + SortOfCash[6];
                }
                else if (int.TryParse(ChooseCash, out result) && result == 1000)
                {
                    CashPool = CashPool + SortOfCash[7];
                }
                else if (int.TryParse(ChooseCash, out result) && result == 0)
                {
                    End = true;
                }
                else if (!int.TryParse(ChooseCash, out result))
                {
                    Console.WriteLine("Not a number, try again");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Not a correct number, try again");
                    Console.ReadKey();
                }
            }
        }
        public void NoCash()
        {
            Console.WriteLine("You do not have enough cash");
            Console.ReadKey();
        }
    }
}
