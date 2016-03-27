namespace FiveSpecialLetters
{
    using System;

    class Program
    {
        // weight('a') = 5; weight('b') = -12;  weight('c') = 47;  weight('d') = 7;  weight('e') = -32
        static void Main(string[] args)
        {
            long start = long.Parse(Console.ReadLine());
            long end = long.Parse(Console.ReadLine());

            int countResult = 0;

            for (char c1 = 'a'; c1 <= 'e'; c1++)
            {
                for (char c2 = 'a'; c2 <= 'e'; c2++)
                {
                    for (char c3 = 'a'; c3 <= 'e'; c3++)
                    {
                        for (char c4 = 'a'; c4 <= 'e'; c4++)
                        {
                            for (char c5 = 'a'; c5 <= 'e'; c5++)
                            {
                                string answer = string.Empty + c1 + c2 + c3 + c4 + c5;
                                long currentWeight = CalculateWeight(answer);
                                if (currentWeight >= start && currentWeight <= end)
                                {
                                    countResult++;
                                    Console.Write(answer + " ");
                                }
                            }
                        }
                    }
                }
            }

            if (countResult == 0)
            {
                Console.WriteLine("No");
            }
        }

        static long CalculateWeight(string answer)
        {
            long weight = 0;
            bool[] used = new bool['e' + 1];
            int product = 1;
            for (int i = 0; i < answer.Length; i++)
            {
                char letter = answer[i];
                if (!used[letter])
                {
                    weight += product * weightLetter(letter);
                    product++;
                    used[letter] = true;
                }
            }

            return weight;
        }

        static int weightLetter(char letter)
        {
            int weightLetter = 0;
            switch (letter)
            {
                case 'a':
                    weightLetter = 5;
                    break;
                case 'b':
                    weightLetter = -12;
                    break;
                case 'c':
                    weightLetter = 47;
                    break;
                case 'd':
                    weightLetter = 7;
                    break;
                case 'e':
                    weightLetter = -32;
                    break;
            }

            return weightLetter;
        }
    }
}