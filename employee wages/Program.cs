using System;

namespace employee_wages
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputeWages A = new ComputeWages();
            A.setCompanyInfo("A", 30, 20, 100);
            A.getEmpWages();

            ComputeWages B = new ComputeWages();
            B.setCompanyInfo("B", 20, 20, 100);
            B.getEmpWages();

        }
    }
}