namespace Conductors
{
    using System;

    public class Program
    {
        public static int perforator;

        public static void Main(string[] args)
        {
            perforator = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int ticket = int.Parse(Console.ReadLine());
                int result = PerforateTicket(ticket);
                Console.WriteLine(result);
            }
        }

        private static int PerforateTicket(int ticket)
        {
            int countOfBits = Convert.ToString(ticket,2).Length;

            int n = Convert.ToString(perforator, 2).Length;
            int mask = (int)Math.Pow(2, n) - 1;

            int start = 0;
            int end = countOfBits - n;

            while (start <= end)
            {
                int currentBits = (ticket >> start) & mask;
                if (currentBits == perforator)
                {
                    ticket &= ~(mask << start);
                    start += n;
                }
                else
                {
                    start++;
                }
            }

            return ticket;
        }
    }
}