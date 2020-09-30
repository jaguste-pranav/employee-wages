using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace employee_wages
{
    class ComputeWages
    {
        const int PART_TIME = 1;
        const int FULL_TIME = 2;
        const int RATE_PER_HOUR = 20;

        public int getEmpWages(string companyName, int ratePerHr, int workingDays, int maxHrsPerMonth)
        {
            int empWages, empHours;
            int totalWorkingHrs = 0, totalWorkingDays = 0;

            while (totalWorkingHrs <= maxHrsPerMonth && totalWorkingDays <= workingDays)
            {
                Random rand = new Random();
                int empStatus = rand.Next(0, 3);
                totalWorkingDays++;

                switch (empStatus)
                {
                    case PART_TIME:
                        empHours = 4;
                        break;
                    case FULL_TIME:
                        empHours = 8;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                totalWorkingHrs = totalWorkingHrs + empHours;
            }
            empWages = totalWorkingHrs * ratePerHr;
            Console.WriteLine("The wages for employee at "+ companyName+ " is "+ empWages);
            return empWages;
        }
    }
}
