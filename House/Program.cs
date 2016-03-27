namespace House
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char asterix = '*';
            char dot = '.';

            // vyrhyt
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(dot);
            }

            Console.Write(asterix);
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(dot);
            }

            Console.WriteLine();
            for (int i = 1; i <= (n / 2) - 1; i++)
            {
                for (int j = n / 2 - i; j >= 1; j--)
                {
                    Console.Write(dot);
                }

                Console.Write(asterix);
                for (int j = 1; j < 2 * i; j++)
                {
                    Console.Write(dot);
                }

                Console.Write(asterix);
                for (int j = n / 2 - i; j >= 1; j--)
                {
                    Console.Write(dot);
                }

                Console.WriteLine();
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write(asterix);
            }

            Console.WriteLine();
            for (int i = 1; i < n / 2; i++)
            {
                for (int j = 1; j <= n / 4; j++)
                {
                    Console.Write(dot);
                }

                Console.Write(asterix);
                for (int j = 1; j <= n - 2 - 2 * (n / 4); j++)
                {
                    Console.Write(dot);
                }

                Console.Write(asterix);
                for (int j = 1; j <= n / 4; j++)
                {
                    Console.Write(dot);
                }

                Console.WriteLine();
            }

            for (int i = 1; i <= n / 4; i++)
            {
                Console.Write(dot);
            }

            for (int j = 1; j <= n - 2 * (n / 4); j++)
            {
                Console.Write(asterix);
            }

            for (int i = 1; i <= n / 4; i++)
            {
                Console.Write(dot);
            }

            Console.WriteLine();
        }
    }
}