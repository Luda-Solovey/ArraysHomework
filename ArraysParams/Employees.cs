using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ArraysParamsHW
{
    public class Employees
    {
        //метод повертає мінімальну, середню та максимальну зарплату через визначення значень в циклі for
        public void ReturnMinMaxAvgSalaries(out double minSalary, out double avgSalary, out double maxSalary, params double[] employeesSalaries)
        {
            minSalary = employeesSalaries[0];
            maxSalary = employeesSalaries[0];

            for (int i = 0; i < employeesSalaries.Length; i++)
            {
                if (employeesSalaries[i] < minSalary)
                {
                    minSalary = employeesSalaries[i];
                }
                if (employeesSalaries[i] > maxSalary)
                {
                    maxSalary = employeesSalaries[i];
                }
            }

            double sum = 0;
            for (int i = 0; i < employeesSalaries.Length; i++)
            {
                sum += employeesSalaries[i];
            }
            avgSalary = sum / employeesSalaries.Length;
        }

        //метод повертає мінімальну, середню та максимальну зарплату через Linq
        public void ReturnMinMaxSalariesLinq(out double minSalary, out double maxSalary, out double avgSalary, params double[] employeesSalaries)
        {
            minSalary = employeesSalaries.Min();
            maxSalary = employeesSalaries.Max();
            avgSalary = employeesSalaries.Average();
        }
    }
}
