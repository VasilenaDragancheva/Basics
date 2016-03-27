namespace diamonds
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}*{0}", new string('-', n / 2));

            int before = n / 2 - 1;
            int middle = 1;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('-', before), new string('-', middle));
                before--;
                middle += 2;
            }

            before = 1;
            middle = n - 4;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('-', before), new string('-', middle));
                before++;
                middle -= 2;
            }

            Console.WriteLine("{0}*{0}", new string('-', n / 2));
        }
    }
}