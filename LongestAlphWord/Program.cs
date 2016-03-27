namespace LongestAlphWord
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            int index = 0;
            char[,] matrix = new char[n, n];
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = word[index];
                    index++;
                    if (index == word.Length)
                    {
                        index = 0;
                    }
                }
            }

            string maxWord = string.Empty;
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    string left = FindLongestWord(matrix, n, r, c, 'l');
                    if (left.Length > maxWord.Length || (left.Length == maxWord.Length && left.CompareTo(maxWord) < 0))
                    {
                        maxWord = left;
                    }

                    string right = FindLongestWord(matrix, n, r, c, 'r');
                    if (right.Length > maxWord.Length
                        || (right.Length == maxWord.Length && right.CompareTo(maxWord) < 0))
                    {
                        maxWord = right;
                    }

                    string up = FindLongestWord(matrix, n, r, c, 'u');
                    if (up.Length > maxWord.Length || (up.Length == maxWord.Length && up.CompareTo(maxWord) < 0))
                    {
                        maxWord = up;
                    }

                    string down = FindLongestWord(matrix, n, r, c, 'd');
                    if (down.Length > maxWord.Length || (down.Length == maxWord.Length && down.CompareTo(maxWord) < 0))
                    {
                        maxWord = down;
                    }
                }
            }

            Console.WriteLine(maxWord);
        }

        private static string FindLongestWord(char[,] matrix, int n, int r, int c, char d)
        {
            StringBuilder word = new StringBuilder(n);
            word.Append(matrix[r, c]);
            char curChar = matrix[r, c];
            switch (d)
            {
                case 'r':
                    c++;
                    while (c < n)
                    {
                        char nextChar = matrix[r, c];
                        if (curChar < nextChar)
                        {
                            word.Append(nextChar);
                            curChar = nextChar;
                        }
                        else
                        {
                            break;
                        }

                        c++;
                    }

                    break;
                case 'l':
                    c--;
                    while (c >= 0)
                    {
                        char nextChar = matrix[r, c];
                        if (curChar < nextChar)
                        {
                            word.Append(nextChar);
                            curChar = nextChar;
                        }
                        else
                        {
                            break;
                        }

                        c--;
                    }

                    break;
                case 'u':
                    r--;
                    while (r >= 0)
                    {
                        char nextChar = matrix[r, c];
                        if (curChar < nextChar)
                        {
                            word.Append(nextChar);
                            curChar = nextChar;
                        }
                        else
                        {
                            break;
                        }

                        r--;
                    }

                    break;
                case 'd':
                    r++;
                    while (r < n)
                    {
                        char nextChar = matrix[r, c];
                        if (curChar < nextChar)
                        {
                            word.Append(nextChar);
                            curChar = nextChar;
                        }
                        else
                        {
                            break;
                        }

                        r++;
                    }

                    break;
            }

            return word.ToString();
        }

        static int sumChars(string word)
        {
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                sum += word[i];
            }

            return sum;
        }
    }
}