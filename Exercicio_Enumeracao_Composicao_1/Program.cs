using System;
using System.Globalization;
using Exercicio_Enumeracao_Composicao_1.Entities;
using Exercicio_Enumeracao_Composicao_1.Entities.Enums;

namespace Exercicio_Enumeracao_Composicao_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            Department departmentsName = new Department(Console.ReadLine().ToString());

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = Convert.ToDouble(Console.ReadLine());

            Worker worker = new Worker(workerName, workerLevel, baseSalary, departmentsName);

            Console.Write("How many contracts to this worker? ");
            int numberOfContracts = Convert.ToInt32(Console.ReadLine());

            ContractGenerator(numberOfContracts);

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] monthAndYear = Console.ReadLine().Split('/');
            int month = int.Parse(monthAndYear[0]);
            int year = int.Parse(monthAndYear[1]);

            Console.WriteLine($"Name: {worker.Name}" +
                $"\nDepartment: {departmentsName.Name}" +
                $"\nIncome for {monthAndYear}: {worker.Income(year, month).ToString("F2")}");
        }

        static void ContractGenerator(int numberOfContracts)
        {
            for (int i = 1; i <= numberOfContracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Value per hour: ");
                double valuePerHour = Convert.ToDouble(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hoursWorked = Convert.ToInt32(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hoursWorked);
            }
        }
    }
}
