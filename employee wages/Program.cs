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

            Random rand = new Random();

            for (int day = 0; day < WORKING_DAYS; day++)
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

            Console.WriteLine("The monthly wages are " + monthlyWages);
        }
    }
}