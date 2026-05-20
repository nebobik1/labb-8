using System;

namespace Lab8
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }
        public int ExperienceYears { get; set; }

        public Developer() : base()
        {
            ProgrammingLanguage = "Unknown";
            ExperienceYears = 0;
        }

        public Developer(string name, double salary, Position position,
                         string language, int experience)
                         : base(name, salary, position)
        {
            ProgrammingLanguage = language;
            ExperienceYears = experience;
        }

        public override double CalculateBonus()
        {
            return Salary * 0.1 + (ExperienceYears * Salary * 0.02);
        }

        public override string ToString()
        {
            return $"Разработчик: {Name}, ID: {ID}, Зарплата: {Salary:C}, " +
                   $"Должность: {Position}, Язык: {ProgrammingLanguage}, " +
                   $"Опыт: {ExperienceYears} лет, Бонус: {CalculateBonus():C}";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}