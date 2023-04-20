using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model
{
    /// <summary>
    /// Генерирует случайного человека.
    /// </summary>
    public class RandomPersonGenerator
    {
        /// <summary>
        /// Объект класса RandomPersonGenerator.
        /// </summary>
        private static Random _randompPerson = new();

        /// <summary>
        /// Строковый массив женских имён.
        /// </summary>
        private static readonly string[] _femaleNames = new string[]
        {
                "Алина", "Дуняша", "Женя", "Зоя",
                "Инеж", "Марья", "Нина", "Тамара", "Надя",
                "Танте", "Татьяна",
        };

        /// <summary>
        /// Строковый массив женских фамилий.
        /// </summary>
        private static readonly string[] _femaleSuranames = new string[]
        {
                "Старкова", "Лазарева", "Сафина", "Назяленская",
                "Гафа", "Хендрикс", "Зеник", "Кир-Батаар", "Хелен",
                "Ланцова",
        };

        /// <summary>
        /// Строковый массив мужских имён.
        /// </summary>
        private static readonly string[] _maleNames = new string[]
        {
                "Бо", "Василий", "Давид", "Александр", "Джаспер",
                "Илья", "Каз", "Колм", "Корнелис", "Пекка", "Пер",
                "Мальен", "Матиас", "Николай", "Сергей", "Толя",
        };

        /// <summary>
        /// Строковый массив мужских фамилий.
        /// </summary>
        private static readonly string[] _maleSuranames = new string[]
        {
                "Юл-Баюр", "Ланцов", "Костюк", "Морозов", "Фахи",
                "Бреккер", "Фахи", "Смит", "Оретцев", "Хельвар",
                "Роллинс", "Хаскель", "Безников", "Юл-Батаар",
        };

        /// <summary>
        /// Заполнение базовых параметров (имени и фамилии) персоны.
        /// </summary>
        /// <param name="person">Персона.</param>
        public static void RandomPersonBase(PersonBase person)
        {
            Gender gender = (Gender)_randompPerson.Next(0, 2);

            switch (gender)
            {
                case Gender.Male:
                    {
                        person.Name = _maleNames
                                [_randompPerson.Next(_maleNames.Length)];
                        person.Surname = _maleSuranames
                                [_randompPerson.Next(_maleSuranames.Length)];
                        break;
                    }
                case Gender.Female:
                    {
                        person.Name = _femaleNames
                                [_randompPerson.Next(_femaleNames.Length)];
                        person.Surname = _femaleSuranames
                                [_randompPerson.Next(_femaleSuranames.Length)];
                        break;
                    }
            }
        }

        /// <summary>
        /// Генерация 
        /// </summary>
        /// <param name="gender">Пол взрослого.</param>
        /// <param name="spouse"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static Adult CreateRandomAdult(Gender gender,
            Adult? spouse = null,
            StateOfMarriage state = StateOfMarriage.notMarried)
        {
            var randomAdult = new Adult();

            RandomPersonBase(randomAdult);

            randomAdult.Age =
                _randompPerson.Next(Adult.minAge, Adult.maxAge);

            StateOfMarriage married =
                (StateOfMarriage)_randompPerson.Next(0, 1);

            switch (married)
            {
                case StateOfMarriage.married:
                    {
                        if (randomAdult.Gender == Gender.Female)
                        {
                            randomAdult.Spouse = CreateRandomAdult(Gender.Male,
                                randomAdult, StateOfMarriage.married);
                        }
                        else
                        {
                            randomAdult.Spouse = CreateRandomAdult(Gender.Female,
                                randomAdult, StateOfMarriage.married);
                        }
                        break;
                    }

                case StateOfMarriage.notMarried:
                    {
                        randomAdult.StateOfMarriage = state;
                        break;
                    }
            }

            string[] jobs = new string[]
            {
                "Охотник", "Следопыт", "Гриш", "Прислуга",
            };

            randomAdult.Job = jobs[_randompPerson.Next(0, jobs.Length)];

            string validChars = "0123456789";
            char[] chars = new char[validChars.Length];

            for (int i = 0; i < validChars.Length; i++)
            {
                chars[i] = validChars[_randompPerson.Next(0, validChars.Length)];
            }

            randomAdult.Pasport = new string(chars);

            return randomAdult;
        }

        /*
        /// <summary>
        /// генерация паспортных данных.
        /// </summary>
        /// <param name="adult">Взрослый человек.</param>
        /// <returns>паспортные данные.</returns>
        private static string CreateRandomPassword(Adult adult)
        {
            string validChars = "0123456789";
            char[] chars = new char[validChars.Length];

            for (int i = 0; i < validChars.Length; i++)
            {
                chars[i] = validChars[_randompPerson.Next(0, validChars.Length)];
            }

            return adult.Pasport = new string(chars);
        }*/


        public static Child CreateRandomChild()
        {
            var randomChild = new Child();

            RandomPersonBase(randomChild);

            randomChild.Age =
                _randompPerson.Next(Child.minAge, Child.maxAge);

            return randomChild;
        }

    }
}
