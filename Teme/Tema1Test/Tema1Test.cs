using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25.NET.Tema1Test
{

    public class Tema1Test
    {
        [Test]
        public void PrimaTemaTest()
        {
            //Message added in GitHUB - try to commit changes with the solution still open in Visual Studio 2022
            string firstName = "Sorin";
            string lastName = "Carpinisanu";
            string age = "57";
            string gender = "Male";

            //Adding a message in Visual Studio 2022 to push change in GitHUB
            Console.WriteLine("Hello," + "\n");

            Console.WriteLine("Your details are as follows adding new data:");
            Console.WriteLine("    - First Name : " + firstName);
            Console.WriteLine("    - Last Name  : " + lastName);
            Console.WriteLine("    - Gender     : " + gender);
            Console.WriteLine("You will be " + (Convert.ToInt32(age) + 20) + " years old in 20 years!");
        }
    }
}
