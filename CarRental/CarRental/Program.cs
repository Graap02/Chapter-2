using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PRICE_PER_DAY = 20;
            const double PRICE_PER_MILE = 0.25;
            double days;
            double miles;
            Console.WriteLine("Please enter any number of days >> ");
            days = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter any number of miles >> ");
            miles = Convert.ToDouble(Console.ReadLine());

            double payDays = PRICE_PER_DAY * days;
            double payMiles = PRICE_PER_MILE * miles;
            double total = payMiles + payDays;

            Console.WriteLine("The vehicle will cost {0}, as a result of {1} from the car being held for {2} days, and {3} from being driven {4} miles.", 
                total, payDays, days, payMiles, miles);
        }
    }
}
