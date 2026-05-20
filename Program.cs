using System;

namespace Lab8
{
    class Program
    {
        static void Main()
        {
            bool exit = false;
            CollectionManager manager = new();

            while (!exit)
            {
                Console.WriteLine("\nМеню");
                Console.WriteLine("1. Заполнить коллекцию тестовыми данными");
                Console.WriteLine("2. Вывести все элементы коллекции");
                Console.WriteLine("3. Добавить элемент вручную");
                Console.WriteLine("4. Удалить элемент по индексу");
                Console.WriteLine("5. Сделать реверс названий объектов (по заданию)");
                Console.WriteLine("0. Выход");
                Console.Write("Выбор: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.FillDummyData();
                        break;
                    case "2":
                        manager.PrintAll();
                        break;
                    case "3":
                        manager.AddItemInteractive();
                        break;
                    case "4":
                        manager.DeleteItemInteractive();
                        break;
                    case "5":
                        manager.ReverseNames();
                        manager.PrintAll(); // Сразу выводим, чтобы препод увидел результат
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор! Попробуйте снова.");
                        break;
                }
            }
        }
    }
}