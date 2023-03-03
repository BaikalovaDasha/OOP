using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1
{
    /// <summary>
    /// Класс для добавления персоны через консоль и вывода в консоль.
    /// </summary>
    public static class ConsolePerson
    {
        /// <summary>
        /// Добавление персоны через консоль.
        /// </summary>
        /// <returns>Новая персона.</returns>
        public static Person AddPersonConsole()
        {

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите Фамилию: ");
            string surename = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите пол персоны: ");
            Gender gender;

            while (true)
            {
                string gender1 = Console.ReadLine();
                if (gender1 == "ж")
                {
                    gender = Gender.Female;
                    break;
                }
                else if (gender1 == "м")
                {
                    gender = Gender.Male;
                    break;
                }
                else
                {
                    Console.WriteLine("Введёт некорректный пол," +
                        " введите 'м' или 'ж'!");
                }
            }

            Person newPerson = new(name, surename, age, gender);
            return newPerson;

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
