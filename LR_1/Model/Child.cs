using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
        /// Папа ребёнка.
        /// </summary>
        private Adult _father;

        /// <summary>
        /// мама ребёнка.
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// Чтение и запись папы ребёнка.
        /// </summary>
        public Adult Father 
        { 
            get => _father; 
            set
            {
                _father = value;
            } 
        }

        /// <summary>
        /// Чтение и запись мамы ребёнка.
        /// </summary>
        public Adult Mother
        {
            get => _mother;
            set
            {
                _mother = value;
            }
        }

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
                throw new Exception($"Возраст ребёнка должен находится" +
                    $" в диапазоне от {minAge} до {maxAge}");
            }
            else
            {
                return age;
            }
        }

        /// <summary>
        /// Вывод информации о ребёнке.
        /// </summary>
        public override string GetInfo()
        {
            var personInfo = base.GetInfo();

            if (Father != null)
            {
                personInfo += $"\nОтец: {Father.Name} {Father.Surname}";
            }
            else
            {
                personInfo += $"\nИнформации об отце нет!";
            }
            if (Mother != null)
            {
                personInfo += $"\nМать: {Mother.Name} {Mother.Surname}";
            }
            else
            {
                personInfo += $"\nИнформации о матери нет!";
            }
            
            if (JobChild != null)
            {
                personInfo += Age < 8
                    ? $"\nРебёнок ходит в садик: {JobChild}"
                    : $"\nРебёнок учится в школе: {JobChild}";
            }
            
            return personInfo;
        }

        /// <summary>
        /// Метод указывает какой любимый мультик у ребёнка.
        /// </summary>
        /// <returns>Просматриваемый мультик.</returns>
        public static string WatchingCartoons()
        {
            var rnd = new Random();

            string[] cartoons =
            {
                "Король лев", "Тайна Коко", "Балто", "Как приручить дракона",
                "Спирит", "Корпорация монстров", "Шрэк", "Бэмби",
                "Братец Медвежонок", "Похождения императора",
                "В поисках немо", "Атландита: Затерянный мир"
            };

            var selectCartoon = cartoons[rnd.Next(cartoons.Length)];

            return $"Любимый мультик: {selectCartoon}";
        }
    }
}
