namespace Model
{
    /// <summary>
    /// Класс упражнения жима штанги.
    /// </summary>
    public class BarbellPress : ExercisesBase
    {
        /// <summary>
        /// Вес человка.
        /// </summary>
        private double _weight;

        /// <summary>
        /// Количество повторений.
        /// </summary>
        private int _numerRepetitions;

        /// <summary>
        /// Чтение и записть веса человка.
        /// </summary>
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = CheckingWeight(CheckingNumber(value));
            }
        }

        /// <summary>
        /// Чтение и записть количества повторений.
        /// </summary>
        public int NumerRepetitions
        {
            get
            {
                return _numerRepetitions;
            }
            set
            {
                _numerRepetitions = CheckNumerRepetitions
                    ((int)CheckingNumber(value));
            }
        }

        /// <summary>
        /// Максимальное количество повторений.
        /// </summary>
        private const int MaxNumerRepetitions = 15;

        /// <summary>
        /// Максимальное количество повторений.
        /// </summary>
        private const int MinNumerRepetitions = 5;

        /// <summary>
        /// проверка на количество повторений
        /// </summary>
        /// <param name="numerRepetitions">количество повторений.</param>
        /// <returns>введённое количество повторений.</returns>
        /// <exception cref="Exception">неподходящее число повторений...
        /// .</exception>
        private int CheckNumerRepetitions(int numerRepetitions)
        {
            if (numerRepetitions < MinNumerRepetitions)
            {
                throw new ArgumentException($"Начинать было бы не плохо с " +
                    $"{MinNumerRepetitions} повторений.");
            }
            if (numerRepetitions > MaxNumerRepetitions)
            {
                throw new ArgumentException($"Нерекомендуется делать больше" +
                    $" {MaxNumerRepetitions} повторений за один подход");
            }
            return numerRepetitions;
        }

        /// <summary>
        /// Расчёт расхода калорий при жиме штанги.
        /// </summary>
        /// <returns>потраченные калории.</returns>
        public override int CalculationCalorie()
        {
            return (int)(Weight * 0.454 / 150 * 5 * NumerRepetitions);
        }
    }
}
