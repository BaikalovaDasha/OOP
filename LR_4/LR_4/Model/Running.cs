﻿namespace model
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

        // TODO: Обновить описания + 
        /// <summary>
        /// Максимальное расстояние при беге.
        /// </summary>
        private const int MaxDistance = 30;

        /// <summary>
        /// Максимальное расстояние при беге.
        /// </summary>
        private const double MinDistance = 1.5;

        // TODO: Уточнить Exception +
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
        /// Словарь интенсивности бега.
        /// </summary>
        private readonly Dictionary<RunningIntensity, double> runningIntensity =
            new()
            {
                [RunningIntensity.Minimum] = 1.2,
                [RunningIntensity.Weak] = 1.375,
                [RunningIntensity.Medium] = 1.55,
                [RunningIntensity.High] = 1.725,
                [RunningIntensity.Extra] = 1.9,
            };

        // TODO: Добавить описание +
        /// <summary>
        /// Расчёт расхода калорий при беге.
        /// </summary>
        /// <returns> потраченные калории.</returns>
        public override int CalculationCalorie =>
            // TODO: Вынести из метода + (вынести словарь) 
            (int)(Weight * Distance * runningIntensity[Intensity]);

        /// <summary>
        /// Тип упражнения.
        /// </summary>
        public override string ExercisesType
        {
            get
            {
                return $"Бег";
            }
        }

        /// <summary>
        /// Параметры упражнения.
        /// </summary>
        public override string Parameters
        {
            get
            {
                return $"Вес человека = {Weight} кг\n" +
                    $"Расстояние = {Distance} км\n" +
                    $"Интенсивность бега = {Intensity}";
            }
        }

        /// <summary>
        /// Метод вывода инфрмации об упражнении.
        /// </summary>
        /// <returns>Иняормация об упражнении.</returns>
        public override string GetInfo()
        {
            return $"Вес человека = {Weight} кг;\n" +
                $"Расстояние = {Distance} мин;\n" +
                $"Интенсивность бега = {Intensity}.\n" +
                $"Затраченные калории = {CalculationCalorie} Ккал";
        }
    }
}