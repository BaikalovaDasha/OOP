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
                " и взрослых.\nДля вывода информации о персоне нажмите любую клавишу.");
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

            Console.WriteLine($"Вывод информации о четвёртом человеке из списка.\n" +
                $"Это {personlist[3].GetInfoPerson}.");

            switch (personlist[3])
            {
                case Adult:
                {
                    Console.WriteLine(Adult.WatchingMovie());
                    break;
                }

                case Child:
                {
                    Console.WriteLine(Child.WatchingCartoons());
                    break;
                }

            }

            Console.ReadKey();
        }
    }
}