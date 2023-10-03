namespace LR_4
{
    partial class AddBarbellPressUserControl
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
            label_Intensity = new Label();
            label_distance_ = new Label();
            WeightRod = new TextBox();
            label_WeightRod = new Label();
            label_weight_ = new Label();
            Weight = new TextBox();
            label_Weight = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label_Intensity
            // 
            label_Intensity.AutoSize = true;
            label_Intensity.Location = new Point(20, 111);
            label_Intensity.Name = "label_Intensity";
            label_Intensity.Size = new Size(179, 20);
            label_Intensity.TabIndex = 25;
            label_Intensity.Text = "Количество повторений";
            // 
            // label_distance_
            // 
            label_distance_.AutoSize = true;
            label_distance_.Location = new Point(336, 68);
            label_distance_.Name = "label_distance_";
            label_distance_.Size = new Size(22, 20);
            label_distance_.TabIndex = 24;
            label_distance_.Text = "кг";
            // 
            // WeightRod
            // 
            WeightRod.Location = new Point(205, 61);
            WeightRod.Name = "WeightRod";
            WeightRod.Size = new Size(125, 27);
            WeightRod.TabIndex = 23;
            // 
            // label_WeightRod
            // 
            label_WeightRod.AutoSize = true;
            label_WeightRod.BackColor = SystemColors.Control;
            label_WeightRod.Location = new Point(20, 68);
            label_WeightRod.Name = "label_WeightRod";
            label_WeightRod.Size = new Size(87, 20);
            label_WeightRod.TabIndex = 22;
            label_WeightRod.Text = "Вес штанги";
            // 
            // label_weight_
            // 
            label_weight_.AutoSize = true;
            label_weight_.Location = new Point(336, 27);
            label_weight_.Name = "label_weight_";
            label_weight_.Size = new Size(22, 20);
            label_weight_.TabIndex = 21;
            label_weight_.Text = "кг";
            // 
            // Weight
            // 
            Weight.Location = new Point(205, 20);
            Weight.Name = "Weight";
            Weight.Size = new Size(125, 27);
            Weight.TabIndex = 20;
            // 
            // label_Weight
            // 
            label_Weight.AutoSize = true;
            label_Weight.Location = new Point(20, 27);
            label_Weight.Name = "label_Weight";
            label_Weight.Size = new Size(101, 20);
            label_Weight.TabIndex = 19;
            label_Weight.Text = "Вес человека";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 26;
            // 
            // AddBarbellPressUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(label_Intensity);
            Controls.Add(label_distance_);
            Controls.Add(WeightRod);
            Controls.Add(label_WeightRod);
            Controls.Add(label_weight_);
            Controls.Add(Weight);
            Controls.Add(label_Weight);
            Name = "AddBarbellPressUserControl";
            Size = new Size(364, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_Intensity;
        private Label label_distance_;
        private TextBox WeightRod;
        private Label label_WeightRod;
        private Label label_weight_;
        private TextBox Weight;
        private Label label_Weight;
        private TextBox textBox1;
    }
}
