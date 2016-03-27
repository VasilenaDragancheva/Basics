namespace Budget
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int daysOut = int.Parse(Console.ReadLine()); // 3% of budget
            int hometown = int.Parse(Console.ReadLine()); // no money
            int costs = (22 - daysOut) * 10 + daysOut * ((int)(0.03 * budget) + 10) + (4 - hometown) * 2 * 20 + 150;

            if (budget > costs)
            {
                Console.WriteLine("Yes, leftover {0}.", budget - costs);
            }
            else if (budget == costs)
            {
                Console.WriteLine("Exact Budget.");
            }
            else
            {
                Console.WriteLine("No, not enough {0}.", costs - budget);
            }
        }
    }
}