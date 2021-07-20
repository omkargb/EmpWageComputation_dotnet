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
                Console.WriteLine(" Employee is present. \n");
            }
            else
            {
                Console.WriteLine(" Employee is absent. \n");
            }
        }    
}
}
