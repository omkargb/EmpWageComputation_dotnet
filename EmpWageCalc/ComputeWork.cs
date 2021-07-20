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
            //int FullTime_WorkHrs = 8;
            int PartTime_WorkHrs = 4;
            int wagePerHr = 20;

            int daily_PTWage = PartTime_WorkHrs * wagePerHr;
            //int daily_FTWage = PartTime_WorkHrs * wagePerHr;

            Console.WriteLine(" Daily wage for part time work : " + daily_PTWage);
            //Console.WriteLine(" Daily wage for Full time work : " +daily_FTWage); 
        }

    }
}
