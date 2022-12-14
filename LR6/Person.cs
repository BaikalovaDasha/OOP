namespace LR61
{
    /// <summary>
    /// Метод описывает учащихся.
    /// </summary>
    public struct Student
    {
        /// <summary>
        /// Gets or sets имя учащегося.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets фамилия учащегося.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets номер класса.
        /// </summary>
        public int ClassNumber { get; set; }

        /// <summary>
        /// Gets or sets буква класса.
        /// </summary>
        public string ClassLetter { get; set; }

        /// <summary>
        /// Конструктор структуры.
        /// </summary>
        /// <param name="name">Фамилия.</param>
        /// <param name="surname">Имя.</param>
        /// <param name="classNumber">Нормер класса.</param>
        /// <param name="classLetter">Буква класса.</param>
        public Student(string name, string surname, int classNumber,
            string classLetter)
        {
            Name = name;
            Surname = surname;
            ClassNumber = classNumber;
            ClassLetter = classLetter;
        }

        /// <summary>
        /// Выводит в консоль.
        /// </summary>
        /// <returns> Вывод строки.</returns>
        public string Print()
        {
            return $"Студент {Surname} {Name} обучается в {ClassNumber}{ClassLetter}";
        }

    }
}


