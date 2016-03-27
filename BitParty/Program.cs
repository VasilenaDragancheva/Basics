namespace BitParty
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            string command;
            while (true)
            {
                command = Console.ReadLine();
                if (command == "party over")
                {
                    break;
                }

                string action = command.Split(' ')[0];
                int p = int.Parse(command.Split(' ')[1]);
                for (int i = 0; i < n; i++)
                {
                    switch (action)
                    {
                        case "-1":
                            numbers[i] ^= 1 << p;

                            break;
                        case "0":
                            numbers[i] &= ~(1 << p);
                            break;
                        case "1":
                            numbers[i] |= 1 << p;
                            break;
                    }
                }
            }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}