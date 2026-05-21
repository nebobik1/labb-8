using System;

namespace Lab8
{
    public interface IInfoItem
    {
        string Name { get; set; }

        void DisplayInfo();
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