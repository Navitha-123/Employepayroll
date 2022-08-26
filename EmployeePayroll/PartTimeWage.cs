using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class PartTimeWage
    {
        public static void CalculatePercentage()
        {
           /* Console.WriteLine("Enter your percentage: ");
            int percentage=Convert.ToInt32(Console.ReadLine());

            if(percentage>=80)
            {
                Console.WriteLine("A1");
            }
            else if(percentage>=70)
            {
                Console.WriteLine("A");
            }
            else if(percentage>=60)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("C");
            }*/

            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            Random random = new Random();   
            int empcheck=random.Next(1,3);//1,2

            if(empcheck==IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Emp is present full time");
            }
            else if(empcheck==IS_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("Emp is present for part time");
            }
            else 
            {
                empHrs = 0;
                Console.WriteLine("Emp absent");
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine(" emp daily wage including part time is " + empWage);
        }
    }
}
