namespace LR_4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            AddExercisesButton = new Button();
            CleanListButton_Click = new Button();
            button_Random = new Button();
            button_FiltrExercises = new Button();
            button_CleanFilter = new Button();
            groupBox1 = new GroupBox();
            toolStrip1 = new ToolStrip();
            toolStripLabel_OpenFileBurron = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel_SaveFileButton = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(722, 396);
            dataGridView1.TabIndex = 0;
            // 
            // AddExercisesButton
            // 
            AddExercisesButton.Location = new Point(12, 483);
            AddExercisesButton.Name = "AddExercisesButton";
            AddExercisesButton.Size = new Size(240, 29);
            AddExercisesButton.TabIndex = 1;
            AddExercisesButton.Text = "Добавить упражнение";
            AddExercisesButton.UseVisualStyleBackColor = true;
            AddExercisesButton.Click += AddExercisesButton_Click;
            // 
            // CleanListButton_Click
            // 
            CleanListButton_Click.Location = new Point(507, 483);
            CleanListButton_Click.Name = "CleanListButton_Click";
            CleanListButton_Click.Size = new Size(240, 29);
            CleanListButton_Click.TabIndex = 2;
            CleanListButton_Click.Text = "Удалить упражнения";
            CleanListButton_Click.UseVisualStyleBackColor = true;
            CleanListButton_Click.Click += CleanListButton_Click_Click;
            // 
            // button_Random
            // 
            button_Random.Location = new Point(259, 483);
            button_Random.Name = "button_Random";
            button_Random.Size = new Size(240, 29);
            button_Random.TabIndex = 3;
            button_Random.Text = "Рандомное упражнение";
            button_Random.UseVisualStyleBackColor = true;
            button_Random.Click += Button_Random_Click;
            // 
            // button_FiltrExercises
            // 
            button_FiltrExercises.Location = new Point(130, 522);
            button_FiltrExercises.Name = "button_FiltrExercises";
            button_FiltrExercises.Size = new Size(240, 29);
            button_FiltrExercises.TabIndex = 4;
            button_FiltrExercises.Text = "Фильтрация упражнений";
            button_FiltrExercises.UseVisualStyleBackColor = true;
            button_FiltrExercises.Click += Button_FiltrExercises_Click;
            // 
            // button_CleanFilter
            // 
            button_CleanFilter.Location = new Point(392, 522);
            button_CleanFilter.Name = "button_CleanFilter";
            button_CleanFilter.Size = new Size(240, 29);
            button_CleanFilter.TabIndex = 5;
            button_CleanFilter.Text = "Сбросить фильтрацию";
            button_CleanFilter.UseVisualStyleBackColor = true;
            button_CleanFilter.Click += Button_CleanFilter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(735, 434);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список упражнений";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel_OpenFileBurron, toolStripSeparator1, toolStripLabel_SaveFileButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(755, 25);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel_OpenFileBurron
            // 
            toolStripLabel_OpenFileBurron.Name = "toolStripLabel_OpenFileBurron";
            toolStripLabel_OpenFileBurron.Size = new Size(45, 22);
            toolStripLabel_OpenFileBurron.Text = "Файл";
            toolStripLabel_OpenFileBurron.Click += ToolStripLabel_OpenFileBurron_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel_SaveFileButton
            // 
            toolStripLabel_SaveFileButton.Name = "toolStripLabel_SaveFileButton";
            toolStripLabel_SaveFileButton.Size = new Size(109, 22);
            toolStripLabel_SaveFileButton.Text = "Сохранить как";
            toolStripLabel_SaveFileButton.Click += ToolStripLabel_SaveFileButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(755, 560);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Controls.Add(button_CleanFilter);
            Controls.Add(button_FiltrExercises);
            Controls.Add(button_Random);
            Controls.Add(CleanListButton_Click);
            Controls.Add(AddExercisesButton);
            Name = "MainForm";
            Text = "Калькулятор килокалорий";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddExercisesButton;
        private Button CleanListButton_Click;
        private Button button_Random;
        private Button button_FiltrExercises;
        private Button button_CleanFilter;
        private GroupBox groupBox1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel_OpenFileBurron;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel_SaveFileButton;
    }
}