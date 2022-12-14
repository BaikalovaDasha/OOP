namespace LR61
{
    /// <summary>
    /// Осовной код.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Главная функция.
        /// </summary>
        public static void Main()
        {
            // Пустой список Школы №1
            List<Student> student = new List<Student>(10)
            {
                new Student("Елизавета", "Васильева", 11, "А"),
                new Student("Алексей", "Логинов", 11, "Б"),
                new Student("Ксения", "Мартынова", 11, "Б"),
                new Student("Егор", "Кузнецов", 11, "Б"),
                new Student("Никита", "Балашов", 11, "Б"),
                new Student("Эмилия", "Орлова", 11, "В"),
                new Student("Максим", "Артамонов", 10, "В"),
                new Student("Ева", "Орлова", 11, "В"),
                new Student("Кирилл", "Куликов", 10, "А"),
                new Student("Даниил", "Куликов", 10, "А")
            };

            Console.WriteLine("Список учащихся:");
            foreach (Student i in student)
            {
                Console.WriteLine(i.Print());
            }

            NameSake(student);

        }

        /// <summary>
        /// Метод для нахождения однофамильцев.
        /// </summary>
        /// <param name="student"> параметр.</param>
        public static void NameSake(List<Student> student)
        {
            // новый список для результатов
            var namesake = from person in student
                           group person by new
                           {
                               person.Surname,
                               person.ClassNumber,
                               person.ClassLetter,
                           }
                           into g
                           select new
                           {
                               Key = g.Key,
                               Count = g.Count(),

                               // Learner = from p in g select p
                           };

            // Перебор нового спсика, в котором находятся однофамильцы
            Console.WriteLine("\nПроизводится поиск однофамильцев");
            foreach (var person in namesake)
            {
                if (person.Count >= 2)
                {
                    Console.WriteLine($"В {person.Key.ClassNumber} " +
                        $"{person.Key.ClassLetter} классе " +
                        $"обучается {person.Count} студента " +
                        $"с одинаковой фамилией: {person.Key.Surname}");
                    /*foreach (var employee in person.Learner)
                    {
                        Console.WriteLine($"{employee.Name}");
                    }*/
                }
            }

        }

    }
}
