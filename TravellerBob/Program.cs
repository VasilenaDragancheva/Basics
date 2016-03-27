namespace TravellerBob
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine();
            decimal monthsContracts = int.Parse(Console.ReadLine());
            decimal monthsFamily = int.Parse(Console.ReadLine());
            decimal travellers = 0;
            travellers += (4 * 3) * monthsContracts;
            travellers += (2 * 2) * monthsFamily;
            travellers += (12 - monthsFamily - monthsContracts) * (4 * 3) * 3 / 5;
            if (leap == "leap")
            {
                travellers *= 1.05M;
            }

            Console.WriteLine((int)travellers);
        }
    }
}