namespace ChangeEvenBits
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countOfChanged = 0;
            int n = int.Parse(Console.ReadLine());
            int[] countOfBits = new int[n];
            for (int i = 0; i < n; i++)
            {
                int dec = int.Parse(Console.ReadLine());
                string binary = Convert.ToString(dec, 2);
                countOfBits[i] = binary.Length;
            }

            ulong number = ulong.Parse(Console.ReadLine());

            for (int i = 0; i < countOfBits.Length; i++)
            {
                int NumberEvens = countOfBits[i]; // times to change event
                int times = 0;
                int p = 0;
                while (times < NumberEvens)
                {
                    if (((number >> p) & 1) == 0)
                    {
                        number |= 1ul << p;
                        countOfChanged++;
                    }

                    p += 2;
                    times++;
                }
            }

            Console.WriteLine(number);
            Console.WriteLine(countOfChanged);
        }
    }
}