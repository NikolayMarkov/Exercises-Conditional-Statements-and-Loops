using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string drinker = Console.ReadLine();
            double quantity = int.Parse(Console.ReadLine());
            double sum = 0;
            

            if (drinker == "Athlete")
            {
                sum = 0.7*quantity;
                Console.WriteLine($"The {drinker} has to pay {sum:f2}.");
            }
            else if (drinker == "Businessman" || drinker == "Businesswoman")
            {
                sum = 1.00 * quantity;
                Console.WriteLine($"The {drinker} has to pay {sum:f2}.");
            }
            else if (drinker == "SoftUni Student")
            {
                sum = 1.70 * quantity;
                Console.WriteLine($"The {drinker} has to pay {sum:f2}.");
            }
            else 
            {
                sum = 1.20 * quantity;
                Console.WriteLine($"The {drinker} has to pay {sum:f2}.");
            }
            //0.70	1.00	1.70	1.20

        }
    }
}
