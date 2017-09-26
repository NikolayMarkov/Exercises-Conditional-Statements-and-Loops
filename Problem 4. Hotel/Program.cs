using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string months = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());

            double totallSumStudio = 0;
            double totallSumDouble = 0;
            double totallSumStuite = 0;

            if (months == "May" || months == "October")
            {
                totallSumStudio = 50 * nights;
                totallSumDouble = 65 * nights;
                totallSumStuite = 75 * nights;
            }
            else if (months == "June" || months == "September")
            {
                totallSumStudio = 60 * nights;
                totallSumDouble = 72 * nights;
                totallSumStuite = 82 * nights;
            }
            else if (months == "July" || months == "August" || months == "December")
            {
                totallSumStudio = 68 * nights;
                totallSumDouble = 77 * nights;
                totallSumStuite = 89 * nights;
            }

            if (nights > 7 && months == "September")
            {
                totallSumStudio = totallSumStudio - 60;
                nights--;
            }
            else if (nights > 7 && months == "October")
            {
                totallSumStudio = totallSumStudio - 50;
                nights--;
            }

            if (nights > 7 && months == "May" )
            {
                totallSumStudio = totallSumStudio * 0.95;
            }
            else if (nights > 7 && months == "October")
            {
                totallSumStudio = totallSumStudio * 0.95;
            }
            else if (nights > 14 && months == "June" )
            {
                totallSumDouble = totallSumDouble * 0.9;
            }
            else if (nights > 14 && months == "September")
            {
                totallSumDouble = totallSumDouble * 0.9;
            }
            else if (nights > 14 && months == "July" )
            {
                totallSumStuite = totallSumStuite * 0.85;
            }
            else if (nights > 14 && months == "August")
            {
                totallSumStuite = totallSumStuite * 0.85;
            }
            else if (nights > 14 && months == "July")
            {
                totallSumStuite = totallSumStuite * 0.85;
            }

          


            Console.WriteLine($"Studio: {totallSumStudio:f2} lv.");
            Console.WriteLine($"Double: {totallSumDouble:f2} lv.");
            Console.WriteLine($"Suite: {totallSumStuite:f2} lv.");
          


        }
    }
}
