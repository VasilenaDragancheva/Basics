namespace ArrayModifier
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        public static BigInteger[] numbers;

        public static void Main(string[] args)
        {
            numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                var commandParams = line.Split(' ').ToArray();
                ExecuteCommand(commandParams);
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void ExecuteCommand(string[] commandParams)
        {
            var name = commandParams[0];
            switch (name)
            {
                case "swap":
                    SwapNumbers(commandParams);
                    break;
                case "multiply":
                    Multiply(commandParams);
                    break;
                case "decrease":
                    Decrease();
                    break;
            }
        }

        private static void Decrease()
        {
            numbers = numbers.Select(x => x -= 1).ToArray();
        }

        private static void Multiply(string[] commandParams)
        {
            int index1 = int.Parse(commandParams[1]);
            int index2 = int.Parse(commandParams[2]);
            numbers[index1] *= numbers[index2];
        }

        private static void SwapNumbers(string[] commandParams)
        {
            int index1 = int.Parse(commandParams[1]);
            int index2 = int.Parse(commandParams[2]);
            var number = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = number;
        }
    }
}