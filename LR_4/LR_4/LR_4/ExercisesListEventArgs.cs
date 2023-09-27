using model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_4
{
    internal class ExercisesListEventArgs : EventArgs
    {
        /// <summary>
        /// Список упражнений.
        /// </summary>
        public BindingList<ExercisesBase> ExercisesList { get; private set; }

        /// <summary>
        /// Конструктор события добавления упражнения.
        /// </summary>
        /// <param name="figure"></param>
        public ExercisesListEventArgs(BindingList<ExercisesBase> exercises)
        {
            ExercisesList = exercises;
        }
    }
}
