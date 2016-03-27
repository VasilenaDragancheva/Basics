namespace FireFighter
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int firefighter = int.Parse(Console.ReadLine());
            int savedToTalKids = 0;
            int savedToTalAdults = 0;
            int savedToTalSeniors = 0;

            string line;
            while (true)
            {
                line = Console.ReadLine();
                if (line == "rain")
                {
                    break;
                }

                int freeFighter = firefighter;
                int countK = line.Count(c => c == 'K');
                int savedKids = freeFighter >= countK ? countK : freeFighter;
                savedToTalKids += savedKids;
                freeFighter -= savedKids;
                if (freeFighter <= 0)
                {
                    continue;
                }

                int countA = line.Count(c => c == 'A');
                int savedAdults = freeFighter >= countA ? countA : freeFighter;
                savedToTalAdults += savedAdults;
                freeFighter -= savedAdults;
                if (freeFighter <= 0)
                {
                    continue;
                }

                int countS = line.Count(c => c == 'S');
                int savedSeniors = freeFighter >= countS ? countS : freeFighter;
                savedToTalSeniors += savedSeniors;
            }

            Console.WriteLine("Kids: " + savedToTalKids);
            Console.WriteLine("Adults: " + savedToTalAdults);
            Console.WriteLine("Seniors: " + savedToTalSeniors);
        }
    }
}