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
            var randomList = new Random();

            for (var i = 0; i < 8; i++)
            {
                PersonBase rndPerson = randomList.Next(2) == 0
                    ? RandomPersonGenerator.CreateRandomAdult()
                    : RandomPersonGenerator.CreateRandomChild();
                personlist.AddPerson(rndPerson);
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