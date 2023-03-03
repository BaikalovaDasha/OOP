using System;
using System.Net.WebSockets;

namespace Model
{
    /// <summary>
    /// Класс персоны.
    /// </summary>
    public class Person
    {

        /// <summary>
        /// Gets or sets Имя.
        /// </summary>
        public string _name { get; set; }

        /// <summary>
        /// Gets or sets Фамилия.
        /// </summary>
        public string _surname { get; set; }

        /// <summary>
        /// Возраст персоны.
        /// </summary>
        private int _age;

        /// <summary>
        /// Чтение и запись возраста персоны.
        /// </summary>
        public int Age 
        { 
            get { return _age; }
            
            set
            {
                CheckingAge(value);
                _age = value;
            }
        }

        /// <summary>
        /// Gets or sets Пол.
        /// </summary>
        private Gender _gender;


        /// <summary>
        /// Метод возвращает информацию о человеке в виде строки.
        /// </summary>
        /// <returns>Информацию о человеке в виде строки.</returns>
        public string GetInfo()
        {
            return $"Имя: {_name}, Фамилия: {_surname}, Возраст: {Age}, Пол: {_gender}.";
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Person(string name, string surname, int age, Gender gender)
        {
            _name = name;
            _surname = surname;
            Age = age;
            _gender = gender;
        }

        public const int maxAge = 110;
        public const int minAge = 1;

        /// <summary>
        /// Проверка для ввода возраста
        /// </summary>
        /// <param name="age">Возраст для проверки</param>
        /// <returns>Корректный возраст</returns>
        public static int CheckingAge(int age)
        {
            if (age < minAge || age > maxAge)
            {
                throw new Exception("Возраст должен быть в диапазоне" +
                    " от 1 до 110");
            }
            else
            {
                return age;
            }
        }
    }
}