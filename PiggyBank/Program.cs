namespace PiggyBank
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int priceTank = int.Parse(Console.ReadLine());
            int partyDays = int.Parse(Console.ReadLine());
            double savedPerMonth = (30 - partyDays) * 2 - partyDays * 5;

            if (savedPerMonth > 0)
            {
                double months = Math.Ceiling(priceTank / savedPerMonth);
                int years = (int)months / 12;
                months = months % 12;
                Console.WriteLine("{0} years, {1} months", years, months);
            }

            if (savedPerMonth <= 0)
            {
                Console.WriteLine("never");
            }
        }
    }
}