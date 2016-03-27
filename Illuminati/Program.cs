namespace Illuminati
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            int numberOfvowels = 0;
            int sumOfvowels = 0;
            foreach (char letter in input)
            {
                if (letter == 'a' || letter == 'A')
                {
                    sumOfvowels += 'A';
                    numberOfvowels++;
                }

                if (letter == 'E' || letter == 'e')
                {
                    sumOfvowels += 'E';
                    numberOfvowels++;
                }

                if (letter == 'I' || letter == 'i')
                {
                    sumOfvowels += 'I';
                    numberOfvowels++;
                }

                if (letter == 'o' || letter == 'O')
                {
                    sumOfvowels += 'O';
                    numberOfvowels++;
                }

                if (letter == 'U' || letter == 'u')
                {
                    sumOfvowels += 'U';
                    numberOfvowels++;
                }
            }

            Console.WriteLine(numberOfvowels);
            Console.WriteLine(sumOfvowels);
        }
    }
}