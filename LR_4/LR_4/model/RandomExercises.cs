using model.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    /// <summary>
    /// Класс для генерации случайного упражнения
    /// </summary>
    public class RandomExercises
    {
        /// <summary>
        /// Рандомайзер
        /// </summary>
        private static Random _random = new();

        /// <summary>
        /// Сгенирировать случайное упражнение
        /// </summary>
        /// <returns>Сгенерированный объект класса ExercisesBase.</returns>
        public static ExercisesBase GetRandomExercises() 
        {
            var exercisesType = _random.Next(0, 3);

            switch (exercisesType) 
            {
                case 0:
                {
                    return GetRandomBarbellBase();
                }
                case 1:
                {
                    return GetRandomRunning();
                }
                case 2:
                {
                    return GetRandomSwimming();
                }
                default:
                {
                    throw new ArgumentException("Тип упражнения отсутствует.");
                }
            }
        }

        /// <summary>
        /// генерация случайных параметров жима штанги лёжа.
        /// </summary>
        /// <returns>Случайный параллелепипед</returns>
        public static ExercisesBase GetRandomBarbellBase()
        {
            int weight = _random.Next(ExercisesBase.MinWeight, ExercisesBase.MaxWeight);

            var barbellPress = new BarbellPress
            {
                Weight = weight,
                WeightRod = _random.Next(BarbellPress.MinWeghtRod, weight),
                NumerRepetitions = _random.Next(BarbellPress.MinNumerRepetitions,
                BarbellPress.MaxNumerRepetitions)
            };
            return barbellPress;
        }

        /// <summary>
        /// генерация случайных параметров бега.
        /// </summary>
        /// <returns>Случайный параллелепипед</returns>
        public static ExercisesBase GetRandomRunning()
        {

            var running = new Running
            {
                Weight = _random.Next(ExercisesBase.MinWeight, ExercisesBase.MaxWeight),
                Distance = _random.Next(Running.MinDistance, Running.MaxDistance),
                //Intensity
            };
            return running;
        }

        /// <summary>
        /// генерация случайных параметров плавания.
        /// </summary>
        /// <returns>Случайный параллелепипед</returns>
        public static ExercisesBase GetRandomSwimming()
        {

            var swimming = new Swimming
            {
                Weight = _random.Next(ExercisesBase.MinWeight, ExercisesBase.MaxWeight),
                Time = _random.Next(Swimming.MinTime, Swimming.MaxTime),
                //Style
            };
            return swimming;
        }
    }
}
