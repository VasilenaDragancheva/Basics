using System;
using System.Numerics;


    class Program
    {
        static void Main(string[] args)
        {
            BigInteger trib1 =new BigInteger (int.Parse(Console.ReadLine()));
            BigInteger trib1 =new BigInteger (int.Parse(Console.ReadLine()));
            BigInteger trib1 =new BigInteger (int.Parse(Console.ReadLine()));
            long n = long.Parse(Console.ReadLine());
            tribArray[0] = trib1;
            tribArray[1] = trib2;
            tribArray[2] = trib3;
            for (i=0; i < n;i++ )
            {
                tribArray[i + 3] = tribArray[i] + tribArray[i + 1] + tribArray[i + 2];
            }
            Console.WriteLine(tribArray[n - 1]);
        }
    }

