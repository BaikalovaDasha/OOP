using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс ребёнка.
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Мама.
        /// </summary>
        public Adult Mother { get; set; }

        /// <summary>
        /// папа
        /// </summary>
        public Adult Father { get; set; }

        /// <summary>
        /// Информация о детском саду или школе.
        /// </summary>
        public string JobChild { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Child(string name, string surname, int age, Gender gender)
            : base(name, surname, age, gender)
        {

        }

        /// <summary>
        /// Метод проверки возраста ребёнка.
        /// </summary>
        /// <param name="age">Возраст ребёнка.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        protected override int CheckingAge(int age)
        {
            const int minAge = 1;
            const int maxAge = 17;
            if (age < minAge || age > maxAge)
            {
                throw new Exception($"Возраст ребёнка должен находится в диапазоне" +
                    $" от {minAge} до {maxAge}");
            }
            else
            {
                return age;
            }
        }

        /// <summary>
        /// Метод возвращает информацию о ребёнке в виде строки.
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return base.GetInfo() + "вам ещё до смерти далеко, живите!";
        }
    }
}
