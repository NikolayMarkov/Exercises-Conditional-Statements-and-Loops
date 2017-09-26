using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                noun =  noun.Remove(noun.Length-1);
                Console.WriteLine($"{noun}ies");
            }

            else if (noun.EndsWith("o"))//|| "s" || "sh" || "x" || "z" || "ch"))
            {
                Console.WriteLine($"{noun}es");
            }
            else if (noun.EndsWith("s"))//|| "s" || "sh" || "x" || "z" || "ch"))
            {
                Console.WriteLine($"{noun}es");

            }
            else  if (noun.EndsWith("sh"))//|| "s" || "sh" || "x" || "z" || "ch"))
            {
                Console.WriteLine($"{noun}es");

            }
            else if (noun.EndsWith("x"))//|| "s" || "sh" || "x" || "z" || "ch"))
            {
                Console.WriteLine($"{noun}es");

            }
            else  if (noun.EndsWith("z"))//|| "s" || "sh" || "x" || "z" || "ch"))
            {
               
                Console.WriteLine($"{noun}es");

            }
            else if (noun.EndsWith("ch"))//|| "s" || "sh" || "x" || "z" || "ch"))
            {
             
                Console.WriteLine($"{noun}es");

            }

            else
            {
                Console.WriteLine($"{noun}s");
            }


        }
    }
}
