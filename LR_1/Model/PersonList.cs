﻿using System;
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
        private PersonBase[] _innerPersonArray = new PersonBase[0];

        /// <summary>
        /// Добавление человека в список
        /// </summary>
        /// <param name="person">Экземпляр класса Person.</param>
        public void AddPerson(PersonBase person)
        {
            var newArray = _innerPersonArray;

            _innerPersonArray = new PersonBase[newArray.Length + 1];

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
        public void AddPersonInArray(PersonBase[] persons)
        {
            foreach (PersonBase person in persons)
            {
                AddPerson(person);
            }
        }
        
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
        public void DeleteByIndex(int index)
        {
            var newArray = new PersonBase[_innerPersonArray.Length - 1];

            // TODO: Дублирование проверки на индекс (разные проверки)
            if (index >= 0 && index < _innerPersonArray.Length)
            {          
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
        public PersonBase this[int index]
        {
            get 
            {
                CheckIndex(index);
                return _innerPersonArray[index];
                
            }
            set
            {
                CheckIndex(index);
                _innerPersonArray[index] = value;
            }
        }

        /// <summary>
        /// Проверка на входимость индекса в массив.
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="IndexOutOfRangeException"></exception>
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
