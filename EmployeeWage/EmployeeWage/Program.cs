using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Problem");
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 20, 100);
            empWageBuilder.addCompanyEmpWage("PVP", 30, 24, 160);
            empWageBuilder.computeEmpWage();
        }
    }
}
