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

            cw.CalcDailywage();


        }
    }
}
