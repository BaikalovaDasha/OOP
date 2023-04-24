using System;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Model
{
    /// <summary>
    /// Класс персоны.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Минимальный возраст.
        /// </summary>
        private const int minAge = 1;

        /// <summary>
        /// Максимальный возраст
        /// </summary>
        private const int maxAge = 110;

        /// <summary>
        /// Имя персоны.
        /// </summary>
        private string _name;

        /// <summary>
        /// фамилия персоны.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст персоны.
        /// </summary>
        private int _age;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name">имя персоны.</param>
        /// <param name="surname">Фамилия персоны.</param>
        /// <param name="age">Возраст персоны.</param>
        /// <param name="gender">Гендер персоны.</param>
        public Person(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Person()
        {
        }

        /// <summary>
        /// Чтение и запись имени персоны.
        /// </summary>
        public string Name
        {
            get 
            { 
                return _name; 
            }
            set 
            {
                _name = AllCheck(value, _surname);
            }
        }

        /// <summary>
        /// Чтение и запись фамилии персоны.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = AllCheck(value, _name);
            }
        }

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
        /// Пол персоны.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Метод возвращает информацию о человеке в виде строки.
        /// </summary>
        /// <returns>информация о персоне.</returns>
        public string GetInfo()
        {
            return $"Имя: {Name}, Фамилия: {Surname}, Возраст: {Age}, Пол: {Gender}.";
        }

        /// <summary>
        /// Проверка на один язык имени и фамилии и праивльное...
        /// ... выполнение регистра.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="varForComparison"></param>
        /// <returns></returns>
        private static string AllCheck(string value, string varForComparison)
        {
            CheckLanguage(value, varForComparison);
            ChekingNullorEmpty(value);
            return ToUpperFirstLetter(value);
        }

        /// <summary>
        /// Проверка на null и empty. 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="propertiname"></param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException"></exception>
        private static string ChekingNullorEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception($"Введённый параметр" +
                    $" не может быть пустым.");
            }
            return value;
        }

        /// <summary>
        /// Проверка на русские и английские символы.
        /// </summary>
        /// <param name="value">введнные символы.</param>
        /// <returns>введённые символы.</returns>
        private static Language IsCorrectSymbol(string value)
        {
            var symbolsRussian = new Regex("[А-ЯЁ, а-яё]");
            var symbolsEnglish = new Regex("[A-z]");

            if (string.IsNullOrEmpty(value) == false)
            {
                if (symbolsRussian.IsMatch(value))
                {
                    return Language.Russian;
                }
                else if (symbolsEnglish.IsMatch(value))
                {
                    return Language.English;
                }
                else
                {
                    throw new ArgumentException("Введённый параметр персоны должен" +
                    " содержать только символы русской или английской раскладки." +
                    " Пожалуйста исправьте введённый параметр.");
                }
            }
            return Language.Default;

        }

        /// <summary>
        /// Проверка одинакового языка имени и фамилии..
        /// </summary>
        /// <param name="name">имя персоны.</param>
        /// <param name="surname">фамилия персоны.</param>
        private static void CheckLanguage(string name, string surname)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname))
            {
                Language nameLanguage = IsCorrectSymbol(name);
                Language surnameLanguage = IsCorrectSymbol(surname);

                if (nameLanguage != surnameLanguage)
                {
                    throw new ArgumentException("Имя и фамилия " +
                        "должны быть на одинаковом языке");
                }
            }
            

        }

        /// <summary>
        /// Преобразует первую букву имени/фамилии в заглавную, ...
        /// ... остальные прописные.
        /// </summary>
        /// <param name="newWord"></param>
        /// <returns>фамилию / имя с правильным регистром.</returns>
        public static string ToUpperFirstLetter(string newWord)
        {
            newWord = char.ToUpper(newWord[0]) + newWord[1..].ToLower();

            Regex upperReg = new(@"[-]");

            if (upperReg.IsMatch(newWord))
            {
                string[] words = newWord.Split(new char[] {'-'});

                string newWords1 = words[0];
                string newWords2 = words[1];

                newWords1 = char.ToUpper(newWords1[0]) + newWords1[1..].ToLower();
                newWords2 = char.ToUpper(newWords2[0]) + newWords2[1..].ToLower();

                newWord = newWords1 + ("-") + newWords2;
            }
            return newWord;
        }

        /// <summary>
        /// Проверка для ввода возраста
        /// </summary>
        /// <param name="age">Возраст для проверки</param>
        /// <returns>Корректный возраст</returns>
        private static int CheckingAge(int age)
        {
            if (age < minAge || age > maxAge)
            {
                throw new Exception($"Возраст должен находится в диапазоне" +
                    $" от {minAge} до {maxAge}");
            }
            else
            {
                return age;
            }
        }

    }
}