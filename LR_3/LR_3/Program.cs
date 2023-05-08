using LR_3;
using Model;

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
            Console.WriteLine("Вас приветствует калькулятор для вычисления" +
                " потраченных калорий в зависимости от вида упражнения.\n" +
                "Нажмите любую кнопуку, чтобы начать.");
            Console.ReadKey();
            GetInfoExercise(ConsoleAddExercises.AddingSwimming());
            while (true) 
            {
            Console.WriteLine();
            Console.WriteLine("Выберите вид упражнения.\n" +
            "1 - плавание");
            var key = Console.ReadLine();
            switch (key) 
            {
            case "1":
            {
            GetInfoExercise(ConsoleAddExercises.AddingSwimming());
            }
            default:
            {
            Console.WriteLine("Попробуйте ещё раз.");
            break;
            }
            }
            }
        }

        public static void GetInfoExercise(ExercisesBase exercises)
        {
            Console.WriteLine($"Затратилось {exercises.CalculationCalorie()} калорий.");
        }
    }
}