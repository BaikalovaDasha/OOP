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
            var personList = new List<PersonBase>
            {
                GetPerson(0),
                GetPerson(1),
                GetPerson(0),
                GetPerson(1),
                GetPerson(0),
                GetPerson(1),
                GetPerson(0),
                GetPerson(1),
                GetPerson(0),
            };

            foreach (var personTmp in personList)
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

            var inputValue = Console.ReadLine();
            int.TryParse(inputValue, out int personType);

            PersonBase person = GetPerson(personType);

            Console.WriteLine(person);
        }

        /// <summary>
        /// jdhdhd.
        /// </summary>
        /// <param name="person">sdf.</param>
        /// <returns>sdfg/.</returns>
        public static PersonBase GetPerson(int person)
        {
            return person switch
            {
                0 => new Child("Anastasia", "Kuznetsova", 17, Gender.Female),
                _ => new Adult("Ivan", "Ivanov", 18, Gender.Male),
            };
        }
    }
}