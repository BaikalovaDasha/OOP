namespace model.Exercises
{
    /// <summary>
    /// Класс упражнения жима штанги.
    /// </summary>
    public class BarbellPress : ExercisesBase
    {
        /// <summary>
        /// Вес штанги.
        /// </summary>
        private double _weightRod;

        /// <summary>
        /// Вес человека.
        /// </summary>
        private double _weight;

        /// <summary>
        /// Количество повторений.
        /// </summary>
        private int _numerRepetitions;

        /// <summary>
        /// Чтение и записть веса человека.
        /// </summary>
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = CheckingWeight(value);
            }
        }

        /// <summary>
        /// Чтение и записть веса штанги.
        /// </summary>
        public double WeightRod
        {
            get
            {
                return _weightRod;
            }
            set
            {
                _weightRod = CheckingWeightRod(value);
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
                _numerRepetitions = CheckNumerRepetitions(value);
            }
        }

        /// <summary>
        /// Максимальное количество повторений.
        /// </summary>
        internal const int MinWeghtRod = 20;

        /// <summary>
        /// Проверка веса штанги.
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private double CheckingWeightRod(double weightRod)
        {
            if (weightRod > Weight)
            {
                throw new ArgumentException(
                    $"Не рекомендуется поднимать штангу больше своего веса.");
            }
            if (weightRod < MinWeghtRod)
            {
                throw new ArgumentException(
                    $"Рекомендуем начать с {MinWeghtRod} кг.");
            }
            return weightRod;
        }

        /// <summary>
        /// Максимальное количество повторений.
        /// </summary>
        internal const int MaxNumerRepetitions = 10;

        /// <summary>
        /// Максимальное количество повторений.
        /// </summary>
        internal const int MinNumerRepetitions = 5;

        /// <summary>
        /// проверка на количество повторений
        /// </summary>
        /// <param name="numerRepetitions">количество повторений.</param>
        /// <returns>введённое количество повторений.</returns>
        /// <exception cref="Exception">неподходящее число повторений...
        /// .</exception>
        private static int CheckNumerRepetitions(int numerRepetitions)
        {
            if (numerRepetitions < MinNumerRepetitions)
            {
                throw new ArgumentException($"Было бы не плохо начать хотя бы с " +
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
        public override int CalculationCalorie =>
            (int)(WeightRod * 0.454 / 150 * 5 * NumerRepetitions);

        /// <summary>
        /// Тип упражнения.
        /// </summary>
        public override string ExercisesType
        {
            get
            {
                return $"Жим штанги лёжа";
            }
        }

        /// <summary>
        /// Параметры упражнения.
        /// </summary>
        public override string Parameters
        {
            get
            {
                return $"Вес человека = {Weight} кг;\n" +
                    $"Вес штанги = {WeightRod} кг;\n" +
                    $"Количество повторений = {NumerRepetitions}";
            }
        }

        /// <summary>
        /// Метод вывода инфрмации об упражнении.
        /// </summary>
        /// <returns>Иняормация об упражнении.</returns>
        public override string GetInfo()
        {
            return $"Жим штанги:\nВес человека = {Weight}, кг;\n " +
                $"Вес штанги = {WeightRod}, кг;\n" +
                $"Количество повторений = {NumerRepetitions}.\n" +
                $"Затраченные калории = {CalculationCalorie}, Ккал";
        }
    }
}