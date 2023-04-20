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
        public Adult Father { get; set; }

        /// <summary>
        /// папа
        /// </summary>
        public Adult Mother { get; set; }

        /// <summary>
        /// Информация о детском саду или школе.
        /// </summary>
        public string JobChild { get; set; }

        /// <summary>
        /// Минимальный возраст ребёнка.
        /// </summary>
        public const int minAge = 1;

        /// <summary>
        /// Максимальный возраст ребёнка.
        /// </summary>
        public const int maxAge = 17;

        /// <summary>
        /// Метод проверки возраста ребёнка.
        /// </summary>
        /// <param name="age">Возраст ребёнка.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        protected override int CheckingAge(int age)
        {

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
        /// 
        /// </summary>
        /// <param name="parent">Родитель.</param>
        /// <param name="gender">Пол родителя.</param>
        /// <returns></returns>
        private static void CheckParents(Adult parent, Gender gender = Gender.Default)
        {
            if (gender == Gender.Female)
            {

            }
        }

        /// <summary>
        /// Вывод информации о ребёнке.
        /// </summary>
        public override string GetInfo
        {
            get
            {
                var personInfo = base.GetInfo;

                if (Father != null && Mother != null)
                {
                    personInfo += $"\nРодители: {Father.Name} {Father.Surname}" +
                        $" и {Mother.Name} {Mother.Surname}";
                }
                else
                {
                    personInfo += $"\nРебёнок сирота.";
                }

                if (JobChild != null)
                {
                    personInfo += $"\nРебёнок находится в: {JobChild}";
                }

                return personInfo;
            }
        }
    }
}
