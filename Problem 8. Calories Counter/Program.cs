using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int callories = 0;

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine().ToLower();
                if (product == "cheese")
                {
                    callories += 500;
                }
                else if (product == "tomato sauce")
                {
                    callories += 150;
                }
                else if (product == "salami")
                {
                    callories += 600;
                }
                else if (product == "pepper")
                {
                    callories += 50;
                }
            }
            Console.WriteLine("Total calories: {0}", callories);
        }
    }
}
