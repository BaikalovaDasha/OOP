using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Model
{
    /// <summary>
    /// Класс взрослого.
    /// </summary>
    public class Adult : PersonBase
    {

        /// <summary>
        /// Максимальное количество символов паспорта.
        /// </summary>
        private const int maxSymbol = 10;

        /// <summary>
        /// Поле паспортных данных
        /// </summary>
        private string _passport;

        /// <summary>
        /// Чтение и запись паспортных данных.
        /// </summary>
        public string Pasport
        { 
            get => _passport; 
            set
            {
                // TODO: Длинные строки
                const string pattern = @"\D";
                Regex regex = new(pattern);
                if (value.Length != maxSymbol || regex.IsMatch(value.ToString()))
                {
                    throw new ArgumentException("Паспорт должен содержать 10 символов!");
                }
                _passport = value;
            }
        }

        /// <summary>
        /// Чтение и запись состояние брака.
        /// </summary>
        public StateOfMarriage StateOfMarriage { get; set; }

        /// <summary>
        /// Чтение и запись супруги / супруга.
        /// </summary>
        public Adult Spouse { get; set; }

        /// <summary>
        /// Место работы персоны.
        /// </summary>
        public string Job { get; set; }

        // TODO: Это должен быть метод
        /// <summary>
        /// Вывод информации о взрослом человеке.
        /// </summary>
        public override string GetInfo
        {
            get
            {
                // TODO: Ненужно вызывать базовый метод
                var personInfo = base.GetInfo + 
                    $"\nПаспорт: {Pasport}";
                personInfo += $"\nМесто работы: {Job}";
                if (StateOfMarriage == StateOfMarriage.Married)
                {
                    personInfo += Gender == Gender.Male
                        ? $"\nСостояние брака: Женат"
                        : $"\nСостояние брака: Замужем";
                }
                else
                {
                    personInfo += Gender == Gender.Male
                        ? $"\nСостояние брака: Не женат"
                        : $"\nСостояние брака: Не замужем";
                }

                if (StateOfMarriage == StateOfMarriage.Married)
                {
                    personInfo += Gender == Gender.Female
                        ? $"\nСупруг: {Spouse.Name} {Spouse.Surname}"
                        : $"\nСупруга: {Spouse.Name} {Spouse.Surname}";
                }
                return personInfo;
            }
        }

        /// <summary>
        /// Минимальный возраст взрослого человека.
        /// </summary>
        public const int minAge = 18;

        /// <summary>
        /// Максимальный возраст взрослого человека.
        /// </summary>
        public const int maxAge = 110;

        // TODO: Заполнить, длинная строка
        /// <summary>
        /// Метод проверки возраста взрослого.
        /// </summary>
        /// <param name="age">Возраст взрослого.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        protected override int CheckingAge(int age)
        {
            if (age < minAge || age > maxAge)
            {
                throw new Exception($"Возраст взрослого должен находится в диапазоне" +
                    $" от {minAge} до {maxAge}");
            }
            return age; 
        }

        /// <summary>
        /// Метод указывает какой мультик смотрит ребёнок.
        /// </summary>
        /// <returns>Просматриваемый мультик.</returns>
        public static string WatchingMovie()
        {
            var rnd = new Random();

            string[] movie =
            {
                "1+1", "Назад в будущее", "Джентльмены", "Престиж",
                "Матрица", "Зелёная книга", "Пираты Карибского моря",
                "Молчание ягнят", "Тревожный вызов", "Невидимая сторона",
                "Малышка на миллион", "Шерлок Холмс"
            };

            var selectMovie = movie[rnd.Next(movie.Length)];

            return $"Любимый фильм: {selectMovie}";
        }
    }
}
