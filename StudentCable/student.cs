namespace StudentCable
{
    using System;

    class student
    {
        static void Main(string[] args)
        {
            // number of cables
            int n = int.Parse(Console.ReadLine());
            double lengthOfCables = 0;
            int numberofUsed = 0;
            for (int i = 1; i <= n; i++)
            {
                double length = double.Parse(Console.ReadLine());
                string measure = Console.ReadLine();
                switch (measure)
                {
                    case "meters":
                        length *= 100;
                        break;
                }

                if (length >= 20)
                {
                    lengthOfCables += length;
                    numberofUsed += 1;
                }
            }

            lengthOfCables -= (numberofUsed - 1) * 3;
            int numberOfReady = (int)lengthOfCables / 504;
            int restCable = (int)(lengthOfCables % 504);
            Console.WriteLine(numberOfReady);
            Console.WriteLine(restCable);
        }
    }
}