using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PickACardUI
{
    public class CardPicker
    {
        static Random random = new Random();//Генератор случайных чисел
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }
            return pickedCards;
        }
        //Команда return позволяет метод немедленно прервать выполнение и вернуться к команде, из которой он был вызван
        private static string RandomSuit()
        {
            int value = random.Next(1, 5); //Получить числа от 1 до 4
            if (value == 1) return "Пика";
            if (value == 2) return "Черва";
            if (value == 3) return "Крестя (трефа)";
            else return "Буба (Бубна)";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Туз";
            if (value == 11) return "Валет";
            if (value == 12) return "Дама";
            if (value == 13) return "Король";
            return value.ToString();
        }

        
    }
}