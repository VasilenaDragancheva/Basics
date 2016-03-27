namespace ByteParty
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

            string command = Console.ReadLine();
            while (command != "party over")
            {
                string action = command.Split(' ')[0];
                int positon = int.Parse(command.Split(' ')[1]);

                command = Console.ReadLine();
            }
        }
    }
}