using System;

namespace Lab8
{
    public class Manager : Employee
    {
        public int TeamSize { get; set; }
        public string Department { get; set; }

        public Manager() : base()
        {
            TeamSize = 0;
            Department = "Unknown";
        }

        public Manager(string name, double salary, Position position,
                       int teamSize, string department)
                       : base(name, salary, position)
        {
            TeamSize = teamSize;
            this.Department = department;
        }

        public override double CalculateBonus()
        {
            return Salary * 0.2 + (TeamSize * Salary * 0.02);
        }

        public override string ToString()
        {
            return $"Менеджер: {Name}, ID: {ID}, Зарплата: {Salary:C}, " +
                   $"Должность: {Position}, Отдел: {Department}, " +
                   $"Команда: {TeamSize} чел., Бонус: {CalculateBonus():C}";
        }


    }
}