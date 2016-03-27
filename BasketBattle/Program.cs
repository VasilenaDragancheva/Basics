namespace BasketBattle
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();
            string secondPlayer = firstPlayer == "Nakov" ? "Simeon" : "Nakov";

            int rounds = int.Parse(Console.ReadLine());
            int scoresFirst = 0;
            int scoresSecond = 0;

            for (int i = 1; i <= rounds; i++)
            {
                bool oddRound = i % 2 == 1;
                if (oddRound)
                {
                    int scores1 = int.Parse(Console.ReadLine());
                    string success1 = Console.ReadLine();
                    if (success1 == "success")
                    {
                        if (scoresFirst + scores1 < 500)
                        {
                            scoresFirst += scores1;
                        }
                        else if (scoresFirst + scores1 == 500)
                        {
                            scoresFirst += scores1;
                            PrintResults(firstPlayer, i, scoresSecond);
                            break;
                        }
                    }

                    int scores2 = int.Parse(Console.ReadLine());
                    string success2 = Console.ReadLine();
                    if (success2 == "success")
                    {
                        if (scoresSecond + scores2 < 500)
                        {
                            scoresSecond += scores2;
                        }
                        else if (scoresSecond + scores2 == 500)
                        {
                            scoresSecond += scores2;
                            PrintResults(secondPlayer, i, scoresFirst);
                            break;
                        }
                    }
                }

                if (!oddRound)
                {
                    int scores1 = int.Parse(Console.ReadLine());
                    string success1 = Console.ReadLine();
                    if (success1 == "success")
                    {
                        if (scoresSecond + scores1 < 500)
                        {
                            scoresSecond += scores1;
                        }
                        else if (scoresSecond + scores1 == 500)
                        {
                            scoresSecond += scores1;
                            PrintResults(secondPlayer, i, scoresFirst);
                            break;
                        }
                    }

                    int scores2 = int.Parse(Console.ReadLine());
                    string success2 = Console.ReadLine();
                    if (success2 == "success")
                    {
                        if (scoresFirst + scores2 < 500)
                        {
                            scoresFirst += scores2;
                        }
                        else if (scoresFirst + scores2 == 500)
                        {
                            scoresFirst += scores2;
                            PrintResults(firstPlayer, i, scoresSecond);
                            break;
                        }
                    }
                }
            }

            if (scoresFirst == scoresSecond && scoresFirst < 500)
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(scoresFirst);
            }
            else if (scoresFirst != scoresSecond && scoresSecond < 500 && scoresFirst < 500)
            {
                Console.WriteLine(scoresFirst > scoresSecond ? firstPlayer : secondPlayer);
                Console.WriteLine(Math.Abs(scoresFirst - scoresSecond));
            }
        }

        private static void PrintResults(string firstPlayer, int i, int scoresSecond)
        {
            Console.WriteLine(firstPlayer);
            Console.WriteLine(i);
            Console.WriteLine(scoresSecond);
        }
    }
}