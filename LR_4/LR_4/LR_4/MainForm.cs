using model;
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
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список упражнений.
        /// </summary>
        private BindingList<ExercisesBase> _exercisesList = new();

        /// <summary>
        /// Основная форма.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление нового упражнения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddExercisesButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new();

            addForm.ExercisesAdded += (sender, ExercisesEventArgs) =>
            {
                _exercisesList.Add(((ExercisesEventArgs)ExercisesEventArgs).Exercises);
            };
            addForm.ShowDialog(this);
        }

        private void CleanListButton_Click_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Действия при загрузке формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Выделение памяти
            _exercisesList = new BindingList<ExercisesBase>();
            CreateTable(_exercisesList, dataGridView1);
        }

        /// <summary>
        /// Создание таблицы DataGrid.
        /// </summary>
        /// <param name="exercises">Список упражнений.</param>
        /// <param name="dataGridView">таблица упражнений.</param>
        public static void CreateTable(BindingList<ExercisesBase> exercises,
            DataGridView dataGridView)
        {
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.RowHeadersVisible = false;

            var source = new BindingSource(exercises, null);
            dataGridView.DataSource = source;

            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

        }
    }
}
