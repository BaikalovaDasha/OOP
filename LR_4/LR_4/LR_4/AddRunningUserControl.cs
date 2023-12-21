using model;
using model.Exercises;
using System;
using System.Collections;
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
    /// Добавление нового упражнения (бега).
    /// </summary>
    public partial class AddRunningUserControl : UserControl, IAddExercises
    {

        /// <summary>
        /// Словарь UserControls
        /// </summary>
        private readonly Dictionary<string, RunningIntensity>
            _comboBoxIntensity;

        /// <summary>
        /// Добавление бега.
        /// </summary>
        public AddRunningUserControl()
        {
            InitializeComponent();

            string[] runningIntensity = { "Минимальная", "Слабая", "Средняя",
                "Высокая", "Максимальная" };

            comboBox_Intensity.Items.AddRange(new string[]
                 { runningIntensity[0], runningIntensity[1],
                     runningIntensity[2], runningIntensity[3],
                     runningIntensity[4]});

            _comboBoxIntensity = new Dictionary<string, RunningIntensity>()
            {
                {runningIntensity[0], RunningIntensity.Minimum},
                {runningIntensity[1], RunningIntensity.Weak},
                {runningIntensity[2], RunningIntensity.Medium},
                {runningIntensity[3], RunningIntensity.High},
                {runningIntensity[4], RunningIntensity.Extra}
            };

        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlText.CheckInput(e);
        }

        /// <summary>
        /// Переменная для записи интенсивности  бега.
        /// </summary>
        private RunningIntensity _runningIntensity;

        /// <summary>
        /// Метод присваивающий полю интенсивности значение comboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Intensity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string intensity = comboBox_Intensity.SelectedItem.ToString();

            foreach (var (item, runningIntensity) in _comboBoxIntensity)
            {
                if (intensity == item)
                {
                    _runningIntensity = runningIntensity;
                }
            }
        }

        /// <summary>
        /// Метод добавления фигур.
        /// </summary>
        /// <returns></returns>
        public ExercisesBase AddExercises()
        {
            if (comboBox_Intensity.SelectedIndex < 0)
            {
                throw new ArgumentException("Не выбрана интенсивность бега.");
            }
            var running = new Running
            {
                Weight = ControlText.CheckNumber(textBox_Weight.Text),
                Distance = ControlText.CheckNumber(textBox_Distance.Text),
                Intensity = _runningIntensity,
            };

            return running;
        }
    }
}
