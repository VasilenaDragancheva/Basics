namespace ExamSchedule
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            if (time == "PM")
            {
                hour += 12;
                if (hour == 24)
                {
                    hour = 0;
                }
            }

            DateTime start = new DateTime(2015, 07, 01, hour, minutes, 0);
            DateTime end = start.AddHours(examHours).AddMinutes(examMinutes);

            Console.WriteLine("{0:hh:mm:tt}", end);
        }
    }
}