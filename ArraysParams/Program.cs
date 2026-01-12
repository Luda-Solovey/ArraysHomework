using System.Security.Cryptography.X509Certificates;

namespace ArraysParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] employeesSalaries = new double[] { 30025, 1002.48, 8956, 7456, 8000, 1000 };

            ArraysParamsHW.Employees employees = new ArraysParamsHW.Employees(); //чомусь не працює без простору імен? (перейменовувала проект, можливо через це)
            employees.ReturnMinMaxAvgSalaries(out double minSalary, out double avgSalary, out double maxSalary, employeesSalaries);

            employees.ReturnMinMaxSalariesLinq(out double minSalaryLinq, out double maxSalaryLinq, out double avgSalaryLinq, employeesSalaries);
        }
    }
}
