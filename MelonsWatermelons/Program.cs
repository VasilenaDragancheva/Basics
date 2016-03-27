namespace MelonsWatermelons
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int melons = 0;
            int water = 0;

            for (int i = 0; i < days; i++)
            {
                int dayOfweek = (start + i) % 7;

                switch (dayOfweek)
                {
                    case 1:
                        water += 1;
                        break;
                    case 2:
                        melons += 2;
                        break;
                    case 3:
                        melons += 1;
                        water += 1;
                        break;
                    case 4:
                        water += 2;
                        break;
                    case 5:
                        melons += 2;
                        water += 2;
                        break;
                    case 6:
                        water += 1;
                        melons += 2;
                        break;
                }
            }

            if (melons == water)
            {
                Console.WriteLine("Equal amount: {0}", melons);
            }
            else if (melons > water)
            {
                Console.WriteLine("{0} more melons", melons - water);
            }
            else if (melons < water)
            {
                Console.WriteLine("{0} more watermelons", water - melons);
            }
        }
    }
}