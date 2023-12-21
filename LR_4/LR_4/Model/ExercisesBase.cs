using System.ComponentModel;
using System.Xml.Serialization;
using model.Exercises;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace model.Exercises
{
    /// <summary>
    /// Класс для видов упражнений.
    /// </summary>
    [XmlInclude(typeof(BarbellPress))]
    [XmlInclude(typeof(Running))]
    [XmlInclude(typeof(Swimming))]

    public abstract class ExercisesBase
    {
        /// <summary>
        /// Тип упражнения.
        /// </summary>
        [DisplayName("Тип упражнения")]
        public abstract string ExercisesType { get; }

        /// <summary>
        /// Параметры упражнения.
        /// </summary>
        [DisplayName("Параметры упражнения")]
        public abstract string Parameters { get; }

        /// <summary>
        /// Метод рассчитывающий калории в зависимости...
        /// ...от выполненного упражнения.
        /// </summary>
        /// <returns>Рассчитанные колории.</returns>
        [DisplayName("Затраченные калории, Ккал")]
        public abstract int CalculationCalorie { get; }

        /// <summary>
        /// Проверка параметра.
        /// </summary>
        /// <param name="number">Число для проверки.</param>
        /// <returns>проверенное число.</returns>
        /// <exception cref="ArgumentException">отбрасывает отрицательные...
        /// ...числа</exception>
        protected static double CheckingNumber(double number)
        {
            if (number < 0 || double.IsNaN(number))
            {
                throw new ArgumentException("Параметр должен быть" +
                    " положительным!");
            }
            return number;
        }

        /// <summary>
        /// Максимальный вес человека.
        /// </summary>
        internal const int MaxWeight = 120;

        /// <summary>
        /// Максимальный вес человека.
        /// </summary>
        internal const int MinWeight = 45;

        /// <summary>
        /// Метод проверки веса человека.
        /// </summary>
        /// <param name="weight">Вес человека.</param>
        /// <returns>Введенный вес.</returns>
        /// <exception cref="Exception">исключает неподходящий вес.</exception>
        protected static double CheckingWeight(double weight)
        {
            if (weight < MinWeight || weight > MaxWeight || double.IsNaN(weight))
            {
                throw new ArgumentException(
                    $"Вес человека должен быть больше" +
                    $" {MinWeight} и не более {MaxWeight}.");
            }
            return weight;
        }

        /// <summary>
        /// Метод вывода инфрмации об упражнении.
        /// </summary>
        /// <returns></returns>
        public abstract string GetInfo();

    }
}