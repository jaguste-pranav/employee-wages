using System;
using System.Collections.Generic;
using System.Text;

namespace employee_wages
{
    class ComputeWages
    {
        const int PART_TIME = 1;
        const int FULL_TIME = 2;
        const int RATE_PER_HOUR = 20;

        int empHours, empWages;
        public int getEmployeeWorkingHours(int empStatus)
        {
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
            return empHours;
        }

        public int getEmployeeWages(int workingHours)
        {
            return RATE_PER_HOUR * workingHours;
        }
}
}
