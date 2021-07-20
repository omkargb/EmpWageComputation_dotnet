using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageCalc
{
    public class ComputeWork
    {
        public void CalcDailywage()
        {
            Console.WriteLine("\n [ Checking employee attendance and displaying wage per day ] ");
            Random random = new Random();
            int dailyWage=0;
            int monthWage = 0;
            int wagePerHr = 20;
            int WorkHrs;
            int numOfDays = 20;

            for (int day = 1; day <= numOfDays; day++ )
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
                Console.Write( " " + dailyWage + " |");
                monthWage = monthWage + dailyWage;
            }

            Console.WriteLine("\n\n [ Calculating Employee's monthly(20 days) Wage ] ");
            Console.WriteLine(" Total Wage : " + monthWage);
        }
    }
}
