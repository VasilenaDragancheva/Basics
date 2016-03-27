namespace NakovMatching
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string a_word = Console.ReadLine();
            string b_word = Console.ReadLine();
            decimal distance = decimal.Parse(Console.ReadLine());
            int counnter = 0;

            // each part may contains from 1 to input.length-1 chars //index 0 to lenght-2
            for (int a = 0; a <= a_word.Length - 2; a++)
            {
                for (int b = 0; b <= b_word.Length - 2; b++)
                {
                    string aright = string.Empty;
                    string aleft = string.Empty;
                    string bright = string.Empty;
                    string bleft = string.Empty;

                    aright = ConcatRight(a_word, a);
                    decimal sumAR = sumLetters(aright);

                    aleft = ConcatLeft(a_word, a);
                    decimal sumAL = sumLetters(aleft);

                    bright = ConcatRight(b_word, b);
                    decimal sumBR = sumLetters(bright);

                    bleft = ConcatLeft(b_word, b);
                    decimal sumBL = sumLetters(bleft);
                    decimal nakovs = Math.Abs(sumAR * sumBL - sumAL * sumBR);
                    if (nakovs <= distance)
                    {
                        counnter++;
                        Console.WriteLine(
                            "({0}|{1}) matches ({2}|{3}) by {4} nakovs", 
                            aright, 
                            aleft, 
                            bright, 
                            bleft, 
                            nakovs);
                    }
                }
            }

            if (counnter == 0)
            {
                Console.WriteLine("No");
            }
        }

        static string ConcatRight(string word, int w)
        {
            string rightPart = string.Empty;
            for (int i = 0; i <= w; i++)
            {
                rightPart += word[i];
            }

            return rightPart;
        }

        static string ConcatLeft(string word, int w)
        {
            string leftPart = string.Empty;
            for (int i = w + 1; i < word.Length; i++)
            {
                leftPart += word[i];
            }

            return leftPart;
        }

        static decimal sumLetters(string word)
        {
            decimal sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                sum += word[i];
            }

            return sum;
        }
    }
}