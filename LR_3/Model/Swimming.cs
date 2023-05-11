using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private double _time;

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
                _weight = CheckingNumber(value);
            }
        }

        /// <summary>
        /// Чтение и записть времени плавания.
        /// </summary>
        public double Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = CheckingNumber(value);
            }
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
