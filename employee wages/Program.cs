using System;

namespace employee_wages
{
    class Program
    {
        static void Main(string[] args)
        {
            int EMPLOYEE_PRESENT = 1;
            int HOURLY_WAGE = 20;
            int totalWages;
            int FULL_TIME_WORKING_HOURS = 8;
            int PART_TIME_WORKING_HOURS = 4;
            int PART_TIME = 0;

            Random rand = new Random();
            int empAttendance = rand.Next(0, 2);

            if (empAttendance == EMPLOYEE_PRESENT)
            {
                int employeeStatus = rand.Next(0,2);
                if(employeeStatus == PART_TIME)
                {
                    totalWages = HOURLY_WAGE * empAttendance * PART_TIME_WORKING_HOURS;
                }
                else
                {
                    totalWages = HOURLY_WAGE * empAttendance * FULL_TIME_WORKING_HOURS;
                }
            }
            else
            {
                totalWages = HOURLY_WAGE * empAttendance * 0;
            }
            Console.WriteLine("The daily wage is " + totalWages);
        }
    }
}