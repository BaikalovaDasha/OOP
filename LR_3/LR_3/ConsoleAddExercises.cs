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
        /// Метод добавления вида упражнения.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public static Swimming AddingSwimming()
        {
            var swimming = new Swimming();

            var action= new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.WriteLine("Введите вес человека, кг: ");
                    swimming.Weight = ReadFromConsoleAndParse();
                }), "вес человека"),

                (new Action(() =>
                {
                    Console.WriteLine("Введите время плавания, мин: ");
                    swimming.Time = ReadFromConsoleAndParse();
                }), "время плавания"),
                (new Action(() =>
                {
                    Console.WriteLine("Выберите стиль плавания (1 - кроль, " +
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

            foreach (var act in action)
            {
                ActionHandler(act.Item1, act.Item2);
            }
            return swimming;
        }

        /// <summary>
        /// Чтение с консоли и преобразование в double
        /// </summary>
        public static double ReadFromConsoleAndParse()
        {
            return double.Parse(Console.ReadLine().Replace('.', ','));
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
                    Console.WriteLine($"Ошибка: {exception.Message}. " +
                        $"Введите {propertyname} ещё раз!");
                }
            }
        }
    }
}
