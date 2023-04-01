using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Генерирует случайного человека.
    /// </summary>
    public static class RandomPersonGenerator
    {
        //TODO: XML +
        /// <summary>
        /// Метод создания рандомной персоны
        /// </summary>
        public static PersonBase GetRandomPerson()
        {
            string[] femaleNames = new string[]
                {
                    "Алина", "Дуняша", "Женя", "Зоя",
                    "Инеж", "Марья", "Нина", "Тамара", "Надя",
                    "Танте", "Татьяна",
                };

            string[] femaleSuranames = new string[]
            {
                    "Старкова", "Лазарева", "Сафина", "Назяленская",
                    "Гафа", "Хендрикс", "Зеник", "Кир-Батаар", "Хелен",
                    "Ланцова",
            };

            string[] maleNames = new string[]
            {
                    "Бо", "Василий", "Давид", "Александр", "Джаспер",
                    "Илья", "Каз", "Колм", "Корнелис", "Пекка", "Пер",
                    "Мальен", "Матиас", "Николай", "Сергей", "Толя",
            };

            string[] maleSuranames = new string[]
            {
                    "Юл-Баюр", "Ланцов", "Костюк", "Морозов", "Фахи",
                    "Бреккер", "Фахи", "Смит", "Оретцев", "Хельвар",
                    "Роллинс", "Хаскель", "Безников", "Юл-Батаар",
            };

            Random random = new();
            string name;
            string surname;
            Gender gender = (Gender)random.Next(0, 2);
            switch (gender)
            {
                case Gender.Male:
                    name = maleNames[random.Next(maleNames.Length)];
                    surname = maleSuranames[random.Next(maleSuranames.Length)];
                    break;
                case Gender.Female:
                    name = femaleNames[random.Next(femaleNames.Length)];
                    surname = femaleSuranames[random.Next(femaleSuranames.Length)];
                    break;
                default:
                    return new PersonBase("Default", "Person", 0, Gender.Male);
            }

            int age = random.Next(0, 110);

            return new PersonBase(name, surname, age, gender);

        }
    }
}
