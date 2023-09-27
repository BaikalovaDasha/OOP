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
            Intensity = new ComboBox();
            label_Intensity = new Label();
            label_distance_ = new Label();
            Distance = new TextBox();
            label_Distance = new Label();
            label_weight_ = new Label();
            Weight = new TextBox();
            label_Weight = new Label();
            SuspendLayout();
            // 
            // Intensity
            // 
            Intensity.FormattingEnabled = true;
            Intensity.Location = new Point(176, 100);
            Intensity.Name = "Intensity";
            Intensity.Size = new Size(169, 28);
            Intensity.TabIndex = 18;
            Intensity.SelectedIndexChanged += Intensity_SelectedIndexChanged;
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
            // Distance
            // 
            Distance.Location = new Point(176, 58);
            Distance.Name = "Distance";
            Distance.Size = new Size(125, 27);
            Distance.TabIndex = 15;
            Distance.KeyPress += Distance_KeyPress;
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
            // Weight
            // 
            Weight.Location = new Point(176, 17);
            Weight.Name = "Weight";
            Weight.Size = new Size(125, 27);
            Weight.TabIndex = 12;
            Weight.KeyPress += Weight_KeyPress;
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
            Controls.Add(Intensity);
            Controls.Add(label_Intensity);
            Controls.Add(label_distance_);
            Controls.Add(Distance);
            Controls.Add(label_Distance);
            Controls.Add(label_weight_);
            Controls.Add(Weight);
            Controls.Add(label_Weight);
            Name = "AddRunningUserControl";
            Size = new Size(364, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Intensity;
        private Label label_Intensity;
        private Label label_distance_;
        private TextBox Distance;
        private Label label_Distance;
        private Label label_weight_;
        private TextBox Weight;
        private Label label_Weight;
    }
}
