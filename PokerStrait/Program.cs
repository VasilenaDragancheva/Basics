namespace PokerStrait
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            int countOfVariants = 0;
            int face = 1;
            while (face <= 10)
            {
                countOfVariants += Count(face, weight);

                face++;
            }

            Console.WriteLine(countOfVariants);
        }

        static int Count(int face, int weight)
        {
            int counter = 0;
            for (int a = 1; a <= 4; a++)
            {
                for (int b = 1; b <= 4; b++)
                {
                    for (int c = 1; c <= 4; c++)
                    {
                        for (int d = 1; d <= 4; d++)
                        {
                            for (int e = 1; e <= 4; e++)
                            {
                                int currentWeight = 150 * face + a + b + c + d + e + 20 + 60 + 120 + 200;
                                if (currentWeight == weight)
                                {
                                    counter += 1;
                                }
                            }
                        }
                    }
                }
            }

            return counter;
        }
    }
}