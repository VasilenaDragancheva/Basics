namespace DreamItem
{
    using System;
    using System.Globalization;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            // Month\Money per hour\Hours per day\Price of the item. 
            string[] input = Console.ReadLine().Split('\\');
            string month = input[0];
            decimal moneyPerHour = decimal.Parse(input[1]);
            int hoursPerDay = int.Parse(input[2]);
            decimal price = decimal.Parse(input[3]); // 10 holidays;
            int workingdays = 0;

            switch (month)
            {
                case "Feb":
                    workingdays = 28;
                    break;
                case "Apr":
                case "June":
                case "Sept":
                case "Nov":
                    workingdays = 30;
                    break;
                default:
                    workingdays = 31;
                    break;
            }

            workingdays -= 10;
            decimal salary = workingdays * hoursPerDay * moneyPerHour;
            if (salary >= 700)
            {
                salary *= 1.1M;
            }

            if (salary >= price)
            {
                Console.WriteLine("Money left = {0:F2} leva.", salary - price);
            }
            else
            {
                Console.WriteLine("Not enough money. {0:F2} leva needed.", price - salary);
            }
        }
    }
}