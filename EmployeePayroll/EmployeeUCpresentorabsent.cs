using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    internal class EmployeeUCpresentorabsent
    {
        public static void EmpAttendenceCheck()
        {
            Random random = new Random();
            int empAtt = random.Next(2);
            if (empAtt == 0)
                Console.WriteLine("employee is present");
            else
                Console.WriteLine("employee is absent");
        }
       
    }
}
