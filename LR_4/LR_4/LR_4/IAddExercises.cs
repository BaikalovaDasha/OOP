using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_4
{
    /// <summary>
    /// Интерфейс добавления упражнения.
    /// </summary>
    internal interface IAddExercises
    {
        /// <summary>
        /// Метод добавления упражнения.
        /// </summary>
        /// <returns></returns>
        public abstract ExercisesBase AddExercises();
    }
}
