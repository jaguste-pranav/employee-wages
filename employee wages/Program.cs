using System;

namespace employee_wages
{
    class Program
    {
        static void Main(string[] args)
        {
            int empHrs = 0, empWages = 0;
            int totalWorkingHrs = 0, totalWorkingDays = 0;

            ComputeWages compute = new ComputeWages();

            while (totalWorkingHrs <= 10 && totalWorkingDays <= 2)
            {
                Random rand = new Random();
                int empStatus = rand.Next(0, 3);

                totalWorkingDays++;
                empHrs = compute.getEmployeeWorkingHours(empStatus);
                Console.WriteLine("EmpHrs: "+empHrs);
                empWages = empWages + compute.getEmployeeWages(empHrs);
                totalWorkingHrs = totalWorkingHrs + empHrs;
            }
            Console.WriteLine("The wages of employee is "+empWages);
        }
    }
}