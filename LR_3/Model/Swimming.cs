using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
    //TODO: XML + 
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
        private const double MinTime = 10;

        /// <summary>
        /// Проверка времени при плавании.
        /// </summary>
        /// <param name="weight">Время.</param>
        /// <returns>Введённое время.</returns>
        /// <exception cref="Exception">исключает неподходящее время
        /// .</exception>
        protected static int CheckingTime(int time)
        {
            if (time < MinTime)
            {
                throw new Exception($"Для результата необходимо проплыть" +
                    $" хотя бы {MinTime} минут.");
            }
            else if (time > MaxTime)
            {
                throw new Exception($"Нерекомендуется плавать больше" +
                    $" {MaxTime} минут!");
            }
            return time;
        }

        /// <summary>
        /// Расчёт расхода калорий при плавании.
        /// </summary>
        /// <returns></returns>
        public override int CalculationCalorie()
        {
            var swimmingStyle = new Dictionary<SwimmingStyle, double>()
            {
                [SwimmingStyle.Crawl] = 0.102,
                [SwimmingStyle.Breaststroke] = 0.180,
                [SwimmingStyle.Butterfly] = 0.242,
                [SwimmingStyle.WaterAerobics] = 0.096,
            };

            return (int)(Weight * Time * swimmingStyle[Style]);
        }
    }
}
