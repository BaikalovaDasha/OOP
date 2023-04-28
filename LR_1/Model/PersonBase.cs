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
        /// Фамилия персоны.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст персоны.
        /// </summary>
        private int _age;

        // TODO: Заполнить + 
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name">имя персоны.</param>
        /// <param name="surname">фамилия персоны.</param>
        /// <param name="age">возраст персоны.</param>
        /// <param name="gender">пол персоны.</param>
        protected PersonBase(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        protected PersonBase()
        {
        }


        /// <summary>
        /// Чтение и запись имени персоны.
        /// </summary>
        public string Name
        {
            get => _name;
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

        // TODO: Переделать свойство в абстрактный метод
        /// <summary>
        /// Метод возвращает информацию о человеке в виде строки.
        /// </summary>
        /// <returns>информация о персоне.</returns>
        public virtual string GetInfo 
        {
            get
            {
                var personBase = $"{Name} {Surname}, Возраст: {Age},";
                if (Gender == Gender.Male)
                {
                    personBase += $"Пол: Мужской";
                }
                else
                {
                    personBase += $"Пол: Женский";
                }
                
                return personBase;
            }
        }

        // TODO: Переделать свойство в абстрактный метод
        /// <summary>
        /// Метод возвращает информацию о человеке в виде строки.
        /// </summary>
        /// <returns>информация о персоне.</returns>
        public virtual string GetInfoPerson
        {
            get
            {
                var personBase = $"{Name} {Surname}";
                return personBase;
            }
        }

        // TODO: Заполнить
        /// <summary>
        /// Проверка на один язык имени и фамилии и правильное...
        /// ... выполнение регистра.
        /// </summary>
        /// <param name="value">имя/фамилия.</param>
        /// <param name="varForComparison">фамилия/имя.</param>
        /// <returns>проверенное имя.</returns>
        private static string AllCheck(string value, string varForComparison)
        {
            CheckLanguage(value, varForComparison);
            ChekingNullorEmpty(value);
            return ToUpperFirstLetter(value);
        }

        // TODO: Заполнить
        /// <summary>
        /// Проверка на null и empty. 
        /// </summary>
        /// <param name="value">параметр персоны.</param>
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

        // TODO: Дублирование проверки на пустую строку
        // TODO: Метод должен формировать исключение, если язык не русский и не английский
        // TODO: GetLanguage
        /// <summary>
        /// Проверка на русские и английские символы.
        /// </summary>
        /// <param name="value">введнные символы.</param>
        /// <returns>введённые символы.</returns>
        private static Language GetLanguage(string value)
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

        // TODO: Дублирование проверки на пустую строку
        /// <summary>
        /// Проверка одинакового языка имени и фамилии..
        /// </summary>
        /// <param name="name">имя персоны.</param>
        /// <param name="surname">фамилия персоны.</param>
        private static void CheckLanguage(string name, string surname)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname))
            {
                Language nameLanguage = GetLanguage(name);
                Language surnameLanguage = GetLanguage(surname);

                if (nameLanguage != surnameLanguage)
                {
                    throw new ArgumentException("Имя и фамилия " +
                        "должны быть на одинаковом языке");
                }
            }
        }

        // TODO: Заполнить
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
        protected abstract int CheckingAge(int age);

    }
}