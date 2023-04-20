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
            PersonList personlist = new PersonList();

            for (int i = 0; i < 7; i++)
            {
                personlist.AddPerson(RandomPersonGenerator.CreateRandomAdult());
            }

        }
    }
}