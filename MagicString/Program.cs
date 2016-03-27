namespace MagicString
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int diff = int.Parse(Console.ReadLine());
            char[] usedChars = { 'k', 'n', 'p', 's' };
            char[] right = new char[4];

            char[] left = new char[4];
            bool isANswer = false;
            for (int c1 = 0; c1 < usedChars.Length; c1++)
            {
                for (int c2 = 0; c2 < left.Length; c2++)
                {
                    for (int c3 = 0; c3 < left.Length; c3++)
                    {
                        for (int c4 = 0; c4 < left.Length; c4++)
                        {
                            left[0] = usedChars[c1];
                            left[1] = usedChars[c2];
                            left[2] = usedChars[c3];
                            left[3] = usedChars[c4];
                            int weightLeft = CalculateW(left);
                            for (int c5 = 0; c5 < usedChars.Length; c5++)
                            {
                                for (int c6 = 0; c6 < left.Length; c6++)
                                {
                                    for (int c7 = 0; c7 < left.Length; c7++)
                                    {
                                        for (int c8 = 0; c8 < left.Length; c8++)
                                        {
                                            right[0] = usedChars[c5];
                                            right[1] = usedChars[c6];
                                            right[2] = usedChars[c7];
                                            right[3] = usedChars[c8];
                                            int weightRight = CalculateW(right);
                                            int curDIff = Math.Abs(weightLeft - weightRight);
                                            if (curDIff == diff)
                                            {
                                                isANswer = true;
                                                Console.WriteLine("{0}{1}", new string(left), new string(right));
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (!isANswer)
            {
                Console.WriteLine("No");
            }
        }

        static int CalculateW(char[] stringPart)
        {
            int weight = 0;
            for (int i = 0; i < stringPart.Length; i++)
            {
                char c = stringPart[i];
                switch (c)
                {
                    case 'k':
                        weight += 1;
                        break;
                    case 'p':
                        weight += 5;
                        break;
                    case 'n':
                        weight += 4;
                        break;
                    case 's':
                        weight += 3;
                        break;
                }
            }

            return weight;
        }
    }
}