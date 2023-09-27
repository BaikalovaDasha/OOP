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
    public partial class AddForm : Form
    {
        /// <summary>
        /// Словарь UserControls
        /// </summary>
        private readonly Dictionary<string, UserControl>
            _comboBoxToUserControl;

        /// <summary>
        /// Метка используемого UserControl.
        /// </summary>
        private UserControl userControl;

        /// <summary>
        /// Событие добавления фигуры.
        /// </summary>
        public EventHandler<EventArgs> FigureAdded;

        public AddForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Рандом упражнений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadnomButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            comboBoxExercises.SelectedIndex = random.Next(0, 3);

            foreach (TextBox textbox in userControl.Controls.OfType<TextBox>())
            {
                if (textbox.Visible && String.IsNullOrEmpty(textbox.Text))
                {
                    textbox.Text = random.Next(1, 100).ToString();
                }
            }
        }

        /// <summary>
        /// Выпадающий список. Действие которого выполняется, ...
        /// ... выбрали фигуру из выпадающего списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxExcercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exercisesType = comboBoxExercises.SelectedItem.ToString();
            foreach (var (exercises, userControl) in _comboBoxToUserControl)
            {
                userControl.Visible = false;
                if (exercisesType == exercises)
                {
                    userControl.Visible = true;
                    OK.Enabled = true;
                    this.userControl = userControl;
                }
            }

        }

        /// <summary>
        /// Закрыть.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                var currentExercisesControlName = comboBoxExercises.SelectedItem.ToString();
                var currentExercisesControl = _comboBoxToUserControl[currentExercisesControlName];
                var eventArgs = new ExercisesEventArgs(((IAddExercises)currentExercisesControl).AddExercises());
                ExercisesAdded?.Invoke(this, eventArgs);
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение!\n" +
                    "Введите одно положительное десятичное число" +
                    " в каждое текстовое поле.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
