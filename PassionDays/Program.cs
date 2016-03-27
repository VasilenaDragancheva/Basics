namespace PassionDays
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string enter;
            int purchasesMade = 0;
            while (true)
            {
                enter = Console.ReadLine();
                if (enter == "mall.Enter")
                {
                    break;
                }
            }

            string purchase;
            while (true)
            {
                purchase = Console.ReadLine();
                if (purchase == "mall.Exit")
                {
                    break;
                }

                foreach (char ch in purchase)
                {
                    if (ch == '*')
                    {
                        money += 10;
                    }
                    else if (money > 0 && ch == '%')
                    {
                        money *= 0.5M;
                        purchasesMade++;
                    }
                    else
                    {
                        decimal moneySpent = ch;
                        if (char.IsUpper(ch))
                        {
                            moneySpent *= 0.5M;
                        }
                        else if (char.IsLower(ch))
                        {
                            moneySpent *= 0.3M;
                        }

                        if (money >= moneySpent)
                        {
                            money -= moneySpent;
                            purchasesMade++;
                        }
                    }
                }
            }

            Console.WriteLine(
                purchasesMade == 0
                    ? string.Format("No purchases. Money left: {0:f2} lv.", money)
                    : string.Format("{0} purchases. Money left: {1:f2} lv.", purchasesMade, money));
        }
    }
}