using System;

namespace csharp03arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program will sort numbers for you.");

            Console.WriteLine("How many numbers do you want to sort?");

            int numberOfInputs = Convert.ToInt32(Console.ReadLine());

            int[] allNumbers = new int[numberOfInputs];

            for (int i = 0; i < numberOfInputs; i++){
                Console.WriteLine("Number " + (i + 1));
                allNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(allNumbers);
            Console.WriteLine();

            Console.WriteLine("Here ya go, Chief:");
            for (int j = 0; j < allNumbers.Length; j++){
                Console.WriteLine((j+1) + ")   " + allNumbers[j]);
            }

        }
    }
}
