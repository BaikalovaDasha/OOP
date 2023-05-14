using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //TODO: XML + 
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
                _distance = CheckingDistance((int)CheckingNumber(value));
            }
        }

        /// <summary>
        /// Максимальный вес человека.
        /// </summary>
        private const int MaxDistance = 30;

        /// <summary>
        /// Максимальный вес человека.
        /// </summary>
        private const double MinDistance = 1.5;

        /// <summary>
        /// Метод проверки дистанции.
        /// </summary>
        /// <param name="weight">Дистанция.</param>
        /// <returns>Введенная дистанция.</returns>
        /// <exception cref="Exception">исключает неподходящую дистанцию
        /// .</exception>
        protected static int CheckingDistance(int distance)
        {
            if (distance < MinDistance)
            {
                throw new Exception($"Необходимо пробежать хотя бы " +
                    $"{MinDistance} км.");
            }
            else if (distance > MaxDistance)
            { 
                throw new Exception($"Нерекомендуется бегать больше" +
                    $" {MaxDistance} км. Опасно для здоровья!");
            }
            return distance;
        }

        /// <summary>
        /// Расчёт расхода калорий при беге.
        /// </summary>
        /// <returns></returns>
        public override int CalculationCalorie()
        {
            //TODO: switch-case + 
            //TODO: сделать соответствие элементам перечисления и коэффициентам + 
            var runningIntensity = new Dictionary<RunningIntensity, double>()
            {
                [RunningIntensity.Minimum] = 1.2,
                [RunningIntensity.Weak] = 1.375,
                [RunningIntensity.Medium] = 1.55,
                [RunningIntensity.High] = 1.725,
                [RunningIntensity.Extra] = 1.9,
            };

            return (int)(Weight * Distance * runningIntensity[Intensity]);
        }
    }
}
