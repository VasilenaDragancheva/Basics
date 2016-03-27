namespace MagicDates
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string yearStart = Console.ReadLine();
            string yearEnd = Console.ReadLine();
            int weight = int.Parse(Console.ReadLine());
            DateTime start = new DateTime(int.Parse(yearStart), 1, 1);
            DateTime end = new DateTime(int.Parse(yearEnd), 12, 31);
            bool isResult = false;

            while (start <= end)
            {
                int days = start.Day;
                int month = start.Month;
                int year = start.Year;
                int[] digits =
                    {
                        days / 10, days % 10, month / 10, month % 10, year / 1000, (year / 100) % 10, 
                        (year / 10) % 10, year % 10
                    };
                int currentWeight = 0;
                for (int i = 0; i < digits.Length; i++)
                {
                    int sum = 0;
                    for (int m = i + 1; m < digits.Length; m++)
                    {
                        sum += digits[m];
                    }

                    int product = digits[i] * sum;
                    currentWeight += product;
                }

                if (currentWeight == weight)
                {
                    isResult = true;
                    Console.WriteLine("{0:d2}-{1:d2}-{2:d2}", start.Day, start.Month, start.Year);
                }

                start = start.AddDays(1);
            }

            if (!isResult)
            {
                Console.WriteLine("No");
            }
        }
    }
}