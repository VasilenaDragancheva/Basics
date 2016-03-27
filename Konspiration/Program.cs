using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konspiration
{
    public static class Program
    {
       public static void Main()
       {
           int n = int.Parse(Console.ReadLine());
           string methodPattern = @"([A-Z][a-z0-9]{0,})+\(.*?\)";
           string methodDeclarationPattern = @"static\s+[a-z]{3,}\s+";
           string methodUsagPattern = @"(.*?\.)*";


       }
    }
}
