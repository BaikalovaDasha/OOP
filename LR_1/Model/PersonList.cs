using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            _innerPersonArray = new Person[newArray.Length + 1];

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
        
        //TODO: rename + 
        /// <summary>
        /// Количество персон.
        /// </summary>
        public int Count
        { 
            get
            {
                return _innerPersonArray.Length;
            }
        }

        /// <summary>
        /// Удаление персоны по индексу.
        /// </summary>
        /// <param name="person"></param>
        public void DeleteByIndex(ref Person[] person, int index)
        {
            var newArray = new Person[_innerPersonArray.Length - 1];

            if (index >= 0 && index < _innerPersonArray.Length)
            {
                // TODO: fix +               
                for (int i = 0; i < index; i++)
                {
                    newArray[i] = _innerPersonArray[i];
                }

                for (int i = index + 1; i < _innerPersonArray.Length; i++)
                {
                    newArray[i - 1] = _innerPersonArray[i];
                }

                _innerPersonArray = newArray;

                
            }
            else
            {
                CheckIndex(index);
            }
        }

        /// <summary>
        /// Очистить список 
        /// </summary>
        public void ClearList()
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
                //TODO: duplication + 
                CheckIndex(index);
                return _innerPersonArray[index];
                
            }
            set
            {
                //TODO: add exception generation + 
                CheckIndex(index);
                _innerPersonArray[index] = value;
            }
        }

        public void CheckIndex(int index)
        {
            if (index < 0 || index >= _innerPersonArray.Length)
            {
                throw new IndexOutOfRangeException("Вы ввели индекс" +
                    " персоны, которого нет в списке");
            }
        }

    }
}
