using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema5
{
    static class PersonSkills
    {

        [Test]
        public static void PersonSkillsMethod()
        {

            //Because it is a static class there is no need for instantiation
            DisplaySkills();
        }

        //It wasn't working with this:
        //static List<string> skills = new List<string>
        //{"Cooking,
        // "Photography,
        // ...
        // Singing
        // }
        private static readonly List<string> value = 
            [
                "Cooking",
                "Photography",
                "Programming",
                "Testing",
                "Ninja",
                "Swimming",
                "CIA",
                "Dancing",
                "Singing"
            ];

        //Without this line it wasn't working
        private static readonly List<string> skills = value;

        static void DisplaySkills()
        {
        
        foreach (var skill in skills)
            {
                // Skip "Ninja"
                if (skill == "Ninja")
                {
                    continue;
                }

                // Stop processing at "CIA"
                if (skill == "CIA")
                {
                    Console.WriteLine("≫≫≫≫≫≫≫ Classified information, no further skills displayed! ≪≪≪≪≪≪≪");
                    break;
                }

                // Display the added skill
                Console.WriteLine($"Added a new skill: {skill}");
            }

        }

    }
}