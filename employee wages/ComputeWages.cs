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

        private string companyName = "";
        private int ratePerHr;
        private int maxWorkingDays;
        private int maxHrsPerMonth;

        public void setCompanyInfo(string companyName, int ratePerHr, int maxWorkingDays, int maxHrsPerMonth)
        {
            this.companyName = companyName;
            this.ratePerHr = ratePerHr;
            this.maxWorkingDays = maxWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }

        public int getEmpWages()
        {
            int empWages, empHours;
            int totalWorkingHrs = 0, totalWorkingDays = 0;

            while (totalWorkingHrs <= this.maxHrsPerMonth && totalWorkingDays <= this.maxWorkingDays)
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
            Console.WriteLine("The wages for employee at "+ this.companyName+ " is "+ empWages);
            return empWages;
        }
    }
}
