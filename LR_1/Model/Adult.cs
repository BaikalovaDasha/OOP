using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        /// Чтение и запись паспортных данных.
        /// </summary>
        public int SeriesAndNumber { get; set; }

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

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Adult(string name, string surname, int age, Gender gender)
            : base(name, surname, age, gender)
        {

        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Adult()
        { }

        /// <summary>
        /// Метод проверки возраста взрослого.
        /// </summary>
        /// <param name="age">Возраст взрослого.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        protected override int CheckingAge(int age)
        {
            const int minAge = 18;
            const int maxAge = 110;
            if (age < minAge || age > maxAge)
            {
                throw new Exception($"Возраст взрослого должен находится в диапазоне" +
                    $" от {minAge} до {maxAge}");
            }
            else
            {
                return age;
            }
        }

        /// <summary>
        /// Метод возвращает информацию об взрослом в виде строки.
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return base.GetInfo() + "Вы очень близки к смерти!";
        }
    }
}
