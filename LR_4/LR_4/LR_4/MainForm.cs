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
using System.Xml.Serialization;

namespace LR_4
{
    /// <summary>
    /// Основная форма.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список упражнений.
        /// </summary>
        private BindingList<ExercisesBase> _exercisesList = new();

        /// <summary>
        /// Отфильтрованый список
        /// </summary>
        private BindingList<ExercisesBase> _filteredList = new();

        /// <summary>
        /// Для файлов.
        /// </summary>
        private readonly XmlSerializer _serializer = new(typeof(BindingList<ExercisesBase>));

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

        /// <summary>
        /// Событие удаление упражнения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CleanListButton_Click_Click(object sender, EventArgs e)
        {
            var countOfRows = dataGridView1.SelectedRows.Count;
            for (int i = 0; i < countOfRows; i++)
            {
                _exercisesList.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// Действия при загрузке формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
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

        /// <summary>
        /// Событие при генерации случайного упражнения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Random_Click(object sender, EventArgs e)
        {
            _exercisesList.Add(RandomExercises.GetRandomExercises());

        }

        /// <summary>
        /// Кнопка открытия фильтра.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_FiltrExercises_Click(object sender, EventArgs e)
        {
            var newFilterForm = new FilterForm(_exercisesList);
            newFilterForm.Show();
            newFilterForm.ExercisesFiltered += (sender, exercisesEventArgs) =>
            {
                dataGridView1.DataSource = ((ExercisesListEventArgs)exercisesEventArgs).ExercisesList;
                _filteredList = ((ExercisesListEventArgs)exercisesEventArgs).ExercisesList;
                button_Random.Enabled = false;
            };
        }

        /// <summary>
        /// Сброс фильтра.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_CleanFilter_Click(object sender, EventArgs e)
        {
            CreateTable(_exercisesList, dataGridView1);
        }

        /// <summary>
        /// Открытие файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripLabel_OpenFileBurron_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы (*.gplw)|*.gplw"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var path = openFileDialog.FileName.ToString();
            try
            {
                using (var file = new StreamReader(path))
                {
                    _exercisesList = (BindingList<ExercisesBase>)_serializer.Deserialize(file);
                }

                dataGridView1.DataSource = _exercisesList;
                dataGridView1.CurrentCell = null;
                MessageBox.Show("Файл успешно загружен.", "Загрузка завершена",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось загрузить файл.\n" +
                    "Файл повреждён или не соответствует формату.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение списка в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripLabel_SaveFileButton_Click(object sender, EventArgs e)
        {
            if (_exercisesList.Count == 0)
            {
                MessageBox.Show("Отсутствуют данные для сохранения.",
                    "Данные не сохранены", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Файлы (*.gplw)|*.gplw"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName.ToString();
                using (FileStream file = File.Create(path))
                {
                    _serializer.Serialize(file, _exercisesList);
                }
                MessageBox.Show("Файл успешно сохранён.",
                    "Сохранение завершено", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
