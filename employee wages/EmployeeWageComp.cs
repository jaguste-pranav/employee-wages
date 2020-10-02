using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WageComp
{
    public class EmployeeWageComp : IComputeWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private List<ComputeWage> companyEmpWagesList = new List<ComputeWage>();

        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            ComputeWage companyEmpWage = new ComputeWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            companyEmpWagesList.Add(companyEmpWage);

        }

        public void ComputeEmpWage()
        {
            foreach (ComputeWage companyEmpWage in companyEmpWagesList)
            {
                int totalEmpWageTemp = this.ComputeEmpWage(companyEmpWage);
                companyEmpWage.SettotalEmpWage(totalEmpWageTemp);
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        public int ComputeEmpWage(ComputeWage companyEmpWage)
        {
            int totalEmpHours = 0;
            int workingDays = 0;
            int empHours;
            int totalWagePerDay;
            int totalWagePerMonth = 0;
            while (totalEmpHours < companyEmpWage.maxHoursPerMonth && workingDays < companyEmpWage.numOfWorkingDays)
            {
                empHours = GetWorkingHours();

                    workingDays++;
                    totalEmpHours = empHours + totalEmpHours;
                    totalWagePerDay = empHours * companyEmpWage.ratePerHours;
                    totalWagePerMonth += totalWagePerDay;
                    Console.WriteLine("Total Wage of the day.." + totalWagePerDay);
            }
            return totalWagePerMonth;

        }

        public int GetWorkingHours()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int empHours = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case FULL_TIME:
                    empHours = 8;
                    break;
                case PART_TIME:
                    empHours = 4;
                    break;
                default:
                    empHours = 0;
                    break;
            }
            return empHours;
        }
    }
}