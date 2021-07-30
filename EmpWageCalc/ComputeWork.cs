using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageCalc
{
    public class ComputeWork
    {
        public void CalcWage(string company, int wagePerHr, int maxWorkingHrs, int maxWorkingDays)
        {
            Random random = new Random();
            int dailyWage;
            int monthWage = 0;
            int WorkHrs;
            const int isPartTime = 0, isFullTime = 1;
            int totalEmpHrs = 0, totalWorkingDays = 0;
            
            while ( totalEmpHrs < maxWorkingHrs  && totalWorkingDays < maxWorkingDays)
            {
                int empPresent = random.Next(0, 3);     // generates 0 to 2
                switch (empPresent)
                {
                    case isPartTime:
                            WorkHrs = 4;
                            break;
                    case isFullTime:
                            WorkHrs = 8;
                            break;
                    default:            //empPresent is 0 - Employee is Absent
                            WorkHrs = 0;
                            break;
                }
                dailyWage = WorkHrs * wagePerHr;
                monthWage += dailyWage;
                totalWorkingDays++;
                totalEmpHrs += WorkHrs;
            }

            Console.WriteLine(" {0} \t {1} \t\t {2} \t\t {3} \t\t {4}", company, wagePerHr, maxWorkingHrs, maxWorkingDays, monthWage);
        }
    }
}

