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
    /// <summary>
    /// Добавление нового упражнения (жим штанги).
    /// </summary>
    public partial class AddBarbellPressUserControl : UserControl, IAddExercises
    {
        /// <summary>
        /// Добавление жима штанги.
        /// </summary>
        public AddBarbellPressUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlText.CheckInput(e);
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightRod_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlText.CheckInput(e);
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberRepetitions_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlText.CheckInput(e);
        }

        /// <summary>
        /// Метод добавления фигур.
        /// </summary>
        /// <returns></returns>
        public ExercisesBase AddExercises()
        {
            var barbellPress = new BarbellPress
            {
                Weight = ControlText.CheckNumber(textBox_Weight.Text),
                WeightRod = ControlText.CheckNumber(textBox_WeightRod.Text),
                NumerRepetitions = (int)ControlText.CheckNumber(textBox_NumberRepetitions.Text)
            };
            return barbellPress;
        }
    }
}
