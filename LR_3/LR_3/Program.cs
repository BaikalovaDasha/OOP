using LR_3;

namespace ConsoleApp
{
    /// <summary>
    /// Основная программа.
    /// </summary>
    internal class Program
    {

        /// <summary>
        /// Основная программа.
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Программ для расчёта затраченных калорий" +
                " в зависимости от вида упражнений:");
            ConsoleAddExercises.AddExercises();
        }
    }
}