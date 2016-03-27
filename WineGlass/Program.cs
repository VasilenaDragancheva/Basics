namespace WineGlass
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\\{0}/", new string('*', n - 2));

            int dots = 1;
            int asterix = n - 4;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('.', dots), new string('*', asterix));
                dots++;
                asterix -= 2;
            }

            if (n < 12)
            {
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine("{0}||{0}", new string('.', (n / 2) - 1));
                }

                Console.WriteLine("{0}", new string('-', n));
            }

            if (n >= 12)
            {
                for (int i = 0; i < n / 2 - 2; i++)
                {
                    Console.WriteLine("{0}||{0}", new string('.', (n / 2) - 1));
                }

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("{0}", new string('-', n));
                }
            }
        }
    }
}