namespace Model
{
    /// <summary>
    /// Класс упражнения бега.
    /// </summary>
    public class Running : ExercisesBase
    {
        /// <summary>
        /// Вес человека.
        /// </summary>
        private double _weight;

        /// <summary>
        /// Расстояние.
        /// </summary>
        private double _distance;

        /// <summary>
        /// Чтение и запись интенсивности.
        /// </summary>
        public RunningIntensity Intensity { get; set; }

        /// <summary>
        /// Чтение и запись веса.
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
        /// Чтение и запись расстояния.
        /// </summary>
        public double Distance
        {
            get
            {
                return _distance;
            }
            set
            {
                _distance = CheckingDistance(CheckingNumber(value));
            }
        }
        
        /// <summary>
        /// Максимальное расстояние при беге.
        /// </summary>
        private const int MaxDistance = 30;

        /// <summary>
        /// Максимальное расстояние при беге.
        /// </summary>
        private const double MinDistance = 1.5;

        /// <summary>
        /// Метод проверки дистанции.
        /// </summary>
        /// <param name="distance">Дистанция.</param>
        /// <returns>Введенная дистанция.</returns>
        /// <exception cref="Exception">исключает неподходящую дистанцию
        /// .</exception>
        private double CheckingDistance(double distance)
        {
            if (distance < MinDistance)
            {
                throw new ArgumentException($"Необходимо пробежать хотя бы " +
                    $"{MinDistance} км.");
            }
            if (distance > MaxDistance)
            { 
                throw new ArgumentException($"Нерекомендуется бегать больше" +
                    $" {MaxDistance} км. Опасно для здоровья!");
            }
            return distance;
        }

        /// <summary>
        /// Словарь коэффициентов интенсивности.
        /// </summary>
        private readonly Dictionary<RunningIntensity, double> RunningIntensity = 
            new()
        {
            [Model.RunningIntensity.Minimum] = 1.2,
            [Model.RunningIntensity.Weak] = 1.375,
            [Model.RunningIntensity.Medium] = 1.55,
            [Model.RunningIntensity.High] = 1.725,
            [Model.RunningIntensity.Extra] = 1.9,
        };

        /// <summary>
        /// Расчёт расхода калорий при беге.
        /// </summary>
        /// <returns> потраченные калории.</returns>
        public override int CalculationCalorie()
        {
            return (int)(Weight * Distance * RunningIntensity[Intensity]);
        }
    }
}
