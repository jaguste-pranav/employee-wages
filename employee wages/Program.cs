﻿using System;

namespace employee_wages
{
    class Program
    {
        static void Main(string[] args)
        {
            int EMPLOYEE_PRESENT = 1;

            Random rand = new Random();
            int empAttendance = rand.Next(0, 2);

            if (empAttendance == EMPLOYEE_PRESENT)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}