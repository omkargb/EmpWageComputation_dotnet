using System;

namespace EmpWageCalc
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Employee Wage Computation Program ");

            //string company, int wagePerHr, int maxWorkingHrs, int maxWorkingDays
            ComputeWork company1 = new ComputeWork("company1", 20, 100, 25);
            ComputeWork company2 = new ComputeWork("company2", 30, 150, 20);

            company1.CalcWage();
            company2.CalcWage();

            Console.WriteLine(company1.CompanyAndWage());
            Console.WriteLine(company2.CompanyAndWage());
            Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
        }
    }
}
