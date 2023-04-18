using System;
using System.Net.WebSockets;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Model
{
    /// <summary>
    /// Класс персоны.
    /// </summary>
    public abstract class PersonBase
    {

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
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public PersonBase(string name, string surname, int age, Gender gender)
        {
            _name = name;
            _surname = surname;
            _age = age;
            Gender = gender;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public PersonBase()
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
                _name = ToUpperFirstLetter
                    (ChekingNullorEmpty(value, nameof(Name)));
                if (_surname != null)
                {
                    CheckLanguage(_name, _surname);
                }
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
                _surname = ToUpperFirstLetter
                    (ChekingNullorEmpty(value, nameof(Surname)));
                if (_name != null)
                {
                    CheckLanguage(_name, _surname);
                }
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
        public virtual string GetInfo 
        {
            get
            {
                return $"Имя: {_name}, Фамилия: {_surname}, Возраст: {Age}, Пол: {Gender}.";
            }
        }

        /// <summary>
        /// Проверка на null и empty. 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="propertiname"></param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException"></exception>
        private static string ChekingNullorEmpty(string value, string propertiname)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new System.ArgumentNullException($"Введённый параметр" +
                    $"({propertiname}) не может быть пустым.");
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

        /// <summary>
        /// Проверка на ввод имени или фамилии на одном языке.
        /// </summary>
        /// <param name="nameOrSurname">имя или фамилия персоны.</param>
        /// <returns>проверенный параметр персоны.</returns>
        /// <exception cref="FormatException">вапоа.</exception>
        public static string CheckNameSurname(string nameOrSurname)
        {
            Regex nameLanguage = new("(^[А-я]+(-[А-я])?[А-я]*$)" +
                "|(^[A-z]+(-[A-z])?[A-z]*$)");

            if (!nameLanguage.IsMatch(nameOrSurname))
            {
                throw new FormatException("Введёное слово не распознано." +
                    " Введите еще раз!");
            }

            return nameOrSurname;
        }

        /// <summary>
        /// Проверка одинакового языка имени и фамилии..
        /// </summary>
        /// <param name="name">имя персоны.</param>
        /// <param name="surname">фамилия персоны.</param>
        private static void CheckLanguage(string name, string surname)
        {
            Language nameLanguage = IsCorrectSymbol(name);
            Language surnameLanguage = IsCorrectSymbol(surname);

            if (nameLanguage != surnameLanguage)
            {
                throw new ArgumentException("Язык имени и фамилии " +
                    "должны быть одинаковыми");
            }

        }

        /// <summary>
        /// Преобразует первую букву имени/фамилии в заглавную, ...
        /// ... остальные прописные.
        /// </summary>
        /// <param name="newWord"></param>
        /// <returns>фамилию с правильным регистром.</returns>
        public static string ToUpperFirstLetter(string newWord)
        {
            newWord = char.ToUpper(newWord[0]) + newWord[1..].ToLower();

            Regex upperReg = new(@"[-]");

            if (upperReg.IsMatch(newWord))
            {
                string[] words = newWord.Split(new char[] { '-' });

                string newWords1 = words[0];
                string newWords2 = words[1];

                newWords1 = char.ToUpper(newWords1[0]) + newWords1[1..].ToLower();
                newWords2 = char.ToUpper(newWords2[0]) + newWords1[1..].ToLower();

                newWord = newWords1 + ("-") + newWords2;
            }
            
            return newWord;
        }

        /// <summary>
        /// Проверка для ввода возраста
        /// </summary>
        /// <param name="age">Возраст для проверки</param>
        /// <returns>Корректный возраст</returns>
        protected abstract int CheckingAge(int age);

    }
}