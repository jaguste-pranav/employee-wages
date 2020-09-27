using System;

namespace employee_wages
{
    class Program
    {
        static void Main(string[] args)
        {
            int EMPLOYEE_PRESENT = 1;
            int HOURLY_WAGE = 20;
            int monthlyWages = 0;
            int dailyWages;
            int WORKING_HOURS = 8;
            int WORKING_DAYS = 20;
            int monthlyWorkingHour = 0;
            int maxMonthlyWorkingHour = 100;

            Random rand = new Random();

            for (int day = 0; day < WORKING_DAYS; day++)
            {
                if (monthlyWorkingHour < maxMonthlyWorkingHour)
                {
                    int empAttendance = rand.Next(0, 2);

                    if (empAttendance == EMPLOYEE_PRESENT)
                    {
                        dailyWages = HOURLY_WAGE * empAttendance * WORKING_HOURS;
                        monthlyWorkingHour = monthlyWorkingHour + empAttendance * WORKING_HOURS;
                    }
                    else
                    {
                        dailyWages = HOURLY_WAGE * empAttendance * WORKING_HOURS;
                        monthlyWorkingHour = monthlyWorkingHour + empAttendance * WORKING_HOURS;
                    }
                    monthlyWages = monthlyWages + dailyWages;
                }
                else
                {
                    monthlyWorkingHour = maxMonthlyWorkingHour;
                    Console.WriteLine("The maximum monthly working hours completed.");
                }
            }

            Console.WriteLine("The monthly wages are " + monthlyWages);
        }
    }
}