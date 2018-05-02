using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendigMachine01
{
    class Change
    {
        public static List<int> YourCash = new List<int>();

        public void CashChange()
        {
            while (Cash.CashPool > 0)
            {
                while (Cash.CashPool >= Cash.SortOfCash[7])
                {
                    Cash.CashPool = Cash.CashPool - Cash.SortOfCash[7];
                    YourCash.Add(Cash.SortOfCash[7]);
                }
                while (Cash.CashPool >= Cash.SortOfCash[6])
                {
                    Cash.CashPool = Cash.CashPool - Cash.SortOfCash[6];
                    YourCash.Add(Cash.SortOfCash[6]);
                }
                while (Cash.CashPool >= Cash.SortOfCash[5])
                {
                    Cash.CashPool = Cash.CashPool - Cash.SortOfCash[5];
                    YourCash.Add(Cash.SortOfCash[5]);
                }
                while (Cash.CashPool >= Cash.SortOfCash[4])
                {
                    Cash.CashPool = Cash.CashPool - Cash.SortOfCash[4];
                    YourCash.Add(Cash.SortOfCash[4]);
                }
                while (Cash.CashPool >= Cash.SortOfCash[3])
                {
                    Cash.CashPool = Cash.CashPool - Cash.SortOfCash[3];
                    YourCash.Add(Cash.SortOfCash[3]);
                }
                while (Cash.CashPool >= Cash.SortOfCash[2])
                {
                    Cash.CashPool = Cash.CashPool - Cash.SortOfCash[2];
                    YourCash.Add(Cash.SortOfCash[2]);
                }
                while (Cash.CashPool >= Cash.SortOfCash[1])
                {
                    Cash.CashPool = Cash.CashPool - Cash.SortOfCash[1];
                    YourCash.Add(Cash.SortOfCash[1]);
                }
                while (Cash.CashPool >= Cash.SortOfCash[0])
                {
                    Cash.CashPool = Cash.CashPool - Cash.SortOfCash[0];
                    YourCash.Add(Cash.SortOfCash[0]);
                }

            }
            Console.Clear();
            Console.WriteLine("Your change:");
            foreach (int item in YourCash)
            {
                Console.WriteLine($"One {item}kr.");
            }
        }
    }
}
