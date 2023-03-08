﻿using Model;
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
            Console.WriteLine("Для отображения списков нажмите любую клавишу.");
            Console.ReadKey();
            Console.WriteLine();
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

            Console.WriteLine("\t\t\tСписок 1.");
            ConsolePerson.ShowPersonList(listOne);
            Console.WriteLine();
            Console.WriteLine("\t\t\tСписок 2.");
            ConsolePerson.ShowPersonList(listTwo);
            Console.WriteLine();
            Console.WriteLine("Добавим персону в 1-ый список. Для продолжения" +
                " нажмите любую клавишу.");
            Console.ReadKey();
            Console.WriteLine();
            listOne.AddPerson(ConsolePerson.AddPersonConsole());
            Console.WriteLine("\t\t\tСписок 1.");
            ConsolePerson.ShowPersonList(listOne);
            Console.WriteLine();
            Console.Write("Введите индекс персоны, которую необходимо" +
                " скопировать из первого списка во второй: ");
            int indexCopy = int.Parse(Console.ReadLine());
            Console.WriteLine();
            try
            {
                listTwo.AddPerson(listOne[indexCopy - 1]);
            }
            catch (ArgumentOutOfRangeException ar)
            {
                Console.WriteLine($"Ошибка: {ar.Message}");
            }

            Console.WriteLine("\t\t\tСписок 1.");
            ConsolePerson.ShowPersonList(listOne);
            Console.WriteLine("\t\t\tСписок 2.");
            ConsolePerson.ShowPersonList(listTwo);
            Console.WriteLine();
            Console.Write("Введите индекс персоны, которую необходимо" +
                " удалить из первого списка: ");
            int indexDelete = int.Parse(Console.ReadLine());
            Console.WriteLine();
            listOne.DeleteByIndex(ref arrayOne, indexDelete - 1);
            Console.WriteLine("\t\t\tСписок 1.");
            ConsolePerson.ShowPersonList(listOne);
            Console.WriteLine("\t\t\tСписок 2.");
            ConsolePerson.ShowPersonList(listTwo);
            Console.WriteLine();
            Console.Write("Следующее нажатие клавиши приведёт к отчистке второго списка.");
            listTwo.ClearList();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("\t\t\tСписок 1.");
            ConsolePerson.ShowPersonList(listOne);
            Console.WriteLine("\t\t\tСписок 2.");
            ConsolePerson.ShowPersonList(listTwo);
        }

    }

}