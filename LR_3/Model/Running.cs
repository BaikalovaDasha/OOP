using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
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
        /// Чтение и записть расстояние.
        /// </summary>
        public double Distance
        {
            get
            {
                return _distance;
            }
            set
            {
                _distance = CheckingNumber(value);
            }
        }

        /// <summary>
        /// Расчёт расхода калорий при беге.
        /// </summary>
        /// <returns></returns>
        public override double CalculationCalorie()
        {
            double calories;

            if (Intensity == RunningIntensity.Minimum)
            {
                calories = Math.Round(Weight * Distance * 1.2, 1);
            }
            else if (Intensity == RunningIntensity.Weak)
            {
                calories = Math.Round(Weight * Distance * 1.375, 1);
            }
            else if (Intensity == RunningIntensity.Medium)
            {
                calories = Math.Round(Weight * Distance * 1.55, 1);
            }
            else if (Intensity == RunningIntensity.High)
            {
                calories = Math.Round(Weight * Distance * 1.725, 1);
            }
            else
            {
                calories = Math.Round(Weight * Distance * 1.9, 1);
            }
            return calories;
        }
    }
}
