namespace model
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
                _weight = CheckingWeight(CheckingNumber(value));
            }
        }

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
        private const int MaxNumerRepetitions = 10;

        /// <summary>
        /// Максимальное количество повторений.
        /// </summary>
        private const int MinNumerRepetitions = 1;

        // TODO: Уточнить Exception + 
        // TODO: Добавить описание +
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

        // TODO: Добавить описание + 
        /// <summary>
        /// Расчёт расхода калорий при жиме штанги.
        /// </summary>
        /// <returns>потраченные калории.</returns>
        public override int CalculationCalorie()
        {
            return (int)(Weight * 0.454 / 150 * 5 * NumerRepetitions);
        }

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
                return $"Вес человека = {Weight}, кг;\n" +
                    $"Вес штанги = {WeightRod}, кг;\n" +
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