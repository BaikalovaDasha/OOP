using Model;
using System;

namespace LR_1
{
    /// <summary>
    /// Класс с функциями.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Основная функция.
        /// </summary>
        public static void Main()
        {
            var listOne = new PersonList();
            var listTwo = new PersonList();

            var arrayOne = new Person[]
            {
                new Person("Дарья", "Байкалова", 23, Gender.Male),
                new Person("Алина", "Жиркова", 15, Gender.Male),
                new Person("Катерина", "Фирсова", 55, Gender.Male),
            };

            var arrayTwo = new Person[]
            {
                new Person("Алексей", "Прохоров", 43, Gender.Female),
                new Person("Никита", "Килин", 23, Gender.Female),
                new Person("Дмитрий", "Бондарев", 20, Gender.Female),
            };

            listOne.AddPersonInArray(arrayOne);
            listTwo.AddPersonInArray(arrayTwo);

            Console.WriteLine("Список 1.");
            ConsolePerson.ShowPersonList(listOne);
            Console.WriteLine("");
            Console.WriteLine("Список 2.");
            ConsolePerson.ShowPersonList(listTwo);
            Console.WriteLine("");
        }

    }

}