namespace Beers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string input = ".";
            int countBeers = 0;
            int countStacks = 0;
            while (input != string.Empty)
            {
                input = Console.ReadLine();
                if (input != "End")
                {
                    string[] beers = input.Split(' ');
                    int count = int.Parse(beers[0]);

                    // Console.WriteLine(beers[0]);
                    switch (beers[1])
                    {
                        case "stacks":
                            countStacks += count;
                            break;
                        case "beers":
                            countBeers += count;
                            break;
                    }
                }

                if (input == "End")
                {
                    countStacks += countBeers / 20;
                    countBeers = countBeers % 20;
                    Console.WriteLine("{0} stacks + {1} beers", countStacks, countBeers);
                    break;
                }
            }
        }
    }
}