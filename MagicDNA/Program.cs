namespace MagicDNA
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char start = char.Parse(Console.ReadLine());
            for (int k = 1; k <= n / 7; k++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int i = 3 - j; i >= 1; i--)
                    {
                        Console.Write('.');
                    }

                    for (int i = 1; i <= 1 + 2 * j; i++)
                    {
                        Console.Write(start);
                        start++;
                        if (start == 'H')
                        {
                            start = 'A';
                        }
                    }

                    for (int i = 3 - j; i >= 1; i--)
                    {
                        Console.Write('.');
                    }

                    Console.WriteLine();
                }

                for (int j = 0; j < 3; j++)
                {
                    for (int i = 1; i <= 1 + j; i++)
                    {
                        Console.Write('.');
                    }

                    for (int i = 5 - 2 * j; i >= 1; i--)
                    {
                        Console.Write(start);
                        start++;
                        if (start == 'H')
                        {
                            start = 'A';
                        }
                    }

                    for (int i = 1; i <= 1 + j; i++)
                    {
                        Console.Write('.');
                    }

                    Console.WriteLine();
                }
            }

            int m = Math.Min(n % 7, 4);
            int l = Math.Min((n % 7) - 4, 3);
            for (int j = 0; j < m; j++)
            {
                for (int i = 3 - j; i >= 1; i--)
                {
                    Console.Write('.');
                }

                for (int i = 1; i <= 1 + 2 * j; i++)
                {
                    Console.Write(start);
                    start++;
                    if (start == 'H')
                    {
                        start = 'A';
                    }
                }

                for (int i = 3 - j; i >= 1; i--)
                {
                    Console.Write('.');
                }

                Console.WriteLine();
            }

            for (int j = 0; j < l; j++)
            {
                for (int i = 1; i <= 1 + j; i++)
                {
                    Console.Write('.');
                }

                for (int i = 5 - 2 * j; i >= 1; i--)
                {
                    Console.Write(start);
                    start++;
                    if (start == 'H')
                    {
                        start = 'A';
                    }
                }

                for (int i = 1; i <= 1 + j; i++)
                {
                    Console.Write('.');
                }

                Console.WriteLine();
            }
        }
    }
}