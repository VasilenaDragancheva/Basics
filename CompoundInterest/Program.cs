namespace CompoundInterest
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // - 'FV = PV * (1 + i)n 
            decimal priceTv = decimal.Parse(Console.ReadLine()); // PV
            int years = int.Parse(Console.ReadLine()); // n
            decimal i = decimal.Parse(Console.ReadLine());
            decimal percent = decimal.Parse(Console.ReadLine());

            decimal bankLoan = priceTv;
            for (int n = 0; n < years; n++)
            {
                bankLoan *= 1M + i;
            }

            decimal friendsLoan = priceTv * (1 + percent);
            if (bankLoan < friendsLoan)
            {
                Console.WriteLine("{0:F2} Bank", bankLoan);
            }
            else
            {
                Console.WriteLine("{0:F2} Friend", friendsLoan);
            }
        }
    }
}