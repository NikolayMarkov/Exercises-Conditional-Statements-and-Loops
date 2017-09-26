using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hallName = null; 
            double totallSum = 0;
            double discount = 0;

            if (people <= 50)
            {
                hallName = "Small Hall";
                totallSum += 2500;
            }
            else if (people > 50 && people <= 100)
            {
                hallName = "Terrace";
                totallSum += 5000;
            }
            else if (people > 100 && people <= 120)
            {
                hallName = "Great Hall";
                totallSum += 7500;
            }
            else if (people > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
           

            if (package == "Normal" && people < 120)
            {
                discount = 0.95;
                totallSum = (500 + totallSum) * discount;
            }
            else if (package == "Gold" && people < 120)
            {
                discount = 0.9;
                totallSum = (750 + totallSum) * discount;    
            }
            else if (package == "Platinum" && people < 120)
            {
                discount = 0.85;
                totallSum = (1000 + totallSum) * discount;
               
            }
            double sumPerPerson = totallSum / people;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {sumPerPerson:f2}$");
        }
    }
}
