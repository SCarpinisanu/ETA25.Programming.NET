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
            //I will try to create a different approach later
            RezultatVerificare(49);
            RezultatVerificare(0);
            RezultatVerificare(-144);
            RezultatVerificare(44);
        }

        static int numarDeVerificat;
        
        private static void RezultatVerificare(int numarDeVerificat)
        {
            if (numarDeVerificat % 2 == 0 & numarDeVerificat > 0)
            {
                Console.WriteLine($"Numarul {numarDeVerificat} este par pozitiv.");
            }
            else if (numarDeVerificat % 2 == 0 & numarDeVerificat < 0)
            {
                Console.WriteLine($"Numarul {numarDeVerificat} este par negativ.");   
            }
            else
            {
                Console.WriteLine($"Numrul {numarDeVerificat} nu este par.");  
            }
        }

    }
}
