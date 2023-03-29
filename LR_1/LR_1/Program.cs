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
            Console.WriteLine("Для отображения списков нажмите любую клавишу.\n");
            Console.ReadKey();

            var listOne = new PersonList();
            var arrayOne = new Person[]
            {
                RandomPersonGenerator.GetRandomPerson(),
                RandomPersonGenerator.GetRandomPerson(),
                RandomPersonGenerator.GetRandomPerson(),
            };

            var listTwo = new PersonList();
            var arrayTwo = new Person[]
            {
                RandomPersonGenerator.GetRandomPerson(),
                RandomPersonGenerator.GetRandomPerson(),
                RandomPersonGenerator.GetRandomPerson(),
            };

            listOne.AddPersonInArray(arrayOne);
            listTwo.AddPersonInArray(arrayTwo);

            Console.WriteLine("\t\t\tСписок 1.\n");
            ConsolePerson.ShowPersonList(listOne);
            Console.WriteLine();

            Console.WriteLine("\t\t\tСписок 2.\n");
            ConsolePerson.ShowPersonList(listTwo);
            Console.WriteLine();

            Console.WriteLine("Добавим персону в 1-ый список. " +
                "Для продолжениянажмите любую клавишу.");
            Console.ReadKey();
            Console.WriteLine();
            listOne.AddPerson(ConsolePerson.AddPersonConsole());

            Console.WriteLine("\n\t\t\tСписок 1.\n");
            ConsolePerson.ShowPersonList(listOne);
            Console.WriteLine();

            int index;

            Action copyPerson = new(() =>
            {
                index = int.Parse(Console.ReadLine());
                listTwo.AddPerson(listOne[index - 1]);
            });
            ActionHandler(copyPerson, "скопировать");

            Console.WriteLine("\n\t\t\tСписок 1.\n");
            ConsolePerson.ShowPersonList(listOne);
            Console.WriteLine("\n\t\t\tСписок 2.\n");
            ConsolePerson.ShowPersonList(listTwo);
            Console.WriteLine();

            Action deletePerson = new(() =>
            {
                index = int.Parse(Console.ReadLine());
                listOne.DeleteByIndex(ref arrayOne, index - 1);
            });
            ActionHandler(deletePerson, "удалить");

            Console.WriteLine("\n\t\t\tСписок 1.\n");
            ConsolePerson.ShowPersonList(listOne);
            Console.WriteLine("\n\t\t\tСписок 2.\n");
            ConsolePerson.ShowPersonList(listTwo);
            Console.WriteLine();

            Console.Write("Следующее нажатие клавиши приведёт к отчистке второго списка.\n");
            listTwo.ClearList();

            Console.ReadKey();
            Console.WriteLine("\n\t\t\tСписок 1.\n");
            ConsolePerson.ShowPersonList(listOne);

            Console.WriteLine("\n\t\t\tСписок 2.\n");
            ConsolePerson.ShowPersonList(listTwo);
            Console.ReadKey();
        }

        /// <summary>
        /// Выполнение копирования и удаления персоны из списка.
        /// </summary>
        /// <param name="action">Action.</param>
        /// /// <param name="copeOrDelete">Action.</param>
        public static void ActionHandler(Action action, string copeOrDelete)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Введите индекс персоны," +
                        $" которую необходимо {copeOrDelete} из первого списка: ");
                    action.Invoke();
                    break;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}