using static System.Net.Mime.MediaTypeNames;

namespace Model
{
    //TODO: XML + 
    /// <summary>
    /// Класс для видов упражнений.
    /// </summary>
    public abstract class ExercisesBase
    {
        /// <summary>
        /// Метод рассчитывающий калории в зависимости...
        /// ...от выполненного упражнения.
        /// </summary>
        /// <returns></returns>
        public abstract int CalculationCalorie();

        //TODO: почему public? +
        /// <summary>
        /// Проверка параметра.
        /// </summary>
        /// <param name="number">Число для проверки.</param>
        /// <returns>проверенное число.</returns>
        /// <exception cref="ArgumentException">отбрасывает отрицательные...
        /// ...числа</exception>
        protected static double CheckingNumber(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Параметр должен быть" +
                    " положительным!");
            }
            else
            {
                return number;
            }
        }

        /// <summary>
        /// Максимальный вес человека.
        /// </summary>
        public const int maxWeight = 120;

        /// <summary>
        /// Максимальный вес человека.
        /// </summary>
        public const int minWeight = 45;

        /// <summary>
        /// Метод проверки веса человека.
        /// </summary>
        /// <param name="weight">Вес человека.</param>
        /// <returns>Введенный вес.</returns>
        /// <exception cref="Exception">исключает неподходящий вес.</exception>
        protected static double CheckingWeight(double weight)
        {
            if (weight < minWeight || weight > maxWeight)
            {
                throw new Exception($"Вес человека должен быть больше" +
                    $" {minWeight} и не более {maxWeight}.");
            }
            return weight;
        }

    }
}