using System.Globalization;

namespace SalaryIncrease
{
    internal class Employee
    {
        public string name;
        public double grossSalary;
        public double tax;
        public double NetSalary()
        {
            return grossSalary - tax;
        }

        public void Increase(double percentage)
        {
            grossSalary = grossSalary + (grossSalary * percentage / 100.0);
        }

        public override string ToString()
        {
            return name 
                + ", R$ " 
                + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
