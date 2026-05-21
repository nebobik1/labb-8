using System;

namespace Lab8
{
    public enum Position
    {
        Trainee = 1,
        Junior,
        Senior,
        Master,
    }

    public abstract class Employee
    {
        private static int _nextId = 1;
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Position Position { get; set; }

        public Employee()
        {
            ID = _nextId++;
            Name = "Unknown";
            Salary = 0;
            Position = Position.Trainee;
        }

        public Employee(string name, double salary, Position position)
        {
            ID = _nextId++;
            Name = name;
            Salary = salary;
            Position = position;
        }

        public abstract double CalculateBonus();
        public abstract override string ToString();

        public virtual double CalculateAnnualSalary()
        {
            return Salary * 12;
        }
    }
}