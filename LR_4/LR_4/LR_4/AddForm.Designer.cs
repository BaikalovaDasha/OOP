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
            comboBoxExercises = new ComboBox();
            RadnomButton = new Button();
            groupBox1 = new GroupBox();
            addRunningUserControl1 = new AddRunningUserControl();
            OK = new Button();
            Cancel = new Button();
            groupBox1.SuspendLayout();
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
            // comboBoxExercises
            // 
            comboBoxExercises.FormattingEnabled = true;
            comboBoxExercises.Location = new Point(12, 45);
            comboBoxExercises.Name = "comboBoxExercises";
            comboBoxExercises.Size = new Size(189, 28);
            comboBoxExercises.TabIndex = 1;
            comboBoxExercises.SelectedIndexChanged += ComboBoxExcercises_SelectedIndexChanged;
            // 
            // RadnomButton
            // 
            RadnomButton.Location = new Point(207, 45);
            RadnomButton.Name = "RadnomButton";
            RadnomButton.Size = new Size(189, 29);
            RadnomButton.TabIndex = 2;
            RadnomButton.Text = "Случайное упражнение";
            RadnomButton.UseVisualStyleBackColor = true;
            RadnomButton.Click += RadnomButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addRunningUserControl1);
            groupBox1.Location = new Point(12, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 180);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры упражнений";
            // 
            // addRunningUserControl1
            // 
            addRunningUserControl1.Location = new Point(6, 26);
            addRunningUserControl1.Name = "addRunningUserControl1";
            addRunningUserControl1.Size = new Size(369, 148);
            addRunningUserControl1.TabIndex = 0;
            // 
            // OK
            // 
            OK.Location = new Point(12, 285);
            OK.Name = "OK";
            OK.Size = new Size(189, 29);
            OK.TabIndex = 4;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(207, 285);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(189, 29);
            Cancel.TabIndex = 5;
            Cancel.Text = "Отменить";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 336);
            Controls.Add(OK);
            Controls.Add(RadnomButton);
            Controls.Add(Cancel);
            Controls.Add(groupBox1);
            Controls.Add(comboBoxExercises);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "Добавление упражения";
            Load += AddForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxExercises;
        private Button RadnomButton;
        private GroupBox groupBox1;
        private Button OK;
        private Button Cancel;
        private AddRunningUserControl addRunningUserControl1;
    }
}