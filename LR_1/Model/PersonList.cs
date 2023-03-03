using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс с функциями.
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Массив из списка людей.
        /// </summary>
        private Person[] _innerPersonArray = new Person[0];

        /// <summary>
        /// Добавление человека в список
        /// </summary>
        /// <param name="person">Экземпляр класса Person.</param>
        public void AddPerson(Person person)
        {
            var newArray = _innerPersonArray;

            _innerPersonArray = new Person[newArray.Length + 1 ];

            for (int i = 0; i < newArray.Length; i++)
            {
                _innerPersonArray[i] = newArray[i];
            }

            _innerPersonArray[newArray.Length] = person;
        }

        /// <summary>
        /// Добавление списка людей в массив.
        /// </summary>
        /// <param name="persons">массив людей.</param>
        public void AddPersonInArray(Person[] persons)
        {
            foreach (Person person in persons)
            {
                AddPerson(person);
            }
        }
        
        public int CountOfPerson
        { 
            get
            {
                return _innerPersonArray.Length;
            }
        }

        /// <summary>
        /// Очистить список 
        /// </summary>
        public void DeleteAllPeople()
        {
            Array.Resize(ref _innerPersonArray, 0);
        }

        /// <summary>
        /// Индексатор.
        /// </summary>
        /// <param name="index">Индекс персоны.</param>
        /// <returns>Индекс персоны.</returns>
        public Person this[int index]
        {
            get 
            { 
                if (index >= 0 && index < _innerPersonArray.Length)
                {
                    return _innerPersonArray[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < _innerPersonArray.Length)
                {
                    _innerPersonArray[index] = value;
                }
            }
        }

    }
}
