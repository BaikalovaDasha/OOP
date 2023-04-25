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
            Console.WriteLine("Создание списка из 7 человек, состоящего из детей" +
                " и взрослых.\n Для вывода информации о персоны нажмите любую клавишу.");
            Console.WriteLine();
            Console.ReadKey();
            var personlist = new PersonList();
            var randomList = new Random();

            for (var i = 0; i < 7; i++)
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
                Console.ReadKey();
            }

            Console.WriteLine("Вывод информации о 4 человека в списке");
            Console.WriteLine();
            Console.WriteLine(personlist[3].GetInfo);

        }
    }
}