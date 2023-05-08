using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BarbellPress : ExercisesBase
    {
        /// <summary>
        /// Вес штанги.
        /// </summary>
        private double _weight;

        /// <summary>
        /// Количество повторений.
        /// </summary>
        private double _numerRepetitions;

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
        /// Чтение и записть количества повторений.
        /// </summary>
        public double NumerRepetitions
        {
            get
            {
                return _numerRepetitions;
            }
            set
            {
                _numerRepetitions = CheckingNumber(value);
            }
        }

        /// <summary>
        /// Расчёт расхода калорий при жиме штанги.
        /// </summary>
        /// <returns></returns>
        public override double CalculationCalorie()
        {
            return Math.Round( (Weight * 0.454 / 150 ) * 5 * NumerRepetitions, 1);
        }
    }
}
