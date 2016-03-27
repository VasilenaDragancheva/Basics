namespace WeirdCombinations
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            int countCombinations = -1;
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    for (int m = 0; m < input.Length; m++)
                    {
                        for (int k = 0; k < input.Length; k++)
                        {
                            for (int l = 0; l < input.Length; l++)
                            {
                                result = input[i] + input[j].ToString() + input[m] + input[k] + input[l];
                                countCombinations++;
                                if (countCombinations == n)
                                {
                                    Console.WriteLine(result);
                                }
                            }
                        }
                    }
                }
            }

            if (countCombinations < n)
            {
                Console.WriteLine("No");
            }
        }
    }
}