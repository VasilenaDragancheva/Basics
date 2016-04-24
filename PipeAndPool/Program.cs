namespace PipeAndPool
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int debitPipe1 = int.Parse(Console.ReadLine());
            int debitPipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double pipe1 = hours * debitPipe1;
            double pipe2 = hours * debitPipe2;
            double total = pipe1 + pipe2;

            if (total > v)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, total - v);
            }
            else
            {
                int full =(int) (100 * total / v);

                int p1 = (int) (100 * pipe1 / total);
                int p2 = (int) (100 * pipe2 / total);
                Console.WriteLine("The pool is {0:f0}% full. Pipe 1: {1:f0}%. Pipe 2: {2:f0}%.", full, p1, p2);
            }
        }
    }
}