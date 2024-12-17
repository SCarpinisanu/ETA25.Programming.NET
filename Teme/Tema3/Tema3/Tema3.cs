using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3
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
        static int Age = 100;
        static string Gender = "Maale";

        static int CalculatedAge(int CalculatedAgeAfter15Years)
        {
            CalculatedAgeAfter15Years = Age + 15;
            return CalculatedAgeAfter15Years;
        }

        static void DisplayDetails()
        {
            Console.WriteLine("The person's details are as follows:");
            Console.WriteLine($"    - First Name : {FirstName}");
            Console.WriteLine($"    - Last Name  : {LastName}");
            Console.WriteLine($"    - Age        : {Age} - {AgeVerified("Mesaj")}");
            Console.WriteLine($"    - Gender     : {GenderVerified(Gender)}");
            Console.WriteLine($"You will be {CalculatedAge(Age)} in 15 years time!");

        }

        private static string AgeVerified(string AgeMessage)
        {
            if (Age >= 100)
            {
                AgeMessage = "You are ancient!";
            }
            else if (Age >= 50)
            {
                AgeMessage = "You are old!";
            }
            else
            {
                AgeMessage = "You are still young!";
            }
            return AgeMessage;
        }

        private static string GenderVerified(string GenderMessage)
        {
            switch (Gender)
            {
                case "Female" or "female":
                    GenderMessage = "You are a female!";
                    break;

                case "Male" or "male":
                    GenderMessage = "You are a male!";
                    break;

                default:
                    GenderMessage = "Gender not specified or it is misspelled!";
                    break;
            }
            return GenderMessage;
        }

    }
}