using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3
{
    static class VerificareNumarPar
    {
        [Test]
        public static void VerificareNumarParTest()
        {
            VerificareNumar(-52);
        }

        static int VerificareNumar(int numarDeVerificat)
        {
            static int numarDeVerificat;

            if (numarDeVerificat % 2 = 0 & numarDeVerificat > 0)
            {
                Console.WriteLine($"Numarul {numarDeVerificat} este par pozitiv");
            }
            else if (numarDeVerificat % 2 = 0 & numarDeVerificat < 0)
            {
                Console.WriteLine($"Numarul {numarDeVerificat} este par negativ");
            }
            else
            {
                Console.WriteLine($"Numarul {numarDeVerificat} nu este par sau este zero");
            }
        }
    }
}
