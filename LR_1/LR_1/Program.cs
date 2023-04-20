using Model;
using System;

namespace LR_2
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
            var personlist = new PersonList();

            for (int i = 0; i < 7; i++)
            {
                personlist.AddPerson(RandomPersonGenerator.CreateRandomChild());
            }

            for (int i = 0; i < personlist.Count; i++)
            {
                Console.WriteLine($"\tПерсона №{i + 1}");
                Console.WriteLine(personlist[i].GetInfo);
                Console.WriteLine();
            }

        }
    }
}