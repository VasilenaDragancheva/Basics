namespace LelqVancheAirlInes
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // •	First Class which accommodates 12 passengers. The ticket price is $7000.
            // •	Business Class which accommodates 28 passengers. The ticket price is $3500.
            // •	Economy Class which accommodates 50 passengers. The ticket price is $1000.
            string[] firstClass = Console.ReadLine().Split(' ');
            string[] bisunessClass = Console.ReadLine().Split(' ');
            string[] economyClass = Console.ReadLine().Split(' ');
            int ticketFirst = 7000;
            int ticketBusiness = 3500;
            int ticketEconomy = 1000;

            decimal maxProfit = 12 * ticketFirst + 28 * ticketBusiness + 50 * ticketEconomy;

                // decimal.Parse(firstClass[0]) * ticketFirst + decimal.Parse(bisunessClass[0]) * ticketBusiness + decimal.Parse(economyClass[0]) * ticketEconomy;
            maxProfit *= 1.005M;
            decimal firstProfit = (decimal.Parse(firstClass[0]) - decimal.Parse(firstClass[1])) * ticketFirst
                                  + decimal.Parse(firstClass[1]) * 0.3M * ticketFirst
                                  + 0.005M * decimal.Parse(firstClass[2]) * ticketFirst;
            decimal secondProfit = (decimal.Parse(bisunessClass[0]) - decimal.Parse(bisunessClass[1])) * ticketBusiness
                                   + decimal.Parse(bisunessClass[1]) * ticketBusiness * 0.3M
                                   + decimal.Parse(bisunessClass[2]) * ticketBusiness * 0.005M;

            decimal thirdProfit = (decimal.Parse(economyClass[0]) - decimal.Parse(economyClass[1])) * ticketEconomy
                                  + decimal.Parse(economyClass[1]) * 0.3M * ticketEconomy
                                  + ticketEconomy * decimal.Parse(economyClass[2]) * 0.005M;
            int currentProfit = (int)(firstProfit + secondProfit + thirdProfit);
            int diff = (int)maxProfit - currentProfit;
            Console.WriteLine(currentProfit);
            Console.WriteLine(diff);
        }
    }
}