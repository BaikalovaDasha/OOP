namespace LR_4
{
    partial class AddForm
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 0;
            label1.Text = "Выберите упражнение";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 28);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(207, 45);
            button1.Name = "button1";
            button1.Size = new Size(189, 29);
            button1.TabIndex = 2;
            button1.Text = "Случайное упражнение";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 180);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры упражнений";
            // 
            // button2
            // 
            button2.Location = new Point(12, 285);
            button2.Name = "button2";
            button2.Size = new Size(189, 29);
            button2.TabIndex = 4;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(207, 285);
            button3.Name = "button3";
            button3.Size = new Size(189, 29);
            button3.TabIndex = 5;
            button3.Text = "Отменить";
            button3.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 336);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "Добавление упражения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button3;
    }
}