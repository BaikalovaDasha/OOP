using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LR_1
{
    /// <summary>
    /// Класс для добавления персоны через консоль и вывода в консоль.
    /// </summary>
    public static class ConsolePerson
    {

        /// <summary>
        /// Checking the words entered by the user.
        /// </summary>
        /// <param name="value">entered name/surname.</param>
        /// <returns>return name/surname.</returns>
        /// <exception cref="ArgumentException">error output.</exception>
        public static string CheckString(string value)
        {
            Regex words = new(@"^[A-z,А-ЯЁ,а-яё,-]+$");

            if (!words.IsMatch(value))
            {
                throw new ArgumentException("It is allowed to enter only " +
                    "letters and dashes");
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Добавление персоны через консоль.
        /// </summary>
        /// <returns>Новая персона.</returns>
        public static Person AddPersonConsole()
        {
            var newPerson = new Person();

            Action actionName = new Action(() =>
            {
                Console.Write($"Name: ");
                newPerson.Name = CheckString(Console.ReadLine());

            });
            ActionHandler(actionName, "Name");

            Action actionSurname = new Action(() =>
            {
                Console.Write($"Surname: ");
                newPerson.Surname = CheckString(Console.ReadLine());

            });
            ActionHandler(actionSurname, "Surname");

            Action actionAge = new Action(() =>
            {
                Console.Write($"Age: ");
                _ = int.TryParse(Console.ReadLine(), out int tmpAge);
                newPerson.Age = tmpAge;
            });
            ActionHandler(actionAge, "Age");

            Action actionGender = new Action(() =>
            {
                Console.Write($"Enter person gender (1 - Male or 2 - Female): ");
                _ = int.TryParse(Console.ReadLine(), out int tmpGender);
                if (tmpGender < 1 || tmpGender > 2)
                {
                    throw new ArgumentOutOfRangeException();
                }

                var realGender = tmpGender == 1
                    ? Gender.Male
                    : Gender.Female;

                newPerson.Gender = realGender;
            });
            ActionHandler(actionGender, "Gender");

            return newPerson;

        }

        private static void ActionHandler(Action action, string propertyName)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    break;
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"Incorrect {propertyName}. Error: {exception.Message}. " +
                        $"Please, enter the {propertyName} again.");
                }
            }
        }

        /// <summary>
        /// Вывод списка персон.
        /// </summary>
        /// <param name="personsList">Список персон.</param>
        public static void ShowPersonList(PersonList personsList)
        {

            for (int i = 0; i < personsList.CountOfPerson; i++)
            {
                Console.WriteLine(personsList[i].GetInfo());
            }
        }
    }
}
