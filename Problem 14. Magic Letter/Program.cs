using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char exseption = char.Parse(Console.ReadLine());

            string result = null;

            for (char i = letter1; i <= letter2; i++)
            {
                for (char k = letter1; k <= letter2; k++)
                {
                    for (char j = letter1; j <= letter2; j++)
                    {
                        result = $"{i}{k}{j}";
                        if (!result.Contains(exseption))
                        {
                            Console.Write(result + " ");
                        }
                    }
                }
            }

        }
    }
}
