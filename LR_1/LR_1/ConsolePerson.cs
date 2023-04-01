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
        /// Проверка введённых слова пользователем.
        /// </summary>
        /// <param name="value">введённое имя/фамилия.</param>
        /// <returns>return имя/фамлию.</returns>
        /// <exception cref="ArgumentException">error output.</exception>
        public static string CheckString(string value)
        {
            Regex words = new(@"^[A-z,А-ЯЁ,а-яё,-]+$");

            if (!words.IsMatch(value))
            {
                throw new ArgumentException("разрешено вводить только" +
                    " буквы и дефис");
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

            Action actionName = new(() =>
            {
                Console.Write($"Введите имя: ");
                string name = CheckString(Console.ReadLine());
                newPerson.Name = Person.CheckNameSurname(name);
            });
            ActionHandler(actionName, "имя");

            Action actionSurname = new(() =>
            {
                Console.Write($"Введите фамилию: ");
                string surname = CheckString(Console.ReadLine());
                newPerson.Surname = Person.CheckNameSurname(surname);
            });
            ActionHandler(actionSurname, "фамилия");

            Action actionAge = new(() =>
            {
                Console.Write($"Введите возраст: ");
                _ = int.TryParse(Console.ReadLine(), out int tmpAge);
                newPerson.Age = tmpAge;
            });
            ActionHandler(actionAge, "возраст");

            Action actionGender = new(() =>
            {
                Console.Write($"Введите пол человека (1 - Мужской или 2 - Женский): ");
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
            ActionHandler(actionGender, "пол");

            return newPerson;

        }

        /// <summary>
        /// Ввод параметра персоны в список введённого пользователем.
        /// </summary>
        /// <param name="action">Action.</param>
        /// <param name="propertyName">параметр персоны.</param>
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
                    Console.WriteLine($"Введённый параметр персоны ({propertyName})" +
                        $" некорректен ({exception.Message}).\n" +
                        $"Введите {propertyName} ещё раз.");
                }
            }
        }

        /// <summary>
        /// Вывод списка персон.
        /// </summary>
        /// <param name="personsList">Список персон.</param>
        public static void ShowPersonList(PersonList personsList)
        {

            for (int i = 0; i < personsList.Count; i++)
            {
                Console.WriteLine(personsList[i].GetInfo());
            }
        }
    }
}
