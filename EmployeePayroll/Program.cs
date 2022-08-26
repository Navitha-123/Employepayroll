namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Payroll");
            Console.WriteLine("choose option\n 1.check absent \t 2. DailyWage \t 3. PartTimeWage \t 4.emp wage for month ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
            case 1:
                 EmployeeUCpresentorabsent.EmpAttendenceCheck();
                    break;
                case 2:
                    DailyWageUC2.CalculateDailyWage();
                    break;
                case3:
                    PartTimeWage.CalculatePercentage();
                case4:
                    WageForMonth.CalculateWageForMonth();
                default:
                    Console.WriteLine( "Enterd wrong choice");
                break;
            }            
        }
    }
}