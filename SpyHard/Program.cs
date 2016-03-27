namespace SpyHard
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string message = Console.ReadLine().ToLower();
            int number = 0;
            for (int i = 0; i < message.Length; i++)
            {
                char symbol = message[i];
                if (symbol >= 'a' && symbol <= 'z')
                {
                    number += symbol + 1 - 'a';
                }
                else
                {
                    number += symbol;
                }
            }

            string result = string.Empty;

            while (number > 0)
            {
                result = number % key + result;
                number /= key;
            }

            Console.WriteLine("{0}{1}{2}", key, message.Length, result);
        }
    }
}