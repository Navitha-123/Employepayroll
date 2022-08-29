namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Payroll");
            Console.WriteLine("choose option\n 1.check absent \t 2. DailyWage \t 3. PartTimeWage  \t 4.Daily wage switch \t 5.emp wage for month ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
            case 1:
                 EmpPresentAbsent.EmpAttendenceCheck();
                    break;
                case 2:
                    EmpDailyWage.CalculateDailyWage();
                    break;
                case 3:

                    PartTimeWage.CalculatePercentage();
                    break;
                case 4:
                    EmpSwitchCase.CalculateDailyWageswitch();
                    break;
                case 5:
                      WageForMonth.CalculateWageForMonth();
                    break;
                case 6:
                    WagesForMonthWhileLoop.CalculateWage();
                    break;
                default:
                    Console.WriteLine( "Enterd wrong choice");
                break;
            }            
        }
    }
}