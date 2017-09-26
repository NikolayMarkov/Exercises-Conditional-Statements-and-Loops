using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            try
            {
                int num = int.Parse(Console.ReadLine());
                while (num > 0 || num <= 0)
                {
                    counter++;
                    num = int.Parse(Console.ReadLine());
                   
                }
            }
            catch (Exception)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
