using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
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
        public override double CalculationCalorie()
        {
            double calories;

            if (Style == SwimmingStyle.Crawl)
            {
                calories = Math.Round(Weight * Time * 0.102, 1);
            }
            else if (Style == SwimmingStyle.Breaststroke)
            {
                calories = Math.Round(Weight * Time * 0.180, 1);
            }
            else if (Style == SwimmingStyle.Butterfly)
            {
                calories = Math.Round(Weight * Time * 0.242, 1);
            }
            else
            {
                calories = Math.Round(Weight * Time * 0.096, 1);
            }
            return calories;
        }
    }
}
