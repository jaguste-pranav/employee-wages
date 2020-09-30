using System;

namespace employee_wages
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputeWages wages = new ComputeWages();
            wages.getEmpWages("A", 20, 20, 100);
            wages.getEmpWages("B", 20, 20, 100);
        }
    }
}