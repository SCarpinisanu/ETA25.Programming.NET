using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tema6
{
    static class DoWhileLoop
    {

        [Test]
        public static void DoWhileMethod()
        {
            CountSkipFinish(200);
        }

        private static void CountSkipFinish(int finishValue)
        {
            int counter = 0;
            do
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
                    Console.WriteLine($"Number skipped!");
                    do
                    {
                        counter++;
                        Console.Write($"{counter}; ");
                        //counter++;
                        if (counter == 98 )
                        {
                            counter++;
                            break;
                        }
                    }
                    while (counter < finishValue);
                }

                Console.WriteLine("");
                Console.WriteLine($"Cannot count past {counter}!");
                Console.WriteLine($"The limit for the count was {finishValue}");
                break;
            }
            while (counter < finishValue);
        }
    }
}