using System;

namespace employee_wages
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagePerHour = 20;
            int empHrs;
            Random r = new Random();

            int checkEmploymentStatus = r.Next(0, 3);
            switch (checkEmploymentStatus)
            {
                case 0:
                    empHrs = 0;
                    Console.WriteLine("The daily wage is " + empHrs * wagePerHour);
                    break;
                case 1:
                    empHrs = 4;
                    Console.WriteLine("The daily wage is " + empHrs * wagePerHour);
                    break;
                case 2:
                    empHrs = 8;
                    Console.WriteLine("The daily wage is " + empHrs * wagePerHour);
                    break;
                default:
                    Console.WriteLine("The wage does not exist");
                    break;

            }
        }
    }
}