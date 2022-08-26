namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Payroll");
            Console.WriteLine("choose option\n 1.check absent ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
            case 1:
                 EmployeeUCpresentorabsent.EmpAttendenceCheck();
                    break;

            default:
                    Console.WriteLine( "Enterd wrong choice");
                break;
            }            
        }
    }
}