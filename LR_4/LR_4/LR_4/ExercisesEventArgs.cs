using model;
using model.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_4
{
    /// <summary>
    /// Класс событий.
    /// </summary>
    public class ExercisesEventArgs : EventArgs
    {
        /// <summary>
        /// Упражнение.
        /// </summary>
        public ExercisesBase Exercises { get; private set; }

        /// <summary>
        /// Конструктор события добавления упражнения.
        /// </summary>
        /// <param name="exercises"></param>
        public ExercisesEventArgs(ExercisesBase exercises)
        {
            Exercises = exercises;
        }
    }
}
