namespace Letters_Symbols_Numbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countLetters = 0;
            int countSymbols = 0;
            int countDigits = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine().ToLower();
                for (int c = 0; c < input.Length; c++)
                {
                    char sign = input[c];
                    if (sign >= 'a' && sign <= 'z')
                    {
                        countLetters += (sign - 'a' + 1) * 10;
                    }
                    else if (sign >= '0' && sign <= '9')
                    {
                        countDigits += int.Parse(sign.ToString()) * 20;
                    }
                    else
                    {
                        if (sign != ' ' && sign != '\t' && sign != '\r' && sign != '\n')
                        {
                            countSymbols += 200;
                        }
                    }
                }
            }

            Console.WriteLine(countLetters);
            Console.WriteLine(countDigits);
            Console.WriteLine(countSymbols);
        }
    }
}