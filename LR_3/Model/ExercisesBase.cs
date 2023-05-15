﻿namespace Model
{
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
        
        /// <summary>
        /// Проверка параметра.
        /// </summary>
        /// <param name="number">Число для проверки.</param>
        /// <returns>проверенное число.</returns>
        /// <exception cref="ArgumentException">отбрасывает отрицательные...
        /// ...числа</exception>
        protected double CheckingNumber(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Параметр должен быть" +
                    " положительным!");
            }
            return number;
        }

        /// <summary>
        /// Максимальный вес человека.
        /// </summary>
        private const int MaxWeight = 120;

        /// <summary>
        /// Максимальный вес человека.
        /// </summary>
        private const int MinWeight = 45;

        /// <summary>
        /// Метод проверки веса человека.
        /// </summary>
        /// <param name="weight">Вес человека.</param>
        /// <returns>Введенный вес.</returns>
        /// <exception cref="Exception">исключает неподходящий вес.</exception>
        protected double CheckingWeight(double weight)
        {
            if (weight < MinWeight || weight > MaxWeight)
            {
                throw new ArgumentException(
                    $"Вес человека должен быть больше" +
                    $" {MinWeight} и не более {MaxWeight}.");
            }
            return weight;
        }

    }
}