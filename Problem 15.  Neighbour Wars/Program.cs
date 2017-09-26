using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoAttack = int.Parse(Console.ReadLine()); //Thunderous fist
            int goshoAttack = int.Parse(Console.ReadLine()); // Roundhouse kick

            int goshoHealth = 100;
            int peshoHealth = 100;

            int restoreHealth = 10;
            int rounds = 1;

            while (peshoHealth > 0 || goshoHealth > 0)
            {
                if (rounds % 2 != 0 && goshoHealth > 0)
                {
                    goshoHealth -= peshoAttack;
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else  if(rounds % 2 == 0 && peshoAttack > 0)
                {
                    peshoHealth -= goshoAttack;
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                else
                {
                    break;
                }
               

                if (rounds % 3 == 0 && (peshoHealth > 0 || goshoHealth > 0))
                {
                    goshoHealth += restoreHealth;
                    peshoHealth += restoreHealth;
                }
                rounds++;
            }
            if (peshoHealth > 0)
            {
                Console.WriteLine($"Pesho won in {rounds}th round."); 
            }
            else
            {
                Console.WriteLine($"Gosho won in {rounds}th round.");
            }
        }
    }
}
