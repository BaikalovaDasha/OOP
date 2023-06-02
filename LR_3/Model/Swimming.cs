namespace Model
{
    /// <summary>
    /// Класс упражнения плавание.
    /// </summary>
    public class Swimming : ExercisesBase
    {
        /// <summary>
        /// Вес человека.
        /// </summary>
        private double _weight;

        /// <summary>
        /// Время плавания.
        /// </summary>
        private int _time;

        /// <summary>
        /// Чтение и запись стиля плавания.
        /// </summary>
        public SwimmingStyle Style { get; set; }

        /// <summary>
        /// Чтение и записть веса.
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
        /// Чтение и записть времени плавания.
        /// </summary>
        public int Time 
        { 
            get
            {
                return _time;
            } 
            set
            {
                _time = CheckingTime((int)CheckingNumber(value));
            }
        }

        /// <summary>
        /// Максимальное время плавания.
        /// </summary>
        private const int MaxTime = 90;

        /// <summary>
        /// Минимальное время плавания.
        /// </summary>
        private const int MinTime = 10;

        /// <summary>
        /// Проверка времени при плавании.
        /// </summary>
        /// <param name="time">Время.</param>
        /// <returns>Введённое время.</returns>
        /// <exception cref="ArgumentException">исключает неподходящее время
        /// .</exception>
        private int CheckingTime(int time)
        {
            if (time < MinTime)
            {
                throw new ArgumentException($"Для результата необходимо проплыть" +
                    $" хотя бы {MinTime} минут.");
            }
            if (time > MaxTime)
            {
                throw new ArgumentException($"Нерекомендуется плавать больше" +
                    $" {MaxTime} минут!");
            }
            return time;
        }

        /// <summary>
        /// Словарь коэффициентов стиля плавания.
        /// </summary>
        private readonly Dictionary<SwimmingStyle, double> SwimmingStyle =
            new()
        {
            [Model.SwimmingStyle.Crawl] = 0.102,
            [Model.SwimmingStyle.Breaststroke] = 0.180,
            [Model.SwimmingStyle.Butterfly] = 0.242,
            [Model.SwimmingStyle.WaterAerobics] = 0.096,
        };

        /// <summary>
        /// Расчёт расхода калорий при плавании.
        /// </summary>
        /// <returns>потраченные калории.</returns>
        public override int CalculationCalorie()
        {
            return (int)(Weight * Time * SwimmingStyle[Style]);
        }
    }
}
