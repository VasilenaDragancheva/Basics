namespace Cinema
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            int people = rows * col;
            double priceOfticket = 0;

            switch (typeProjection)
            {
                case "Premiere":
                    priceOfticket = 12.00;
                    break;
                case "Normal":
                    priceOfticket = 7.50;
                    break;
                case "Discount":
                    priceOfticket = 5.00;
                    break;
            }

            double incomes = people * priceOfticket;
            Console.WriteLine("{0:F2} leva", incomes);
        }
    }
}