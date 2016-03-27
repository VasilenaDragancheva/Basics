namespace MagicCar
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine()) - 40;
            char[] charArray = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };

            int countOfMagic = 0;
            for (int a = 0; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int i = 0; i <= 9; i++)
                    {
                        for (int j = 0; j <= 9; j++)
                        {
                            string string1 = string.Empty + a + a + a + a + charArray[i] + charArray[j];
                            string string2 = string.Empty + a + b + b + b + charArray[i] + charArray[j];
                            string string3 = string.Empty + a + a + a + b + charArray[i] + charArray[j];
                            string string4 = string.Empty + a + a + b + b + charArray[i] + charArray[j];
                            string string5 = string.Empty + a + b + a + b + charArray[i] + charArray[j];
                            string string6 = string.Empty + a + b + b + a + charArray[i] + charArray[j];
                            if (a != b && CalWeight(string1) == weight || CalWeight(string2) == weight
                                || CalWeight(string3) == weight || CalWeight(string4) == weight
                                || CalWeight(string5) == weight || CalWeight(string6) == weight)
                            {
                                countOfMagic++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(countOfMagic);
        }

        static int CalWeight(string str)
        {
            int weight = 0;

            foreach (var element in str)
            {
                switch (element)
                {
                    case 'A':
                        weight += 10;
                        break;
                    case 'B':
                        weight += 20;
                        break;
                    case 'C':
                        weight += 30;
                        break;
                    case 'E':
                        weight += 50;
                        break;
                    case 'H':
                        weight += 80;
                        break;
                    case 'K':
                        weight += 110;
                        break;
                    case 'M':
                        weight += 130;
                        break;
                    case 'P':
                        weight += 160;
                        break;
                    case 'T':
                        weight += 200;
                        break;
                    case 'X':
                        weight += 240;
                        break;
                    case '1':
                        weight += 1;
                        break;
                    case '2':
                        weight += 2;
                        break;
                    case '3':
                        weight += 3;
                        break;
                    case '4':
                        weight += 4;
                        break;
                    case '5':
                        weight += 5;
                        break;
                    case '6':
                        weight += 6;
                        break;
                    case '7':
                        weight += 7;
                        break;
                    case '8':
                        weight += 8;
                        break;
                    case '9':
                        weight += 9;
                        break;
                    case '0':
                        weight += 0;
                        break;
                }
            }

            return weight;
        }
    }
}