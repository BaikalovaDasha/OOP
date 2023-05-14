using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
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

            var actionList= new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите вес человека, кг: ");
                    swimming.Weight = ReadFromConsoleAndParse();
                }), "вес человека"),

                (new Action(() =>
                {
                    Console.Write("Введите время плавания, мин: ");
                    swimming.Time = (int)ReadFromConsoleAndParse();
                }), "время плавания"),
                (new Action(() =>
                {
                    Console.Write("Выберите стиль плавания (1 - кроль, " +
                        "2 - брасс, 3 - Баттерфляй, 4 - Аквааэробика):");
                    _ = int.TryParse(Console.ReadLine(), out int tmpStyle);
                    switch (tmpStyle)
                    {
                        //BUG: + 
                        case 1:
                        {
                            swimming.Style = SwimmingStyle.Crawl;
                            break;
                        }
                        case 2:
                        {
                            swimming.Style = SwimmingStyle.Breaststroke;
                            break;
                        }
                        case 3:
                        {
                            swimming.Style = SwimmingStyle.Butterfly;
                            break;
                        }
                        case 4:
                        {
                            swimming.Style = SwimmingStyle.WaterAerobics;
                            break;
                        }
                    }
                    if (tmpStyle < 1 || tmpStyle > 4)
                    {
                        throw new ArgumentException("Необходимо выбрать" +
                            " стиль плавания только из представленного" +
                            " списка");
                    }

                }), "стиль плавания"),

            };

            IterateList(actionList);

            return swimming;
        }

        /// <summary>
        /// Метод добавления вида упражнения: бег.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public static Running AddingRunning()
        {
            var running = new Running();

            var actionList = new List<(Action, string)>
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
                    _ = int.TryParse(Console.ReadLine(), 
                        out int tmpIntensity);
                    switch (tmpIntensity)
                    {
                        //BUG: + 
                        case 1:
                        {
                            running.Intensity = RunningIntensity.Minimum;
                            break;
                        }
                        case 2:
                        {
                            running.Intensity = RunningIntensity.Weak;
                            break;
                        }
                        case 3:
                        {
                            running.Intensity = RunningIntensity.Medium;
                            break;
                        }
                        case 4:
                        {
                            running.Intensity = RunningIntensity.High;
                            break;
                        }
                        case 5:
                        {
                            running.Intensity = RunningIntensity.Extra;
                            break;
                        }
                    }
                    if (tmpIntensity < 1 || tmpIntensity > 5)
                    {
                        throw new ArgumentException("Необходимо выбрать" +
                            " интенсивность бега только из представленного" +
                            " списка");
                    }

                }), "интенсивность бега"),

            };

            IterateList(actionList);

            return running;
        }

        /// <summary>
        /// Метод добавления вида упражнения: жим штанги.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public static BarbellPress AddingBarbellPress()
        {
            var barbellPress = new BarbellPress();

            var actionList = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите вес человека, кг: ");
                    barbellPress.Weight = ReadFromConsoleAndParse();
                }), "вес человека"),

                (new Action(() =>
                {
                    Console.Write("Введите количество повторений: ");
                    barbellPress.NumerRepetitions = 
                    (int)ReadFromConsoleAndParse();
                }), "количество повторений"),

            };

            IterateList(actionList);

            return barbellPress;
        }

        //TODO: XML +
        /// <summary>
        /// Перебор action при вводе вида упражнения.
        /// </summary>
        /// <param name="actionList"></param>
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
            return double.Parse(CheckString
                (Console.ReadLine()).Replace('.', ','));
        }

        /// <summary>
        /// Проверка на ввод числа
        /// </summary>
        public static string CheckString(string value)
        {
            Regex checkString = new(@"\d");

            if (!checkString.IsMatch(value))
            {
                throw new ArgumentException("Введите число!");
            }
            return value;
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
