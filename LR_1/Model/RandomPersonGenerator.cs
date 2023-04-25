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
                "Гафа", "Хендрикс", "Зеник", "Хелен", "Ланцова",
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
                "Ланцов", "Костюк", "Морозов", "Фахи", "Юл-Батаар",
                "Бреккер", "Фахи", "Смит", "Оретцев", "Хельвар",
                "Роллинс", "Хаскель", "Безников",
        };

        /// <summary>
        /// Заполнение базовых параметров (имени и фамилии) персоны.
        /// </summary>
        /// <param name="person">Персона.</param>
        public static void RandomPersonBase(PersonBase person, Gender gender = Gender.Default)
        {
            person.Gender = gender == Gender.Default 
                ? (Gender)_randompPerson.Next(2) 
                : gender;

            person.Name = person.Gender == Gender.Female
                ? _femaleNames[_randompPerson.Next(_femaleNames.Length)]
                : _maleNames[_randompPerson.Next(_maleNames.Length)];

            person.Surname = person.Gender == Gender.Female
                ? _femaleSuranames[_randompPerson.Next(_femaleSuranames.Length)]
                : _maleSuranames[_randompPerson.Next(_maleSuranames.Length)];
        }

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
                chars[i] = validChars[_randompPerson.Next(validChars.Length)];
            }

            return adult.Pasport = new string(chars);
        }

        /// <summary>
        /// Генерация 
        /// </summary>
        /// <param name="gender">Пол взрослого.</param>
        /// <param name="spouse">супруг / супруга.</param>
        /// <param name="state">Семейное положение.</param>
        /// <returns></returns>
        public static Adult CreateRandomAdult(Gender gender = Gender.Default,
            Adult spouse = null,
            StateOfMarriage state = StateOfMarriage.NotMarried)
        {
            var randomAdult = new Adult();

            RandomPersonBase(randomAdult, gender);

            randomAdult.Age =
                _randompPerson.Next(Adult.minAge, Adult.maxAge);

            StateOfMarriage maritalstatus = (StateOfMarriage)_randompPerson.Next(2);

            randomAdult.StateOfMarriage = maritalstatus;

            if (maritalstatus == StateOfMarriage.Married)
            {
                randomAdult.Spouse = randomAdult.Gender == Gender.Male
                    ? CreateRandomAdult(Gender.Female,
                        randomAdult, StateOfMarriage.Married)
                    : CreateRandomAdult(Gender.Male,
                        randomAdult, StateOfMarriage.Married);
            }
            else
            {
                randomAdult.StateOfMarriage = state;
            }

            string[] jobs = new string[]
            {
                "Инкассатор", "Налоговый инспектор", "Анестезиолог",
                "Нарколог", "Химик", "Робототехник", "Инженер-химик",
                "Диспетчер", "Авиадиспетчер", "Гример", "Парикмахер",
            };

            randomAdult.Job = jobs[_randompPerson.Next(0, jobs.Length)];

            CreateRandomPassword(randomAdult);

            return randomAdult;
        }


        public static Child CreateRandomChild()
        {
            var randomChild = new Child();

            RandomPersonBase(randomChild);

            randomChild.Age =
                _randompPerson.Next(Child.minAge, Child.maxAge);

            bool mother = _randompPerson.Next(2) != 0;

            if (mother)
            {
                randomChild.Mother = CreateRandomAdult(Gender.Female);
            }

            bool father = _randompPerson.Next(2) != 0;

            if (father)
            {
                randomChild.Father = CreateRandomAdult(Gender.Male);
            }

            string[] kindergarten = new string[]
            {
                "Солнышко", "Ласточка", "Ромашка", "Облачко",
            };

            string[] school = new string[]
            {
                "СОШ №12", "Гимназия", "Лицей",
            };

            randomChild.JobChild = randomChild.Age < 8
                ? kindergarten[_randompPerson.Next(kindergarten.Length)]
                : school[_randompPerson.Next(school.Length)];

            return randomChild;
        }

    }
}
