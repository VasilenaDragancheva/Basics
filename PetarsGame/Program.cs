namespace PetarsGame
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            ulong start = ulong.Parse(Console.ReadLine());
            ulong end = ulong.Parse(Console.ReadLine());
            string replaceString = Console.ReadLine();

            decimal sum = 0;

            for (ulong i = start; i < end; i++)
            {
                bool isDivided = i % 5 == 0;
                if (isDivided)
                {
                    sum += i;
                }
                else
                {
                    sum += i % 5;
                }
            }

            string result = string.Empty;
            string sumTostring = sum.ToString();
            char digitTochange = '\0';
            if (sum % 2 == 0)
            {
                digitTochange = sumTostring[0];
            }
            else
            {
                digitTochange = sumTostring[sumTostring.Length - 1];
            }

            for (int i = 0; i < sumTostring.Length; i++)
            {
                char currentChar = sumTostring[i];
                if (currentChar == digitTochange)
                {
                    result += replaceString;
                }
                else
                {
                    result += currentChar;
                }
            }

            Console.WriteLine(result);
        }
    }
}