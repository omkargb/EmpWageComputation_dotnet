using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageCalc
{
    public class ComputeWork
    {
        public void EmpAttCheck(int empPresent)
        { 
            if (empPresent == 1)
            {
            }
            else
            {
                Console.WriteLine(" Employee is absent.");
            }
        }

        public void CalcDailywage(int empPresent)
        {
            int wagePerHr = 20;
            int WorkHrs=0;

            switch (empPresent) 
            {
                case 1:
                    Console.WriteLine(" Employee is present Part Time.");
                    WorkHrs = 4;
                    break;
                case 2:
                    Console.WriteLine(" Employee is present Full Time.");
                    WorkHrs = 8;
                    break;
                default:    //empPresent is 0
                    Console.WriteLine(" Employee is Absent.");
                    break;
            }

            Console.WriteLine("\n [ Calculating Employee Wage ] ");

            int dailyWage = WorkHrs * wagePerHr;
            Console.WriteLine(" Employee Wage : " +dailyWage);
        }

    }
}
