namespace WorkHours
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine()); // to finish project
            int d = int.Parse(Console.ReadLine()); // workind dys
            decimal p = decimal.Parse(Console.ReadLine()) / 100; // produkt
            decimal effWorkingDays = 0.9m * d;
            int workingHours = (int)(p * 12 * effWorkingDays);
            if (h > workingHours)
            {
                Console.WriteLine("No");
                Console.WriteLine(workingHours - h);
            }

            if (h <= workingHours)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(workingHours - h);
            }
        }
    }
}