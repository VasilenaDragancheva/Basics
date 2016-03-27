namespace BookOrders
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger amountBooks = 0;
            decimal costBooks = 0;
            for (int i = 0; i < n; i++)
            {
                int packets = int.Parse(Console.ReadLine());
                int booksPerPacket = int.Parse(Console.ReadLine());
                decimal price = decimal.Parse(Console.ReadLine());
                BigInteger currentAmount = packets * booksPerPacket;
                decimal discount = 0;
                if (packets >= 10 && packets <= 109)
                {
                    discount = 4M + packets / 10;
                }
                else if (packets >= 110)
                {
                    discount = 15;
                }

                price *= (100 - discount) / 100;
                amountBooks += currentAmount;
                costBooks += price * (int)currentAmount;
            }

            Console.WriteLine(amountBooks);
            Console.WriteLine("{0:F2}", costBooks);

            // (10-19 packets = 5% discount, 20-29 = 6%, 30-39 = 7%, ..., 100-109 = 14%). If the packets are 110 or more, there is 15% discount
        }
    }
}