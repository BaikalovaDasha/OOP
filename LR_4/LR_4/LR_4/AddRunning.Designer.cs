namespace LR_4
{
    partial class AddRunning
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label_Time = new Label();
            label2 = new Label();
            Weight = new TextBox();
            label_Weight = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(176, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 28);
            comboBox1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 108);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 17;
            label4.Text = "Интенсивность бега";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 65);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 16;
            label1.Text = "км";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 15;
            // 
            // label_Time
            // 
            label_Time.AutoSize = true;
            label_Time.Location = new Point(20, 65);
            label_Time.Name = "label_Time";
            label_Time.Size = new Size(88, 20);
            label_Time.TabIndex = 14;
            label_Time.Text = "Расстояние";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 24);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 13;
            label2.Text = "кг";
            // 
            // Weight
            // 
            Weight.Location = new Point(176, 17);
            Weight.Name = "Weight";
            Weight.Size = new Size(125, 27);
            Weight.TabIndex = 12;
            // 
            // label_Weight
            // 
            label_Weight.AutoSize = true;
            label_Weight.Location = new Point(20, 24);
            label_Weight.Name = "label_Weight";
            label_Weight.Size = new Size(101, 20);
            label_Weight.TabIndex = 11;
            label_Weight.Text = "Вес человека";
            // 
            // AddRunning
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label_Time);
            Controls.Add(label2);
            Controls.Add(Weight);
            Controls.Add(label_Weight);
            Name = "AddRunning";
            Size = new Size(388, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label4;
        private Label label1;
        private TextBox textBox1;
        private Label label_Time;
        private Label label2;
        private TextBox Weight;
        private Label label_Weight;
    }
}
