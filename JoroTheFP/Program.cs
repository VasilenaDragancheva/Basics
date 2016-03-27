namespace JoroTheFP
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine();
            bool isLeap = leap == "t";
            int holidays = int.Parse(Console.ReadLine());
            int weekendHome = int.Parse(Console.ReadLine());
            int times = 0;
            if (isLeap)
            {
                times += 3;
            }

            times += weekendHome; // weekends home
            times += (52 - weekendHome) * 2 / 3; // other weekends
            times += holidays / 2;
            Console.WriteLine(times);
        }
    }
}