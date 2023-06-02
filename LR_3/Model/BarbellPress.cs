namespace Model
{
    /// <summary>
    /// Класс упражнения жима штанги.
    /// </summary>
    public class BarbellPress : ExercisesBase
    {
        /// <summary>
        /// поднимаемый вес.
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
                _weight = CheckWeight((int)CheckingNumber(value));
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
        private const int MinNumerRepetitions = 1;

        /// <summary>
        /// Максимальный вес.
        /// </summary>
        private const int MaxWeght = 335;

        /// <summary>
        /// Максимальное количество повторений.
        /// </summary>
        private const int MinWeght = 90;

        /// <summary>
        /// проверка на поднимаемый вес
        /// </summary>
        /// <param name="numerRepetitions">поднимаемый вес.</param>
        /// <returns>введённое поднимаемый вес.</returns>
        /// <exception cref="ArgumentException">вес не соответствует интервалу.</exception>
        private static int CheckWeight(int weight)
        {
            if (weight > MaxWeght)
            {
                throw new ArgumentException($"Поднимаемый вес не может быть" +
                    $" больше {MaxWeght}");
            }
            if (weight < MinWeght)
            {
                throw new ArgumentException($"Не рекомендуем поднимать вес" +
                    $" меньше, чем {MinWeght}");
            }
            return weight;
        }

        /// <summary>
        /// проверка на количество повторений
        /// </summary>
        /// <param name="numerRepetitions">количество повторений.</param>
        /// <returns>введённое количество повторений.</returns>
        /// //TODO: XML
        /// <exception cref="ArgumentException">повторения не соответствуют интервалу.</exception>
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
