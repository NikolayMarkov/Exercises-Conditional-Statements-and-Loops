using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;

            for (int i = num1; i >= 1; i --)
            {
                for (int j = 1; j <=num2; j++)
                {
                    if (sum >= max)
                    {
                        break;
                    }
                    else
                    {
                        sum += 3 * (i * j);
                        counter++;
                    }
                }
            }
            if (sum >= max)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum} >= {max}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
