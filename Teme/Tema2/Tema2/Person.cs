using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2
{
    static class Person
    {

        [Test]
        public static void PersonDetails()
        {
            //Because it is a static class there is no need for instantiation
            DisplayDetails();
        }

        static string FirstName = "Sorin";
        static string LastName = "Carpinisanu";
        static int Age = 57;
        static string Gender = "Male";

        static int CalculatedAge(int CalculatedAgeAfter15Years)
        {
            CalculatedAgeAfter15Years = Age + 15;
            return CalculatedAgeAfter15Years;
        }

        static void DisplayDetails()
        {
            Console.WriteLine("The person's details are as follows:");
            Console.WriteLine("    - First Name : " + FirstName);
            Console.WriteLine("    - Last Name  : " + LastName);
            Console.WriteLine("    - Age        : " + Age);
            Console.WriteLine("    - Gender     : " + Gender);
            Console.WriteLine("You will be " + CalculatedAge(Age) + " in 15 years time!");

        }

    }
}