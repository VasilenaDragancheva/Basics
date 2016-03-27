namespace Car
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // first line
            int n = int.Parse(Console.ReadLine());
            string dot = ".";
            string asterix = "*";
            for (int i = 0; i < n; i++)
            {
                Console.Write(dot);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(asterix);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(dot);
            }

            Console.WriteLine();

            // the roof
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                for (int j = n - 1 - i; j > 0; j--)
                {
                    Console.Write(dot);
                }

                Console.Write(asterix);
                for (int j = 0; j < n + 2 * i; j++)
                {
                    Console.Write(dot);
                }

                Console.Write(asterix);
                for (int j = n - 1 - i; j > 0; j--)
                {
                    Console.Write(dot);
                }

                Console.WriteLine();
            }

            // body
            for (int i = 0; i < (n / 2) + 1; i++)
            {
                Console.Write(asterix);
            }

            for (int i = 0; i < 2 * n - 2; i++)
            {
                Console.Write(dot);
            }

            for (int i = 0; i < (n / 2) + 1; i++)
            {
                Console.Write(asterix);
            }

            Console.WriteLine();
            for (int i = 0; i < (n / 2) - 2; i++)
            {
                Console.Write(asterix);
                for (int j = 0; j < 3 * n - 2; j++)
                {
                    Console.Write(dot);
                }

                Console.Write(asterix);
                Console.WriteLine();
            }

            for (int i = 0; i < 3 * n; i++)
            {
                Console.Write(asterix);
            }

            Console.WriteLine();

            // wheels
            for (int i = 0; i < (n / 2) - 2; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    Console.Write(dot);
                }

                Console.Write(asterix);
                for (int j = 0; j < n / 2 - 1; j++)
                {
                    Console.Write(dot);
                }

                Console.Write(asterix);
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(dot);
                }

                Console.Write(asterix);
                for (int j = 0; j < n / 2 - 1; j++)
                {
                    Console.Write(dot);
                }

                Console.Write(asterix);
                for (int j = 0; j < n / 2; j++)
                {
                    Console.Write(dot);
                }

                Console.WriteLine();
            }

            for (int j = 0; j < n / 2; j++)
            {
                Console.Write(dot);
            }

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.Write(asterix);
            }

            for (int j = 0; j < n - 2; j++)
            {
                Console.Write(dot);
            }

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.Write(asterix);
            }

            for (int j = 0; j < n / 2; j++)
            {
                Console.Write(dot);
            }
        }
    }
}