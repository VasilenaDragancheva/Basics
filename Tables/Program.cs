namespace Tables
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            BigInteger packet1 = BigInteger.Parse(Console.ReadLine()); // 1
            BigInteger packet2 = BigInteger.Parse(Console.ReadLine()); // 2
            BigInteger packet3 = BigInteger.Parse(Console.ReadLine()); // 3
            BigInteger packet4 = BigInteger.Parse(Console.ReadLine()); // 4
            BigInteger tableTops = BigInteger.Parse(Console.ReadLine());
            BigInteger tablesToMade = BigInteger.Parse(Console.ReadLine());

            BigInteger legs = packet1 * 1 + packet2 * 2 + packet3 * 3 + packet4 * 4;

            BigInteger tables = legs / 4 > tableTops ? tableTops : legs / 4;

            if (tables == tablesToMade)
            {
                Console.WriteLine("Just enough tables made: {0}", tables);
            }
            else if (tables > tablesToMade)
            {
                Console.WriteLine("more: {0}", tables - tablesToMade);
                Console.WriteLine("tops left: {0}, legs left: {1}", tableTops - tablesToMade, legs - 4 * tablesToMade);
            }
            else
            {
                Console.WriteLine("less: {0}", tables - tablesToMade);
                Console.WriteLine(
                    "tops needed: {0}, legs needed: {1}", 
                    tablesToMade - tableTops > 0 ? tablesToMade - tableTops : 0, 
                    4 * tablesToMade - legs > 0 ? 4 * tablesToMade - legs : 0);
            }
        }
    }
}