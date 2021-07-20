using System;

namespace EmpWageCalc
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Employee Wage Computation Program ");

            //#UC1 : Checking employee attendance
            Console.WriteLine(" [ Checking employee attendance ] "); 
            Random random = new Random();
            int empPresent = random.Next(0, 2);

            ComputeWork cw = new ComputeWork();   
            cw.EmpAttCheck(empPresent);

        }
    }
}
