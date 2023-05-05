using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Running : IExercisesBase
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
        /// Интенсивность.
        /// </summary>
        private int _intensity;

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
        /// Чтение и запись интенсивности.
        /// </summary>
        public int Intensity
        {
            get
            {
                return _intensity;
            }
            set
            {
                _intensity = value;
            }
        }

        /// <summary>
        /// Расчёт расхода калорий при беге.
        /// </summary>
        /// <returns></returns>
        public override double CalculationCalorie()
        {
            return Math.Round(Weight * Distance * Intensity);
        }
    }
}
