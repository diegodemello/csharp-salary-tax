namespace SalaryIncrease
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Nome: ");
            employee.name = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            employee.grossSalary = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            employee.tax = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + employee);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentage = double.Parse(Console.ReadLine());
            employee.Increase(porcentage);

            Console.WriteLine("Funcionário: " + employee);
        }
    }
}
