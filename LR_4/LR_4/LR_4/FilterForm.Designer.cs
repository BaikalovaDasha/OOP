namespace LR_4
{
    partial class FilterForm
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
            checkBox_BarbellPress = new CheckBox();
            groupBox_Filter = new GroupBox();
            checkBox_Running = new CheckBox();
            checkBox_Swimming = new CheckBox();
            button_ShowFiltr = new Button();
            groupBox_Filter.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox_BarbellPress
            // 
            checkBox_BarbellPress.AutoSize = true;
            checkBox_BarbellPress.Location = new Point(6, 26);
            checkBox_BarbellPress.Name = "checkBox_BarbellPress";
            checkBox_BarbellPress.Size = new Size(157, 24);
            checkBox_BarbellPress.TabIndex = 0;
            checkBox_BarbellPress.Text = "Жим штанги лёжа";
            checkBox_BarbellPress.UseVisualStyleBackColor = true;
            // 
            // groupBox_Filter
            // 
            groupBox_Filter.Controls.Add(checkBox_Swimming);
            groupBox_Filter.Controls.Add(checkBox_Running);
            groupBox_Filter.Controls.Add(checkBox_BarbellPress);
            groupBox_Filter.Location = new Point(29, 12);
            groupBox_Filter.Name = "groupBox_Filter";
            groupBox_Filter.Size = new Size(172, 117);
            groupBox_Filter.TabIndex = 1;
            groupBox_Filter.TabStop = false;
            groupBox_Filter.Text = "Найти упражнение";
            // 
            // checkBox_Running
            // 
            checkBox_Running.AutoSize = true;
            checkBox_Running.Location = new Point(6, 56);
            checkBox_Running.Name = "checkBox_Running";
            checkBox_Running.Size = new Size(54, 24);
            checkBox_Running.TabIndex = 1;
            checkBox_Running.Text = "Бег";
            checkBox_Running.UseVisualStyleBackColor = true;
            // 
            // checkBox_Swimming
            // 
            checkBox_Swimming.AutoSize = true;
            checkBox_Swimming.Location = new Point(6, 86);
            checkBox_Swimming.Name = "checkBox_Swimming";
            checkBox_Swimming.Size = new Size(100, 24);
            checkBox_Swimming.TabIndex = 2;
            checkBox_Swimming.Text = "Плавание";
            checkBox_Swimming.UseVisualStyleBackColor = true;
            // 
            // button_ShowFiltr
            // 
            button_ShowFiltr.Location = new Point(29, 135);
            button_ShowFiltr.Name = "button_ShowFiltr";
            button_ShowFiltr.Size = new Size(172, 29);
            button_ShowFiltr.TabIndex = 2;
            button_ShowFiltr.Text = "Показать";
            button_ShowFiltr.UseVisualStyleBackColor = true;
            button_ShowFiltr.Click += ButtonFilter_Click;
            // 
            // FiltrForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(236, 181);
            Controls.Add(button_ShowFiltr);
            Controls.Add(groupBox_Filter);
            Name = "FiltrForm";
            Text = "Фильтр";
            groupBox_Filter.ResumeLayout(false);
            groupBox_Filter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBox_BarbellPress;
        private GroupBox groupBox_Filter;
        private CheckBox checkBox_Swimming;
        private CheckBox checkBox_Running;
        private Button button_ShowFiltr;
    }
}