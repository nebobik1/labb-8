using System;

namespace Lab8
{
    public class BackendDeveloper : Developer, IInfoItem
    {
        public string DatabaseTech { get; set; }
        public bool KnowsCloud { get; set; }

        public BackendDeveloper() : base()
        {
            DatabaseTech = "Unknown";
            KnowsCloud = false;
        }

        public BackendDeveloper(string name, double salary, Position position,
                               string language, int experience,
                                string database, bool knowsCloud)
                                  : base(name, salary, position, language, experience)
        {
            DatabaseTech = database;
            KnowsCloud = knowsCloud;
        }

        public override double CalculateBonus()
        {
            double baseBonus = base.CalculateBonus();
            if (KnowsCloud)
                baseBonus += Salary * 0.15;
            return baseBonus;
        }

        public override string ToString()
        {
            return $"Backend-разработчик: {Name}, ID: {ID}, Зарплата: {Salary:C}, " +
                   $"Должность: {Position}, Язык: {ProgrammingLanguage}, Опыт: {ExperienceYears} лет, " +
                   $"БД: {DatabaseTech}, Облачные технологии: {(KnowsCloud ? "Да" : "Нет")}, " +
                   $"Бонус: {CalculateBonus():C}";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}