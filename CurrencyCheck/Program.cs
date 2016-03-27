namespace CurrencyCheck
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            decimal rublies = decimal.Parse(Console.ReadLine()); // 3.5 lv 100 rublis
            decimal dollars = decimal.Parse(Console.ReadLine()); // 1.5 lv
            decimal euros = decimal.Parse(Console.ReadLine()); // 1.95 lv
            decimal for2Games = decimal.Parse(Console.ReadLine());
            decimal levs = decimal.Parse(Console.ReadLine());
            decimal minPrice = uint.MaxValue;

            rublies *= 3.5M / 100;
            minPrice = Math.Min(rublies, minPrice);
            dollars *= 1.5M;
            minPrice = Math.Min(dollars, minPrice);
            euros *= 1.95M;
            minPrice = Math.Min(euros, minPrice);
            for2Games /= 2;
            minPrice = Math.Min(for2Games, minPrice);
            minPrice = Math.Min(levs, minPrice);
            Console.WriteLine("{0:F2}", minPrice);
        }
    }
}