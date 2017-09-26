using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            int lastnum = 0;
            int lastnum2 = 0;


            for (int i = num; i <= num2; i++)
            {
                for (int j = num; j <= num2; j++)
                {
                    if (i+j == magicNumber)
                    {
                        lastnum = i;
                        lastnum2 = j;
                    }
                    counter++;
                }
            }
            if (lastnum + lastnum2 == magicNumber)
            {
                Console.WriteLine($"Number found! {lastnum} + {lastnum2} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
