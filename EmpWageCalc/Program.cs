using System;

namespace EmpWageCalc
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Employee Wage Computation Program ");
            ComputeWork cw = new ComputeWork();
            Console.WriteLine("\n Company\tWagePerHr\tMaxWorkingHrs\tMaxWorkingDays\tTotal Wage ");
            Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
            cw.CalcWage("company1", 20, 100, 25);
            cw.CalcWage("company2", 30, 150, 20);
        }
    }
}
