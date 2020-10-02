using System;

namespace WageComp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageComp empWageBuilder = new EmployeeWageComp();
            empWageBuilder.AddCompanyEmpWage("Dmart", 20, 10, 20);
            empWageBuilder.AddCompanyEmpWage("Reliance", 15, 14, 40);

            empWageBuilder.ComputeEmpWage();

        }
    }

    public interface IComputeWage
    {
        void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);

        void ComputeEmpWage();
    }

}