namespace Triangle
{
    using System;
    using System.Globalization;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int xA = int.Parse(Console.ReadLine());
            int yA = int.Parse(Console.ReadLine());
            int xB = int.Parse(Console.ReadLine());
            int yB = int.Parse(Console.ReadLine());
            int xC = int.Parse(Console.ReadLine());
            int yC = int.Parse(Console.ReadLine());

            double AB = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
            double BC = Math.Sqrt(Math.Pow(xC - xB, 2) + Math.Pow(yC - yB, 2));
            double AC = Math.Sqrt(Math.Pow(xC - xA, 2) + Math.Pow(yC - yA, 2));
            bool isTriangle = (AB + BC) > AC && (BC + AC) > AB && (AC + AB) > BC;
            if (isTriangle)
            {
                double p = (AB + BC + AC) / 2;
                double area = Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
                Console.WriteLine("Yes");
                Console.WriteLine("{0:F2}", area);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}", AB);
            }
        }
    }
}