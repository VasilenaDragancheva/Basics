namespace VolleyBall
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine();
            decimal holidays = decimal.Parse(Console.ReadLine());
            decimal weekednsHome = decimal.Parse(Console.ReadLine());
            decimal days = new decimal();
            days += weekednsHome;
            days += 2 * holidays / 3;
            days += ((48 - weekednsHome) * 3) / 4;
            if (leap == "leap")
            {
                days *= 1.15M;
            }

            Console.WriteLine((int)days);
        }
    }
}