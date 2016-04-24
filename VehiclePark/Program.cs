using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var vehicles = Console.ReadLine().Split(' ').ToList();
            int total = vehicles.Count;


            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End of customers!")
                {
                    break;
                }
                string[] vehicle = line.Split(' ');
                string veh = vehicle[0][0].ToString().ToLower() + vehicle[2];
                if (vehicles.Contains(veh))
                {

                    Console.WriteLine("Yes, sold for {0}$", (int)veh[0] * int.Parse(vehicle[2]));
                    vehicles.Remove(veh);
                }
                else
                {
                    Console.WriteLine("No");
                }
            }

            Console.WriteLine("Vehicles left: {0}", string.Join(", ", vehicles));
            Console.WriteLine("Vehicles sold: {0}", total - vehicles.Count);
        }
    }
}
