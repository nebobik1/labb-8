using System;

namespace Lab8
{
    public interface IInfoItem
    {
        // Свойство, содержащее название (имя) объекта
        string Name { get; set; }

        // Метод вывода на экран всех полей класса
        void DisplayInfo();

        // Метод, который делает реверс названия объекта (реализация по умолчанию)
        void ReverseName()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                char[] charArray = Name.ToCharArray();
                Array.Reverse(charArray);
                Name = new string(charArray);
            }
        }
    }
}