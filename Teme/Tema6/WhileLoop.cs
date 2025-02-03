using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tema6
{
    static class LoopsTraining
    {

        [Test]
        public static void WhileMethod()
        {
            //We have the start and limit: 1 to 99 and skip value 10
            int counter = 0;
            int limitValue = 99;
            while (counter <= limitValue)
            {
                counter++;
                if (counter != 10)
                {
                    Console.Write($"{counter}; ");
                    continue;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Number skipped!");
                    while (counter < limitValue)
                    {
                        counter++;
                        Console.Write($"{counter}; ");
                        if (counter == limitValue - 1)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Cannot count past 99!");
                            break;
                        }
                     }
                    break;
                }
            }
        }
    }
}