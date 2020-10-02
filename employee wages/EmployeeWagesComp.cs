using System;
using System.Collections.Generic;
using System.Text;

namespace WageComp
{
    public class EmployeeWageComp
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.addCompanyEmpWage("Google", 200, 10, 50);
            program.addCompanyEmpWage("Microsoft", 160, 10, 50);
            program.computeWage();

        }
    }
}