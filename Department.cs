using System;

namespace Lab8
{
    public class Department : IInfoItem
    {
        public string Name { get; set; }
        public int EmployeeCount { get; set; }

        public Department(string name, int employeeCount)
        {
            Name = name;
            EmployeeCount = employeeCount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Отдел компании: {Name}, Количество сотрудников: {EmployeeCount}");
        }
    }
}