using System;

namespace EmpWageCalc
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Employee Wage Computation Program ");
            ComputeWork cw = new ComputeWork();

            //UC4 : Solving using Switch Case Statement

            Console.WriteLine("\n [ Checking employee attendance ] "); 
            Random random = new Random();
            int empPresent = random.Next(0, 3);     // generates 0 and 1

            cw.CalcDailywage(empPresent);


        }
    }
}
