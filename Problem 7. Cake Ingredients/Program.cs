﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numInput = 0;

            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                input = Console.ReadLine();
                numInput++;
            }
            Console.WriteLine($"Preparing cake with {numInput} ingredients.");
        }
    }
}
