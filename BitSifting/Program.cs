namespace BitSifting
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            ulong numTosieve = ulong.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            ulong[] siev = new ulong[n];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                siev[i] = ulong.Parse(Console.ReadLine());
            }

            for (int p = 63; p >= 0; p--)
            {
                ulong bit = (numTosieve >> p) & 1;
                bool final = false;
                if (bit == 1 && n == 0)
                {
                    count++;
                }
                else if (bit == 1 && n > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        ulong bitSieve = (siev[i] >> p) & 1;

                        if (bitSieve == 0)
                        {
                            final = true;
                        }
                        else
                        {
                            final = false;
                            break;
                        }
                    }
                }

                if (final)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}