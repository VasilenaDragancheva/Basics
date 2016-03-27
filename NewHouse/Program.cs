namespace NewHouse
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int asterix = 1;
            int dash = n / 2;
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', dash), new string('*', asterix));
                asterix += 2;
                dash--;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}