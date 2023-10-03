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
            label_ChoseExercises = new Label();
            comboBoxExercises = new ComboBox();
            RadnomButton = new Button();
            groupBox_ParametrsExercises = new GroupBox();
            addBarbellPressUserControl1 = new AddBarbellPressUserControl();
            addSwimmingUserControl1 = new AddSwimmingUserControl();
            addRunningUserControl1 = new AddRunningUserControl();
            OK = new Button();
            groupBox_ParametrsExercises.SuspendLayout();
            SuspendLayout();
            // 
            // label_ChoseExercises
            // 
            label_ChoseExercises.AutoSize = true;
            label_ChoseExercises.Location = new Point(12, 22);
            label_ChoseExercises.Name = "label_ChoseExercises";
            label_ChoseExercises.Size = new Size(169, 20);
            label_ChoseExercises.TabIndex = 0;
            label_ChoseExercises.Text = "Выберите упражнение";
            // 
            // comboBoxExercises
            // 
            comboBoxExercises.DropDownStyle = ComboBoxStyle.DropDownList;
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
            // 
            // groupBox_ParametrsExercises
            // 
            groupBox_ParametrsExercises.Controls.Add(addBarbellPressUserControl1);
            groupBox_ParametrsExercises.Controls.Add(addSwimmingUserControl1);
            groupBox_ParametrsExercises.Controls.Add(addRunningUserControl1);
            groupBox_ParametrsExercises.Location = new Point(12, 89);
            groupBox_ParametrsExercises.Name = "groupBox_ParametrsExercises";
            groupBox_ParametrsExercises.Size = new Size(381, 180);
            groupBox_ParametrsExercises.TabIndex = 3;
            groupBox_ParametrsExercises.TabStop = false;
            groupBox_ParametrsExercises.Text = "Параметры упражнений";
            // 
            // addBarbellPressUserControl1
            // 
            addBarbellPressUserControl1.Location = new Point(6, 26);
            addBarbellPressUserControl1.Name = "addBarbellPressUserControl1";
            addBarbellPressUserControl1.Size = new Size(369, 148);
            addBarbellPressUserControl1.TabIndex = 2;
            // 
            // addSwimmingUserControl1
            // 
            addSwimmingUserControl1.Location = new Point(24, 24);
            addSwimmingUserControl1.Name = "addSwimmingUserControl1";
            addSwimmingUserControl1.Size = new Size(351, 148);
            addSwimmingUserControl1.TabIndex = 1;
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
            OK.Enabled = false;
            OK.Location = new Point(12, 285);
            OK.Name = "OK";
            OK.Size = new Size(381, 29);
            OK.TabIndex = 4;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(405, 336);
            Controls.Add(OK);
            Controls.Add(RadnomButton);
            Controls.Add(groupBox_ParametrsExercises);
            Controls.Add(comboBoxExercises);
            Controls.Add(label_ChoseExercises);
            Name = "AddForm";
            Text = "Добавление упражения";
            Load += AddForm_Load;
            groupBox_ParametrsExercises.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_ChoseExercises;
        private ComboBox comboBoxExercises;
        private Button RadnomButton;
        private GroupBox groupBox_ParametrsExercises;
        private Button OK;
        private AddRunningUserControl addRunningUserControl1;
        private AddSwimmingUserControl addSwimmingUserControl1;
        private AddBarbellPressUserControl addBarbellPressUserControl1;
    }
}