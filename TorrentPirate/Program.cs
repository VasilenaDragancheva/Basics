namespace TorrentPirate
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            decimal size1movie = 1500; // MB
            int speed = 2; // MB/s
            decimal data = decimal.Parse(Console.ReadLine());
            int priceCinema = int.Parse(Console.ReadLine());
            int moneySpentPerHour = int.Parse(Console.ReadLine());
            decimal downLoadtime = data / speed; // in seconds
            downLoadtime /= 60 * 60; // in hours;
            decimal priceForDOwnloand = downLoadtime * moneySpentPerHour;
            decimal Cinema = priceCinema * data / size1movie;

            if (priceForDOwnloand <= Cinema)
            {
                Console.WriteLine("mall -> {0:f2}lv", priceForDOwnloand);
            }
            else
            {
                Console.WriteLine("cinema -> {0:f2}lv", Cinema);
            }
        }
    }
}