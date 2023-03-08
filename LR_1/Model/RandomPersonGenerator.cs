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
        /// <summary>
        /// Класс случайной персоны.
        /// </summary>
        public static Person Person
        {
            get
            {
                string[] _maleNames = new string[]
                {
                    "Alisha", "Amanda", "Amelia", "Anaya", "Anna",
                    "Joslyn", "Natla", "Kristina", "Lara", "Pimiko",
                    "Samantha", "Jessica", "Ashley", "Ellen",
                };

                string[] _femaleNames = new string[]
                {
                    "Alex", "Alister", "Anfus", "Winston", "Vladimir",
                    "Werner", "James", "Jerome", "Zip", "Jonah",
                    "Kin", "Claudio", "Conrad", "Constantine",
                };

                string[] _suranames = new string[]
                {
                    "Weiss", "Fletcher", "Reyes", "Evert", "Croft",
                    "Croft", "Grimaldi", "Smith", "Rutland", "Whitman",
                    "Johnson", "Reyes", "Jaquelline", "Kade", "Roth", 
                };

                Random random = new Random();
                string name;
                Gender gender = (Gender)random.Next(0, 1);
                switch (gender)
                {
                    case Gender.Male:
                        name = _maleNames[random.Next(_maleNames.Length)];
                        break;
                    case Gender.Female:
                        name = _femaleNames[random.Next(_femaleNames.Length)];
                        break;
                    default:
                        return new Person("Default", "Person", 0, Gender.Male);
                }

                string surename = _suranames[random.Next(_suranames.Length)];
                int age = random.Next(0, Person.maxAge);

                return new Person(name, surename, age, gender);
            }
        }
    }
}
