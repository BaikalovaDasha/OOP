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
        public Adult ParentOne { get; set; }

        /// <summary>
        /// папа
        /// </summary>
        public Adult ParentTwo { get; set; }

        /// <summary>
        /// Информация о детском саду или школе.
        /// </summary>
        public string JobChild { get; set; }


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
        /// Вывод информации о ребёнке.
        /// </summary>
        public override string GetInfo
        {
            get
            {
                var personInfo = base.GetInfo;
                if (ParentOne != null && ParentTwo != null)
                {
                    personInfo += $"\nРодители: {ParentOne.Name} {ParentOne.Surname}" +
                        $" и {ParentTwo.Name} {ParentTwo.Surname}";
                }
                if (ParentOne == null && ParentTwo == null)
                {
                    personInfo += $"\nРебёнок сирота.";
                }
                if (JobChild != null)
                {
                    personInfo += $"\nШкола/детский сад: {JobChild}";
                }
                return personInfo;
            }
        }
    }
}
