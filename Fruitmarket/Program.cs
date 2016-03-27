namespace Fruitmarket
{
    using System;
    using System.Globalization;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string day = Console.ReadLine();
            double totalSum = 0;

            double banana = 1.80;
            double cucumber = 2.75;
            double tomato = 3.20;
            double orange = 1.60;
            double apple = 0.86;

            for (int i = 0; i < 3; i++)
            {
                double sum = 0;
                double quantity = double.Parse(Console.ReadLine());
                string product = Console.ReadLine();

                switch (product)
                {
                    case "banana":
                        sum = quantity * banana;
                        break;
                    case "cucumber":
                        sum = quantity * cucumber;
                        break;
                    case "tomato":
                        sum = quantity * tomato;
                        break;
                    case "orange":
                        sum = quantity * orange;
                        break;
                    case "apple":
                        sum = quantity * apple;
                        break;
                }

                double discount = Discount(day, product);
                sum *= 1 - discount;
                totalSum += sum;
            }

            Console.WriteLine("{0:F2}", totalSum);
        }

        static double Discount(string day, string product)
        {
            bool isFruit = product == "banana" || product == "orange" || product == "apple";
            double discount = 0;
            switch (day)
            {
                case "Friday":
                    discount = 0.1;
                    break;
                case "Sunday":
                    discount = 0.05;
                    break;
                case "Tuesday":
                    if (isFruit)
                    {
                        discount = 0.2;
                    }

                    break;
                case "Wednesday":
                    if (!isFruit)
                    {
                        discount = 0.1;
                    }

                    break;
                case "Thursday":
                    if (product == "banana")
                    {
                        discount = 0.3;
                    }

                    break;
                default:
                    discount = 0;
                    break;
            }

            return discount;
        }
    }
}