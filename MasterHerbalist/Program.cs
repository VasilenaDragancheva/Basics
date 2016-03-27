namespace MasterHerbalist
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            decimal dayliExpances = decimal.Parse(Console.ReadLine());
            decimal incomes = 0;
            int counterDays = 0;
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Season Over")
                {
                    break;
                }

                string[] data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int hours = int.Parse(data[0]);
                string path = data[1];
                int countHerbs = CountHerbs(hours, path);
                decimal pricePerHerb = decimal.Parse(data[2]);
                incomes += pricePerHerb * countHerbs;
                counterDays++;
            }

            decimal totalCosts = dayliExpances * counterDays;
            if (totalCosts > incomes)
            {
                Console.WriteLine("We are in the red. Money needed: {0}.", totalCosts - incomes);
            }
            else
            {
                decimal money = (incomes - totalCosts) / counterDays;
                Console.WriteLine("Times are good. Extra money per day: {0:f2}.", money);
            }
        }

        private static int CountHerbs(int hours, string path)
        {
            int additionalTimes = hours / path.Length;
            int restHours = hours % path.Length;

            int countherb = additionalTimes * path.Count(c => c == 'H');
            countherb += path.Substring(0, restHours).Count(c => c == 'H');
            return countherb;
        }
    }
}