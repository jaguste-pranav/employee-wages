﻿using System;

namespace employee_wages
{
    class Program
    {
        static void Main(string[] args)
        {
            int EMPLOYEE_PRESENT = 1;
            int HOURLY_WAGE = 20;
            int totalWages;
            int WORKING_HOURS = 8;

            Random rand = new Random();
            int empAttendance = rand.Next(0, 2);

            if (empAttendance == EMPLOYEE_PRESENT)
            {
                totalWages = HOURLY_WAGE * empAttendance * WORKING_HOURS;
            }
            else
            {
                totalWages = HOURLY_WAGE * empAttendance * WORKING_HOURS;
            }
            Console.WriteLine("The daily wage is " + totalWages);
        }
    }
}