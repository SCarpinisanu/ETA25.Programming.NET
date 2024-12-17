using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesiune3.Methods
{
    public class MyFirstMethod
    {

        [Test]
        public void MetodaTest()
        {
            SumaNumere();
            SumaNumere(33, 25);
            SumaNumere(4, 8, 17);

            double rezultat = GetResult(256, 478);
            Console.Write(rezultat);
        }

        public void SumaNumere()
        {

            int a = 25;
            int b = 38;
            int suma = a + b;
            Console.WriteLine(a + " + " + b + " = " + suma);
        }

        public void SumaNumere(int numar1, int numar2)
        {
            int sum = numar1 + numar2;
            Console.WriteLine(numar1 + " + " + numar2 + " + " + " = " + sum);
        }

        public void SumaNumere(int x, int y, int z)
        {
            int sum = x + y + z;
            Console.WriteLine(x + " + " + y + " + " + z + " = " + sum);
        }

        public int GetResult(int alfa, int beta)
        {
            int sum = alfa + beta;
            Console.Write(alfa + " + " + beta + " = ");
            return sum;
        }
    }
}
