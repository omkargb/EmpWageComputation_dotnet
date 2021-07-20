using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageCalc
{
    public class ComputeWork
    {
        public void CalcDailywage()
        {
            Console.WriteLine("\n [ Checking employee attendance and displaying wage per day ] \n");
            Random random = new Random();
            int dailyWage = 0;
            int monthWage = 0;
            int wagePerHr = 20;
            int WorkHrs;

            int maxWorkingDays = 20;
            int maxWorkingHrs = 100;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while ( totalEmpHrs < maxWorkingHrs  && totalWorkingDays < maxWorkingDays)
            {
                int empPresent = random.Next(0, 3);     // generates 0 to 2
                switch (empPresent)
                {
                    case 1:
                        //Console.WriteLine(" Employee is present Part Time.");
                        WorkHrs = 4;
                        break;
                    case 2:
                        //Console.WriteLine(" Employee is present Full Time.");
                        WorkHrs = 8;
                        break;
                    default:    //empPresent is 0
                        //Console.WriteLine(" Employee is Absent.");
                        WorkHrs = 0;
                        break;
                }
                dailyWage = WorkHrs * wagePerHr;
                monthWage = monthWage + dailyWage;
                totalWorkingDays++;
                totalEmpHrs = totalEmpHrs + WorkHrs;

                Console.WriteLine(" Day: " + totalWorkingDays + "  Wage: " + dailyWage + "\tHrs: "+ totalEmpHrs);
            }

            Console.WriteLine("\n Total working Days : " + totalWorkingDays+ "\t Total working Hours : " + totalEmpHrs);
            Console.WriteLine("\n [ Calculating Employee's monthly Wage ] ");
            Console.WriteLine(" Total Wage : " + monthWage);
        }
    }
}
