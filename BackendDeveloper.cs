using System;

namespace Lab8
{
    public class BackendDeveloper : Developer, IInfoItem
    {

        public bool KnowsCloud { get; set; }

        public BackendDeveloper() : base()
        {
            KnowsCloud = false;
        }

        public BackendDeveloper(string name, double salary, Position position,
                               string language, int experience,
                                 bool knowsCloud)
                                  : base(name, salary, position, language, experience)
        {
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
                   $"Облачные технологии: {(KnowsCloud ? "Да" : "Нет")}, " +
                   $"Бонус: {CalculateBonus():C}";
        }

        public void DisplayInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}