namespace LR_4
{
    partial class AddRunningUserControl
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
            comboBox_Intensity = new ComboBox();
            label_Intensity = new Label();
            label_distance_ = new Label();
            textBox_Distance = new TextBox();
            label_Distance = new Label();
            label_weight_ = new Label();
            textBox_Weight = new TextBox();
            label_Weight = new Label();
            SuspendLayout();
            // 
            // comboBox_Intensity
            // 
            comboBox_Intensity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Intensity.FormattingEnabled = true;
            comboBox_Intensity.Location = new Point(176, 100);
            comboBox_Intensity.Name = "comboBox_Intensity";
            comboBox_Intensity.Size = new Size(169, 28);
            comboBox_Intensity.TabIndex = 18;
            comboBox_Intensity.SelectedIndexChanged += Intensity_SelectedIndexChanged;
            // 
            // label_Intensity
            // 
            label_Intensity.AutoSize = true;
            label_Intensity.Location = new Point(20, 108);
            label_Intensity.Name = "label_Intensity";
            label_Intensity.Size = new Size(150, 20);
            label_Intensity.TabIndex = 17;
            label_Intensity.Text = "Интенсивность бега";
            // 
            // label_distance_
            // 
            label_distance_.AutoSize = true;
            label_distance_.Location = new Point(307, 65);
            label_distance_.Name = "label_distance_";
            label_distance_.Size = new Size(27, 20);
            label_distance_.TabIndex = 16;
            label_distance_.Text = "км";
            // 
            // textBox_Distance
            // 
            textBox_Distance.Location = new Point(176, 58);
            textBox_Distance.Name = "textBox_Distance";
            textBox_Distance.Size = new Size(125, 27);
            textBox_Distance.TabIndex = 15;
            textBox_Distance.KeyPress += ControlValue_KeyPress;
            // 
            // label_Distance
            // 
            label_Distance.AutoSize = true;
            label_Distance.Location = new Point(20, 65);
            label_Distance.Name = "label_Distance";
            label_Distance.Size = new Size(88, 20);
            label_Distance.TabIndex = 14;
            label_Distance.Text = "Расстояние";
            // 
            // label_weight_
            // 
            label_weight_.AutoSize = true;
            label_weight_.Location = new Point(307, 24);
            label_weight_.Name = "label_weight_";
            label_weight_.Size = new Size(22, 20);
            label_weight_.TabIndex = 13;
            label_weight_.Text = "кг";
            // 
            // textBox_Weight
            // 
            textBox_Weight.Location = new Point(176, 17);
            textBox_Weight.Name = "textBox_Weight";
            textBox_Weight.Size = new Size(125, 27);
            textBox_Weight.TabIndex = 12;
            textBox_Weight.KeyPress += ControlValue_KeyPress;
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
            // AddRunningUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox_Intensity);
            Controls.Add(label_Intensity);
            Controls.Add(label_distance_);
            Controls.Add(textBox_Distance);
            Controls.Add(label_Distance);
            Controls.Add(label_weight_);
            Controls.Add(textBox_Weight);
            Controls.Add(label_Weight);
            Name = "AddRunningUserControl";
            Size = new Size(364, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Intensity;
        private Label label_Intensity;
        private Label label_distance_;
        private TextBox textBox_Distance;
        private Label label_Distance;
        private Label label_weight_;
        private TextBox textBox_Weight;
        private Label label_Weight;
    }
}
