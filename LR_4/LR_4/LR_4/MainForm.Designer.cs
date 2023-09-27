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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(540, 181);
            dataGridView1.TabIndex = 0;
            // 
            // AddExercisesButton
            // 
            AddExercisesButton.Location = new Point(12, 275);
            AddExercisesButton.Name = "AddExercisesButton";
            AddExercisesButton.Size = new Size(187, 29);
            AddExercisesButton.TabIndex = 1;
            AddExercisesButton.Text = "Добавить упражнение";
            AddExercisesButton.UseVisualStyleBackColor = true;
            AddExercisesButton.Click += AddExercisesButton_Click;
            // 
            // CleanListButton_Click
            // 
            CleanListButton_Click.Location = new Point(224, 275);
            CleanListButton_Click.Name = "CleanListButton_Click";
            CleanListButton_Click.Size = new Size(187, 29);
            CleanListButton_Click.TabIndex = 2;
            CleanListButton_Click.Text = "Удалить упражнения";
            CleanListButton_Click.UseVisualStyleBackColor = true;
            CleanListButton_Click.Click += CleanListButton_Click_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 324);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(154, 324);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(317, 324);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 226);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список упражнений";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 411);
            Controls.Add(groupBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(CleanListButton_Click);
            Controls.Add(AddExercisesButton);
            Name = "MainForm";
            Text = "Калькулятор килокалорий";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddExercisesButton;
        private Button CleanListButton_Click;
        private Button button3;
        private Button button4;
        private Button button5;
        private GroupBox groupBox1;
        private OpenFileDialog openFileDialog1;
    }
}