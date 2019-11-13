using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double KILO_TO_MILES = 1.6;  
            double kilos;
            double milesEntry;
            string milesEntryString;

            Console.WriteLine("Please enter a numerical value");
            milesEntryString = Console.ReadLine();
            milesEntry = Convert.ToDouble(milesEntryString);
            kilos = KILO_TO_MILES * milesEntry;
            Console.WriteLine("The number of miles entered was {0}," +
                " and that equals {1} kilometers.", milesEntry, kilos);


        }
    }
}
