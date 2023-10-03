namespace LR_4
{
    partial class AddSwimmingUserControl
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
            comboBox_Style = new ComboBox();
            label_Style = new Label();
            label1 = new Label();
            textBox_Time = new TextBox();
            label_Time = new Label();
            label2 = new Label();
            textBox_Weight = new TextBox();
            label_Weight = new Label();
            SuspendLayout();
            // 
            // comboBox_Style
            // 
            comboBox_Style.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Style.FormattingEnabled = true;
            comboBox_Style.Location = new Point(159, 102);
            comboBox_Style.Name = "comboBox_Style";
            comboBox_Style.Size = new Size(169, 28);
            comboBox_Style.TabIndex = 26;
            comboBox_Style.SelectedIndexChanged += Swimming_SelectedIndexChanged;
            // 
            // label_Style
            // 
            label_Style.AutoSize = true;
            label_Style.Location = new Point(3, 110);
            label_Style.Name = "label_Style";
            label_Style.Size = new Size(120, 20);
            label_Style.TabIndex = 25;
            label_Style.Text = "Стиль плавания";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 67);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 24;
            label1.Text = "мин";
            // 
            // textBox_Time
            // 
            textBox_Time.Location = new Point(159, 60);
            textBox_Time.Name = "textBox_Time";
            textBox_Time.Size = new Size(125, 27);
            textBox_Time.TabIndex = 23;
            // 
            // label_Time
            // 
            label_Time.AutoSize = true;
            label_Time.Location = new Point(3, 67);
            label_Time.Name = "label_Time";
            label_Time.Size = new Size(125, 20);
            label_Time.TabIndex = 22;
            label_Time.Text = "Время плавания";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 26);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 21;
            label2.Text = "кг";
            // 
            // textBox_Weight
            // 
            textBox_Weight.Location = new Point(159, 19);
            textBox_Weight.Name = "textBox_Weight";
            textBox_Weight.Size = new Size(125, 27);
            textBox_Weight.TabIndex = 20;
            textBox_Weight.KeyPress += Weight_KeyPress;
            // 
            // label_Weight
            // 
            label_Weight.AutoSize = true;
            label_Weight.Location = new Point(3, 26);
            label_Weight.Name = "label_Weight";
            label_Weight.Size = new Size(101, 20);
            label_Weight.TabIndex = 19;
            label_Weight.Text = "Вес человека";
            // 
            // AddSwimmingUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox_Style);
            Controls.Add(label_Style);
            Controls.Add(label1);
            Controls.Add(textBox_Time);
            Controls.Add(label_Time);
            Controls.Add(label2);
            Controls.Add(textBox_Weight);
            Controls.Add(label_Weight);
            Name = "AddSwimmingUserControl";
            Size = new Size(340, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Style;
        private Label label_Style;
        private Label label1;
        private TextBox textBox_Time;
        private Label label_Time;
        private Label label2;
        private TextBox textBox_Weight;
        private Label label_Weight;
    }
}
