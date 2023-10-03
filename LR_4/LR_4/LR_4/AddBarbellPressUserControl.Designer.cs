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
            label_NumberRepetitions = new Label();
            label_distance_ = new Label();
            textBox_WeightRod = new TextBox();
            label_WeightRod = new Label();
            label_weight_ = new Label();
            textBox_Weight = new TextBox();
            label_Weight = new Label();
            textBox_NumberRepetitions = new TextBox();
            SuspendLayout();
            // 
            // label_NumberRepetitions
            // 
            label_NumberRepetitions.AutoSize = true;
            label_NumberRepetitions.Location = new Point(20, 111);
            label_NumberRepetitions.Name = "label_NumberRepetitions";
            label_NumberRepetitions.Size = new Size(179, 20);
            label_NumberRepetitions.TabIndex = 25;
            label_NumberRepetitions.Text = "Количество повторений";
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
            // textBox_WeightRod
            // 
            textBox_WeightRod.Location = new Point(205, 61);
            textBox_WeightRod.Name = "textBox_WeightRod";
            textBox_WeightRod.Size = new Size(125, 27);
            textBox_WeightRod.TabIndex = 23;
            textBox_WeightRod.KeyPress += WeightRod_KeyPress;
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
            // textBox_Weight
            // 
            textBox_Weight.Location = new Point(205, 20);
            textBox_Weight.Name = "textBox_Weight";
            textBox_Weight.Size = new Size(125, 27);
            textBox_Weight.TabIndex = 20;
            textBox_Weight.KeyPress += Weight_KeyPress;
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
            // textBox_NumberRepetitions
            // 
            textBox_NumberRepetitions.Location = new Point(205, 104);
            textBox_NumberRepetitions.Name = "textBox_NumberRepetitions";
            textBox_NumberRepetitions.Size = new Size(125, 27);
            textBox_NumberRepetitions.TabIndex = 26;
            textBox_NumberRepetitions.KeyPress += NumberRepetitions_KeyPress;
            // 
            // AddBarbellPressUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox_NumberRepetitions);
            Controls.Add(label_NumberRepetitions);
            Controls.Add(label_distance_);
            Controls.Add(textBox_WeightRod);
            Controls.Add(label_WeightRod);
            Controls.Add(label_weight_);
            Controls.Add(textBox_Weight);
            Controls.Add(label_Weight);
            Name = "AddBarbellPressUserControl";
            Size = new Size(364, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_NumberRepetitions;
        private Label label_distance_;
        private TextBox textBox_WeightRod;
        private Label label_WeightRod;
        private Label label_weight_;
        private TextBox textBox_Weight;
        private Label label_Weight;
        private TextBox textBox_NumberRepetitions;
    }
}
