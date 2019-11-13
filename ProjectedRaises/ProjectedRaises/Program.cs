using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedRaises
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PREDICTED_RAISES = 1.04;
            double employeeSalary1;
            double employeeSalary2;
            double employeeSalary3;

            Console.WriteLine("What is emplyee 1's salary this year? >> ");
            employeeSalary1 = Convert.ToDouble(Console.ReadLine());
            calculateRaise(employeeSalary1, PREDICTED_RAISES, 1);

            Console.WriteLine("What is emplyee 2's salary this year? >> ");
            employeeSalary2 = Convert.ToDouble(Console.ReadLine());
            calculateRaise(employeeSalary2, PREDICTED_RAISES, 2);

            Console.WriteLine("What is emplyee 3's salary this year? >> ");
            employeeSalary3 = Convert.ToDouble(Console.ReadLine());
            calculateRaise(employeeSalary3, PREDICTED_RAISES, 3);

        }
        public static void calculateRaise(double raise, double salary, int empNum)
        {
            salary = salary * raise;
            Console.WriteLine("Employee {1} salary is {0}", salary, empNum);
        }
    }
}
