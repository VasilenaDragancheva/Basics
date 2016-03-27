namespace OddEvenCounter
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int countSets = int.Parse(Console.ReadLine());
            int numbersInSet = int.Parse(Console.ReadLine()); // numbers in set
            string kind = Console.ReadLine(); // odd even
            int[] values = new int[countSets];

            for (int i = 0; i < countSets * numbersInSet; i++)
            {
                int number = int.Parse(Console.ReadLine());
                bool isOdd = number % 2 == 1;
                switch (kind)
                {
                    case "odd":
                        if (isOdd)
                        {
                            values[i / numbersInSet]++;
                        }

                        break;
                    case "even":
                        if (!isOdd)
                        {
                            values[i / numbersInSet]++;
                        }

                        break;
                }
            }

            int index = 0;
            while (values[index] < values.Max())
            {
                index++;
            }

            index++; // number of set
            string[] digitName =
                {
                    "No", "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", 
                    "Ninth", "Tenth"
                };

            if (values.Max() == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("{0} set has the most {1} numbers: {2}", digitName[index], kind, values.Max());
            }
        }
    }
}