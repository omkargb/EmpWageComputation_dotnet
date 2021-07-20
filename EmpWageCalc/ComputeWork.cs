using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageCalc
{
    public class ComputeWork
    {
        /* public void EmpAttCheck(int empPresent)
        { 
            if (empPresent == 1)
            {
                Console.WriteLine(" Employee is present.");
            }
            else
            {
                Console.WriteLine(" Employee is absent.");
            }
        }
        */

        public void CalcDailywage()
        {
            int workHrs = 8;
            int wagePerHr = 20;
            int dailyWage = workHrs * wagePerHr;
            Console.WriteLine(" Daily wage : "+dailyWage); 
        }
    }
}
