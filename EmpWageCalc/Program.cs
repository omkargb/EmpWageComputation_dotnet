using System;

namespace EmpWageCalc
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Employee Wage Computation Program ");
            ComputeWork cw = new ComputeWork();

            /* #UC1 : Checking employee attendance
            Console.WriteLine(" [ Checking employee attendance ] "); 
            Random random = new Random();
            int empPresent = random.Next(0, 2);     // generates 0 and 1
            cw.EmpAttCheck(empPresent);
            */

            //#UC2 : Calculate Daily Employee Wage
            Console.WriteLine(" [ Calculating Daily Employee Wage ] ");
            cw.CalcDailywage();

        }
    }
}
