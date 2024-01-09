using model;
using model.Exercises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_4
{
    //два варианта фильтрации
    /// <summary>
    /// Форма фильтрации.
    /// </summary>
    public partial class FilterForm : Form
    {
        /// <summary>
        /// Лист фильтруемых упражнений
        /// </summary>
        private readonly BindingList<ExercisesBase> _listExercises;

        /// <summary>
        /// Лист отфильтрованных упражнений
        /// </summary>
        private BindingList<ExercisesBase> _listExercisesFilter;

        /// <summary>
        /// Обработчик события.
        /// </summary>
        public EventHandler<EventArgs> ExercisesFiltered;

        /// <summary>
        /// Форма фильтрации
        /// </summary>
        /// <param name="exercises"></param>
        public FilterForm(BindingList<ExercisesBase> exercises)
        {
            InitializeComponent();
            _listExercises = exercises;

            MaximizeBox = false;
        }

        /// <summary>
        /// Кнопка поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            _listExercisesFilter = new BindingList<ExercisesBase>();

            int count = 0;
            if (!checkBox_BarbellPress.Checked
                && !checkBox_Running.Checked
                && !checkBox_Swimming.Checked)
            {
                MessageBox.Show("Вы забыли указать упражнение!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ExercisesBase exercises in _listExercises)
            {

                switch (exercises)
                {
                    case BarbellPress when checkBox_BarbellPress.Checked:
                    case Running when checkBox_Running.Checked:
                    case Swimming when checkBox_Swimming.Checked:
                    { 
                        count++;
                            _listExercisesFilter.Add(exercises);
                        break;
                    }
                }
            }

            ExercisesListEventArgs eventArgs;

            if (count > 0)
            {
                eventArgs = new ExercisesListEventArgs(_listExercisesFilter);
            }
            else
            {
                MessageBox.Show("Нет упражнений удовлетворяющих фильтру!",
                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _ = new ExercisesListEventArgs(_listExercisesFilter);
                return;
            }

            ExercisesFiltered?.Invoke(this, eventArgs);
            Close();
        }
    }
}