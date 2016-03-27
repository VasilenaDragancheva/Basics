namespace nestedLoops
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            char[] secret = Console.ReadLine().ToCharArray();
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int bools = 0;
            int cows = 0;
            bool noResult = false;

            for (int i = 1111; i <= 9999; i++)
            {
                char[] guess = i.ToString().ToCharArray();

                bools = Numberbools(secret, guess);
                cows = Numbercows(secret, guess);
                if (b == bools && cows == c)
                {
                    noResult = true;
                    Console.Write(i + " ");
                }
            }

            if (noResult == false)
            {
                Console.Write("No");
            }
        }

        static int Numberbools(char[] secret, char[] guess)
        {
            int numberbulls = 0;
            for (int i = 0; i <= 3; i++)
            {
                for (int m = 0; m <= 3; m++)
                {
                    if (guess[i] != 0 && guess[i] == secret[m] && i == m)
                    {
                        numberbulls += 1;
                    }
                }
            }

            return numberbulls;
        }

        static int Numbercows(char[] secret, char[] guess)
        {
            int numbercows = 0;
            for (int i = 0; i <= 3; i++)
            {
                for (int m = 0; m <= 3; m++)
                {
                    if (guess[i] != 0 && guess[i] == secret[m] && i != m)
                    {
                        numbercows += 1;
                    }
                }
            }

            return numbercows;
        }
    }
}