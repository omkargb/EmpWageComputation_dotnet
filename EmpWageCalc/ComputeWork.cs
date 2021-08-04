using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageCalc
{
    public class ComputeWork
    {
        public const int isPartTime = 0;
        public const int isFullTime = 1;

        private string company;
        private int wagePerHr;
        private int totalEmpWage;
        private int maxWorkingHrs;
        private int maxWorkingDays;

        //Use Instance Variables
        public ComputeWork(string company, int wagePerHr, int maxWorkingHrs, int maxWorkingDays)
        {
            this.company = company;
            this.wagePerHr = wagePerHr;
            this.maxWorkingHrs = maxWorkingHrs;
            this.maxWorkingDays = maxWorkingDays;
        }
        public void CalcWage()
        {
            Random random = new Random();

            int WorkHrs;
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
                
                totalWorkingDays++;
                totalEmpHrs += WorkHrs;

            }
            totalEmpWage = totalEmpHrs * this.wagePerHr;
        }

        public string CompanyAndWage()
        {
            return " Total employee wage for : " + this.company+ " is Rs. : "+this.totalEmpWage;
        }
    }
}