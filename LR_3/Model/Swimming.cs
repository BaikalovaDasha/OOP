using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Swimming : IExercisesBase
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
        /// Стиль плавания.
        /// </summary>
        private int _style;

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
        /// Чтение и запись стиля плавания.
        /// </summary>
        public int Style
        {
            get
            {
                return _style;
            }
            set
            {
                _style = value;
            }
        }

        /// <summary>
        /// Расчёт расхода калорий при плавании.
        /// </summary>
        /// <returns></returns>
        public override double CalculationCalorie()
        {
            return Math.Round(Weight * Time * Style);
        }
    }
}
