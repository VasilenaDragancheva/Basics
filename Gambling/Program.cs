namespace Gambling
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            string[] houseHand = Console.ReadLine().Split(' ');
            decimal strongerHands = 0;
            decimal allPossible = 0;
            decimal currenTstreght = 0;

            for (int i = 0; i < houseHand.Length; i++)
            {
                int streghtCard = 0;
                switch (houseHand[i])
                {
                    case "J":
                        streghtCard = 11;
                        break;
                    case "Q":
                        streghtCard = 12;
                        break;
                    case "K":
                        streghtCard = 13;
                        break;
                    case "A":
                        streghtCard = 14;
                        break;
                    default:
                        streghtCard = int.Parse(houseHand[i]);
                        break;
                }

                currenTstreght += streghtCard;
            }

            for (int firstCard = 2; firstCard <= 14; firstCard++)
            {
                for (int secondCard = 2; secondCard <= 14; secondCard++)
                {
                    for (int thirdCard = 2; thirdCard <= 14; thirdCard++)
                    {
                        for (int fourthCard = 2; fourthCard <= 14; fourthCard++)
                        {
                            int strenght = firstCard + secondCard + thirdCard + fourthCard;

                            if (strenght > currenTstreght)
                            {
                                strongerHands++;
                            }

                            allPossible++;
                        }
                    }
                }
            }

            decimal risk = strongerHands / allPossible;
            decimal expectedWinnings = risk * 2 * cash;
            Console.WriteLine(risk < 0.5M ? "FOLD" : "DRAW");
            Console.WriteLine("{0:F2}", expectedWinnings);
        }
    }
}