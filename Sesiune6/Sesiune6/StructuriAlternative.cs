using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sesiune6
{
    public class StructuriAlternative()
    {
        [Test]
        public void Test()
        {
            ComparareNumare(8, 6);
            ComparareNumare(4, 4);
            ComparareNumare(2, 19);
            VerificareNumar(7);
            VerificareNumar(-3);
            VerificareNumar(0);
            AlegereMarcaAuto("Maybach");
            AlegereMarcaAuto("Ferrari");
            AlegereMarcaAuto("Volvo");
            AlegereMarcaAuto("Lamborghini");
            AlegereMarcaAuto("BMW");
        }

        public void ComparareNumare(int a, int b)
        {
            if (a > b)
            {
                //Folosim concatenarea cu simbolul $
                Console.WriteLine($"Numarul {a} este mai mare decat numarul {b}");
            }
            else if (a<b)
            {
                Console.WriteLine($"Numarul {a} este mai mic decat numarul {b}");
            }
            else
            {
                Console.WriteLine("Numarul {a} este egal cu numarul {b}");
            }
        }

        public void VerificareNumar(int x)
        {
            if (x > 0)
            {
                Console.WriteLine($"Numarul {x} este numar pozitiv.");
            }
            else if (x < 0)
            {
                Console.WriteLine("Numarul {x} este numar negativ.");
            }
            else
            {
                Console.WriteLine("Numarul {x} este zero.");
            }
        }

        public void AlegereMarcaAuto(string Masina)
        {
            switch (Masina)
            {
                case "Ferrari":
                    Console.WriteLine("Avem Ferrari pe stoc fara numar, fara numar");
                    break;

                case "Lamborghini":
                    Console.WriteLine("Avem pe stoc si Lamborghini, dar 'este' mai putine");
                    break;
                
                case "BMW":
                    Console.WriteLine("Avem si BMW-uri, de la pretenul lui Iohannis");
                    break;
                
                case "Maybach":
                    Console.WriteLine("D'astea avem una sau doua, ca una a luat-o Jiji");
                    break;

                default:
                    Console.WriteLine("Marca de masina cautata nu se gaseste la noi in garaj. Mai incearca");
                    break;
            }
        }
    }
}
