﻿namespace model.Exercises
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
        /// Стиль плавания.
        /// </summary>
        private SwimmingStyle _style;

        /// <summary>
        /// Чтение и запись стиля плавания.
        /// </summary>
        public SwimmingStyle Style 
        { 
            get
            {
                return _style;
            }

            set
            {
                //if (value == SwimmingStyle.Defult)
                //{
                //    throw new ArgumentException($"Вы забыли выбрать стиль плавания!");
                //}

                _style = value;
            }
        }

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
                _time = CheckingTime(value);
            }
        }

        /// <summary>
        /// Максимальное время плавания.
        /// </summary>
        internal const int MaxTime = 90;

        /// <summary>
        /// Минимальное время плавания.
        /// </summary>
        internal const int MinTime = 10;

        /// <summary>
        /// Проверка времени при плавании.
        /// </summary>
        /// <param name="time">Время.</param>
        /// <returns>Введённое время.</returns>
        /// <exception cref="Exception">исключает неподходящее время
        /// .</exception>
        private static int CheckingTime(int time)
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
        /// Словарь стилей плавания.
        /// </summary>
        private readonly Dictionary<SwimmingStyle, double> swimmingStyle =
            new()
            {
                [SwimmingStyle.Crawl] = 0.102,
                [SwimmingStyle.Breaststroke] = 0.180,
                [SwimmingStyle.Butterfly] = 0.242,
                [SwimmingStyle.WaterAerobics] = 0.096,
            };

        /// <summary>
        /// Расчёт расхода калорий при плавании.
        /// </summary>
        /// <returns>потраченные калории.</returns>
        public override int CalculationCalorie =>
            (int)(Weight * Time * swimmingStyle[Style]);

        /// <summary>
        /// Тип упражнения.
        /// </summary>
        public override string ExercisesType
        {
            get
            {
                return $"Плавание";
            }
        }

        /// <summary>
        /// Словарь стилей плавания для отображения.
        /// </summary>
        private protected readonly Dictionary<SwimmingStyle, string> styleSwimming =
            new()
            {
                [SwimmingStyle.Crawl] = "кроль",
                [SwimmingStyle.Breaststroke] = "брас",
                [SwimmingStyle.Butterfly] = "баттерфлай",
                [SwimmingStyle.WaterAerobics] = "аэробика",
            };

        /// <summary>
        /// Параметры упражнения.
        /// </summary>
        public override string Parameters
        {
            get
            {
                string parameters = $"Вес человека = {Weight} кг;\n" +
                    $"Время плавания = {Time} мин;\n" +
                    $"Стиль плавания = {styleSwimming[Style]}";

                return parameters;
            }
        }

        /// <summary>
        /// Метод вывода инфрмации об упражнении.
        /// </summary>
        /// <returns>Иняормация об упражнении.</returns>
        public override string GetInfo()
        {
            return $"Жим штанги:\nВес человека = {Weight}, кг;\n" +
                $"Время плавания = {Time}, мин;\n" +
                $"Стиль плавания = {Style}.\n" +
                $"Затраченные калории = {CalculationCalorie}, Ккал";
        }
    }
}