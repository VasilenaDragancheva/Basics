namespace BookProblem
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine()); // of book
            int pagesPerDay = int.Parse(Console.ReadLine());
            int pagesPerMonth = (30 - campaingDays) * pagesPerDay;

            if (campaingDays == 30 || pagesPerDay == 0)
            {
                Console.WriteLine("never");
            }
            else
            {
                int monthsNeeded = (int)Math.Ceiling((double)pages / pagesPerMonth);
                int years = monthsNeeded / 12;
                int mon = monthsNeeded % 12;
                Console.WriteLine("{0} years {1} months", years, mon);
            }
        }
    }
}