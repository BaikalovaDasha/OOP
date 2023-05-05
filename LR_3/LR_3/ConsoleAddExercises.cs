using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3
{
    public class ConsoleAddExercises
    {
        /// <summary>
        /// Метод добавления вида упражнения.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public static void AddExercises()
        {
            IExercisesBase exercises = new Swimming();

            Action action = new(() =>
            {
                Console.WriteLine($"1 - бег,\n" +
                    $"2 - плавание,\n" +
                    $"3 - жим штанги.\n" +
                    $"Расчёт затраченных калорий в зависимости" +
                    $" от вида упражнений: ");

                bool _ = int.TryParse(Console.ReadLine(), out int exercise);

                switch (exercise)
                {
                    case 1:
                    {
                        exercises = new Swimming();
                        break;
                    }

                    case 2:
                    {
                        exercises = new BarbellPress();
                        break;
                    }
                    case 3:
                    {
                        exercises = new Running();
                        break;
                    }
                    default:
                    {
                        throw new ArgumentException
                        ("Введите корректный номер упражнения.");
                    }
                }
            });
        }
    }
}
