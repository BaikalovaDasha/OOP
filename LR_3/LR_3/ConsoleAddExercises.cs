using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace LR_3
{
    /// <summary>
    /// Класс добавления параметров в зависимости от вида... 
    /// ...выполняемого упражнения.
    /// </summary>
    public static class ConsoleAddExercises
    {
        /// <summary>
        /// Метод добавления вида упражнения: плавание.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public static Swimming AddingSwimming()
        {
            var swimming = new Swimming();

            var action= new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите вес человека, кг: ");
                    swimming.Weight = ReadFromConsoleAndParse();
                }), "вес человека"),

                (new Action(() =>
                {
                    Console.Write("Введите время плавания, мин: ");
                    swimming.Time = ReadFromConsoleAndParse();
                }), "время плавания"),
                (new Action(() =>
                {
                    Console.Write("Выберите стиль плавания (1 - кроль, " +
                        "2 - брасс, 3 - Баттерфляй, 4 - Аквааэробика):");
                    _ = int.TryParse(Console.ReadLine(), out int tmpStyle);
                    switch (tmpStyle)
                    {
                        case 1:
                        {
                            _ = swimming.Style == SwimmingStyle.Crawl;
                            break;
                        }
                        case 2:
                        {
                            _ = swimming.Style == SwimmingStyle.Breaststroke;
                            break;
                        }
                        case 3:
                        {
                            _ = swimming.Style == SwimmingStyle.Butterfly;
                            break;
                        }
                        case 4:
                        {
                            _ = swimming.Style == SwimmingStyle.WaterAerobics;
                            break;
                        }
                    }
                    if (tmpStyle < 1 || tmpStyle > 4)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                }), "стиль плавания"),

            };

            IterateList(action);

            return swimming;
        }

        /// <summary>
        /// Метод добавления вида упражнения: бег.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public static Running AddingRunning()
        {
            var running = new Running();

            var action = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите вес человека, кг: ");
                    running.Weight = ReadFromConsoleAndParse();
                }), "вес человека"),

                (new Action(() =>
                {
                    Console.Write("Введите расстояние, км: ");
                    running.Distance = ReadFromConsoleAndParse();
                }), "расстояние"),
                (new Action(() =>
                {
                    Console.Write("Виды интенсивности: 1 - минимальная," +
                        " 2 - слабая, 3 - средняя, 4 - высокая," +
                        " 5 - экстра.\nВыберите интенсивность при беге: ");
                    _ = int.TryParse(Console.ReadLine(), out int tmpIntensity);
                    switch (tmpIntensity)
                    {
                        case 1:
                        {
                            _ = running.Intensity == RunningIntensity.Minimum;
                            break;
                        }
                        case 2:
                        {
                            _ = running.Intensity == RunningIntensity.Weak;
                            break;
                        }
                        case 3:
                        {
                            _ = running.Intensity == RunningIntensity.Medium;
                            break;
                        }
                        case 4:
                        {
                            _ = running.Intensity == RunningIntensity.High;
                            break;
                        }
                        case 5:
                        {
                            _ = running.Intensity == RunningIntensity.Extra;
                            break;
                        }
                    }
                    if (tmpIntensity < 1 || tmpIntensity > 5)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                }), "интенсивность бега"),

            };

            IterateList(action);

            return running;
        }

        /// <summary>
        /// Метод добавления вида упражнения: жим штанги.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public static BarbellPress AddingBarbellPress()
        {
            var barbellPress = new BarbellPress();

            var action = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите вес человека, кг: ");
                    barbellPress.Weight = ReadFromConsoleAndParse();
                }), "вес человека"),

                (new Action(() =>
                {
                    Console.Write("Введите количество повторений: ");
                    barbellPress.NumerRepetitions = ReadFromConsoleAndParse();
                }), "количество повторений"),

            };

            IterateList(action);

            return barbellPress;
        }

        public static void IterateList(List<(Action, string)> actionList)
        {
            foreach (var act in actionList)
            {
                ActionHandler(act.Item1, act.Item2);
            }
        }

        /// <summary>
        /// Чтение с консоли и преобразование в double
        /// </summary>
        public static double ReadFromConsoleAndParse()
        {
            bool tmp = double.TryParse(Console.ReadLine().Replace('.', ','), out double number);
            if (!tmp)
            {
                throw new ArgumentException("Введите число!");
            }
            return number;
        }

        /// <summary>
        /// Метод использования Action.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="propertyName"></param>
        private static void ActionHandler(Action action, string propertyname)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    break;
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"Ошибка: {exception.Message} " +
                        $"Введите {propertyname} ещё раз!");
                }
            }
        }
    }
}
