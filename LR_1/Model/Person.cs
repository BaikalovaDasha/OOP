using System;
using System.Net.WebSockets;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Класс персоны.
    /// </summary>
    public class Person
    {

        /// <summary>
        /// Name of person.
        /// </summary>
        private string _name;

        /// <summary>
        /// Reading and writing the name.
        /// </summary>
        public string Name
        {
            get 
            { 
                return _name; 
            }
            set 
            {
                _name = ChekingNullorEmpty(value, nameof(Name));
                //if (_name != null)
                //{
                //    CheckLanguage(_name, _surname);
                //}
            }
        }

        /// <summary>
        /// Surname of person.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Reading and writing the surname.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = ChekingNullorEmpty(value, nameof(Surname));
                //if (_surname != null)
                //{
                //    CheckLanguage(_name, _surname);
                //}
            }
        }

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
        /// Gender of person.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Метод возвращает информацию о человеке в виде строки.
        /// </summary>
        /// <returns>Информацию о человеке в виде строки.</returns>
        public string GetInfo()
        {
            return $"Имя: {_name}, Фамилия: {_surname}, Возраст: {Age}, Пол: {Gender}.";
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
            _age = age;
            Gender = gender;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Person()
        {
        }

        /// <summary>
        /// Cheking null or empty string. 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="propertiname"></param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException"></exception>
        private static string ChekingNullorEmpty(string value, string propertiname)
        {
            if (value == null)
            {
                throw new System.ArgumentNullException($"{propertiname} " +
                    $"is not be null!");
            }

            if (value == String.Empty)
            {
                throw new System.ArgumentException($"{propertiname} " +
                    $"is not be empty!");
            }

            return value;
        }

        //"[А-ЯЁа-яё]+(((-| )?([А-ЯЁа-яё])+))?$"

        ///// <summary>
        ///// Cheking Russian and English symbols.
        ///// </summary>
        ///// <param name="value"></param>
        ///// <returns></returns>
        //private static Language IsNameAndSurnameCorrectSymbol(string value)
        //{
        //    var symbolsRussian = new Regex("[А-я]");
        //    var symbolsEnglish = new Regex("[A-z]");


        //    if (symbolsRussian.IsMatch(value))
        //    {
        //        return Language.Russian;
        //    }
        //    else if (symbolsEnglish.IsMatch(value))
        //    {
        //        return Language.English;
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Please correct the language. " +
        //            "Only Russian or English characters are allowed" +
        //            " to be entered.");
        //    }

        //}

        ///// <summary>
        ///// checking for the same language of the name and surname.
        ///// </summary>
        ///// <param name="name"></param>
        ///// <param name="surname"></param>
        //private static void CheckLanguage(string name, string surname)
        //{
        //    Language nameLanguage = IsNameAndSurnameCorrectSymbol(name);
        //    Language surnameLanguage = IsNameAndSurnameCorrectSymbol(surname);

        //    if (nameLanguage != surnameLanguage)
        //    {
        //        throw new ArgumentException("The language of the name and " +
        //            "surname must match.");
        //    }

        //}

        public const int maxAge = 110;
        public const int minAge = 1;

        /// <summary>
        /// Проверка для ввода возраста
        /// </summary>
        /// <param name="age">Возраст для проверки</param>
        /// <returns>Корректный возраст</returns>
        private static int CheckingAge(int age)
        {
            if (age < minAge || age > maxAge)
            {
                throw new Exception($"The age should be in range" +
                    $" of {minAge} to {maxAge}");
            }
            else
            {
                return age;
            }
        }

    }
}