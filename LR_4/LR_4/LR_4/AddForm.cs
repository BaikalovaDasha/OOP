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
        /// Событие добавления упражнения.
        /// </summary>
        public EventHandler<EventArgs> ExercisesAdded;

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
        /// Форма добавления упражнения.
        /// </summary>
        public AddForm()
        {
            InitializeComponent();

            string[] typeExercises = { "Бег", "Плавание", "Жим штанги лёжа" };

            comboBoxExercises.Items.AddRange(new string[]
                 { typeExercises[0], typeExercises[1], typeExercises[2] });

            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            {
                {typeExercises[0], addRunningUserControl1},

            };
        }

        /// <summary>
        /// Метод загрузки формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddForm_Load(object sender, EventArgs e)
        {
            addRunningUserControl1.Visible = false;
        }

        /// <summary>
        /// Рандом упражнений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadnomButton_Click(object sender, EventArgs e)
        {
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
            catch (Exception ex)
            {
                MessageBox.Show("Введено некорректное значение!\n",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message);

            }
        }
    }
}
