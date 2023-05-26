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

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите действие:\n"
                    + "1 - плавание\n" + "2 - бег\n" + "3 - жим штанги\n"
                    + "4 - Выход из программы");

                var key = Console.ReadLine();

                switch (key)
                {
                    case "1":
                    {
                        GetInfoExercise(ConsoleAddExercises.AddingSwimming());
                            break;
                    }
                    case "2":
                    {
                        GetInfoExercise(ConsoleAddExercises.AddingRunning());
                        break;
                    }
                    case "3":
                    {
                        GetInfoExercise(ConsoleAddExercises.AddingBarbellPress());
                        break;
                    }
                    case "4":
                    {
                        Environment.Exit(0);
                        break; ;
                    }
                    default:
                    {
                        Console.WriteLine("Попробуйте ещё раз.");
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Вывод потраченных калорий.
        /// </summary>
        /// <param name="exercises">вид упражнения.</param>
        public static void GetInfoExercise(ExercisesBase exercises)
        {
            Console.WriteLine(
                $"Затратилось {exercises.CalculationCalorie()} калорий.");
        }
    }
}