﻿namespace LR_4
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
            Style = new ComboBox();
            label_Style = new Label();
            label1 = new Label();
            Time = new TextBox();
            label_Time = new Label();
            label2 = new Label();
            Weight = new TextBox();
            label_Weight = new Label();
            SuspendLayout();
            // 
            // Style
            // 
            Style.DropDownStyle = ComboBoxStyle.DropDownList;
            Style.FormattingEnabled = true;
            Style.Location = new Point(159, 102);
            Style.Name = "Style";
            Style.Size = new Size(169, 28);
            Style.TabIndex = 26;
            Style.SelectedIndexChanged += Swimming_SelectedIndexChanged;
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
            // Time
            // 
            Time.Location = new Point(159, 60);
            Time.Name = "Time";
            Time.Size = new Size(125, 27);
            Time.TabIndex = 23;
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
            Weight.KeyPress += Weight_KeyPress;
            // 
            // Weight
            // 
            Weight.Location = new Point(159, 19);
            Weight.Name = "Weight";
            Weight.Size = new Size(125, 27);
            Weight.TabIndex = 20;
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
            Controls.Add(Style);
            Controls.Add(label_Style);
            Controls.Add(label1);
            Controls.Add(Time);
            Controls.Add(label_Time);
            Controls.Add(label2);
            Controls.Add(Weight);
            Controls.Add(label_Weight);
            Name = "AddSwimmingUserControl";
            Size = new Size(340, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Style;
        private Label label_Style;
        private Label label1;
        private TextBox Time;
        private Label label_Time;
        private Label label2;
        private TextBox Weight;
        private Label label_Weight;
    }
}
