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
            var listPerson = new PersonList();

            for (int i = 0; i < 7; i++)
            {
                listPerson.AddPerson(RandomPersonGenerator.);
            }

            foreach (var personTmp in listPerson)
            {
                switch (personTmp)
                {
                    case Child child:
                        break;
                    case Adult adult:
                        break;

                }

                Console.WriteLine($"Текущая персона: {personTmp.GetInfo()}");
            }
        }
    }
}