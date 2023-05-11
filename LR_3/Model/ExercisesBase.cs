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

    }
}