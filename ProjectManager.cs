using System;

namespace Lab8
{
    public class ProjectManager : Manager, IInfoItem
    {
        public int ActiveProjects { get; set; }
        public double Budget { get; set; }

        public ProjectManager() : base()
        {
            ActiveProjects = 0;
            Budget = 0;
        }

        public ProjectManager(string name, double salary, Position position,
                              int teamSize, string department,
                              int projects, double budget)
                              : base(name, salary, position, teamSize, department)
        {
            ActiveProjects = projects;
            Budget = budget;
        }

        public override double CalculateBonus()
        {
            double baseBonus = base.CalculateBonus();
            double projectBonus = Budget * 0.05;
            return baseBonus + projectBonus;
        }

        public override string ToString()
        {
            return $"Project-менеджер: {Name}, ID: {ID}, Зарплата: {Salary:C}, " +
                   $"Должность: {Position}, Отдел: {Department}, Команда: {TeamSize} чел., " +
                   $"Активных проектов: {ActiveProjects}, Бюджет: {Budget:C}, " +
                   $"Бонус: {CalculateBonus():C}";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}