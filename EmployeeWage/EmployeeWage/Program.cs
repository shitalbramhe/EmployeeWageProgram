using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the Employee Wage Problem");
            EmpWage employee = new EmpWage();
            employee.computeEmpwage("DMart", 20,2,10);
            employee.computeEmpwage("Reliance", 10, 4, 20);
        }
    }
}
