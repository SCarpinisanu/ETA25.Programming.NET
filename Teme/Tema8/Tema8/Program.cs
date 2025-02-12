namespace Tema8
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please input the size of the list: ");

            if (int.TryParse(Console.ReadLine(), out int lengthList) && lengthList > 0)
            {
                List<int> listOfNumbers = new List<int>();

                for (int i = 0; i < lengthList; i++)
                {
                    Console.Write($"Please input a number for list[{i + 1}]: ");

                    if (int.TryParse(Console.ReadLine(), out int elementNumber))
                    {
                        listOfNumbers.Add(elementNumber);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Input a valid number.");
                        i--; // Repets the iteration when the input is invalid
                    }
                }

                int sumEvenNumbers = 0, sumOddNumbers = 0;
                foreach (int number in listOfNumbers)
                {
                    if (number % 2 == 0)
                    {
                        sumEvenNumbers = number + sumEvenNumbers;
                    }
                    else
                    {
                        sumOddNumbers += number;
                    }
                }
                Console.WriteLine("The list contains: " + string.Join(", ", listOfNumbers));
                Console.WriteLine($"Sum of even elements : {sumEvenNumbers}");
                Console.WriteLine($"Sum of odd elements  : {sumOddNumbers}");
            }
            else
            {
                Console.WriteLine("Invalid number! Input a valid number.");
            }
        }
    }
}
