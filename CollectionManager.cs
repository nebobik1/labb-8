using System;
using System.Collections.Generic;

namespace Lab8
{
    public class CollectionManager
    {
        private List<IInfoItem> items;

        public CollectionManager()
        {
            items = [];
        }

        public static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введите целое число.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }

        public static double ReadDouble(string message)
        {
            while (true)
            {
                Console.Write(message);
                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введите корректное число.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }

        public void AddItem()
        {
            Console.WriteLine("\nВыберите тип объекта:");
            Console.WriteLine("1. Backend-разработчик (BackendDeveloper)");
            Console.WriteLine("2. Project-менеджер (ProjectManager)");
            Console.WriteLine("3. Отдел компании (Department)");

            int type = ReadInt("Ваш выбор: ");

            try
            {
                if (type == 3)
                {
                    Console.Write("Название отдела: ");
                    string deptName = Console.ReadLine() ?? "Unknown";
                    int count = ReadInt("Количество сотрудников: ");
                    items.Add(new Department(deptName, count));
                    Console.WriteLine("Отдел успешно добавлен!");
                    return;
                }

                Console.Write("Имя сотрудника: ");
                string name = Console.ReadLine() ?? "Unknown";
                double salary = ReadDouble("Зарплата: ");
                Position pos = (Position)ReadInt("Должность (1-Trainee, 2-Junior, 3-Senior, 4-Master): ");

                switch (type)
                {
                    case 1:
                        Console.Write("Язык программирования: ");
                        string backLang = Console.ReadLine() ?? "Unknown";
                        int backExp = ReadInt("Опыт работы (лет): ");
                        int cloud = ReadInt("Знает облачные технологии (1-Да, 0-Нет): ");
                        items.Add(new BackendDeveloper(name, salary, pos, backLang, backExp, cloud == 1));
                        break;
                    case 2:
                        int pmTeamSize = ReadInt("Размер команды: ");
                        Console.Write("Отдел: ");
                        string pmDept = Console.ReadLine() ?? "Unknown";
                        int projects = ReadInt("Количество активных проектов: ");
                        double budget = ReadDouble("Бюджет проектов: ");
                        items.Add(new ProjectManager(name, salary, pos, pmTeamSize, pmDept, projects, budget));
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        return;
                }
                Console.WriteLine("Сотрудник успешно добавлен!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        public void PrintAll()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("\nКоллекция пуста!\n");
                return;
            }

            Console.WriteLine("Содержимое коллекции");

            for (int i = 0; i < items.Count; i++)
            {
                Console.Write($"[{i}] ");
                items[i].DisplayInfo();
            }
        }

        public void ReverseNames()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Коллекция пуста.");
                return;
            }

            foreach (var item in items)
            {
                item.ReverseName();
            }
            Console.WriteLine("\nИмена объектов успешно перевернуты");
        }

        public void DeleteItem()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Коллекция пуста.");
                return;
            }

            PrintAll();
            int index = ReadInt("Введите индекс элемента: ");

            try
            {
                items.RemoveAt(index);
                Console.WriteLine("Элемент успешно удален!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка! Элемента с таким индексом не существует.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при удалении: {ex.Message}");
            }
        }

        public void FillData()
        {
            items.Add(new Department("IT Отдел", 25));
            items.Add(new BackendDeveloper("Иван", 2500, Position.Junior, "C#", 4, true));
            items.Add(new ProjectManager("Анна", 3500, Position.Senior, 12, "Разработка", 4, 100000));
            Console.WriteLine("Коллекция заполнена.");
        }
    }
}