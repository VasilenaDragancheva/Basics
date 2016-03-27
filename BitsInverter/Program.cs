namespace BitsInverter
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int index = 1;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int p = 7; p >= 0; p--)
                {
                    int bit = (number >> p) & 1;
                    if (step == 1 || index % step == 1)
                    {
                        number ^= 1 << p;
                    }

                    index++;
                }

                Console.WriteLine(number);
            }
        }
    }
}