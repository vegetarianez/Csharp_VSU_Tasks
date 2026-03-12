namespace task2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            typeField = new ComboBox();
            altitudeField = new TextBox();
            label1 = new Label();
            label2 = new Label();
            OutputField = new TextBox();
            label3 = new Label();
            TakeOffButton = new Button();
            LandingButton = new Button();
            CreateMachineButton = new Button();
            SuspendLayout();
            // 
            // typeField
            // 
            typeField.FormattingEnabled = true;
            typeField.Location = new Point(157, 38);
            typeField.Name = "typeField";
            typeField.Size = new Size(131, 23);
            typeField.TabIndex = 1;
            typeField.SelectedIndexChanged += TypeField_SelectedIndexChanged;
            // 
            // altitudeField
            // 
            altitudeField.Location = new Point(10, 38);
            altitudeField.Name = "altitudeField";
            altitudeField.Size = new Size(141, 23);
            altitudeField.TabIndex = 2;
            altitudeField.TextChanged += AltitudeField_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 3;
            label1.Text = "Длина взлётной полосы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 9);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 4;
            label2.Text = "Тип воздушного судна";
            // 
            // OutputField
            // 
            OutputField.Location = new Point(10, 113);
            OutputField.Name = "OutputField";
            OutputField.Size = new Size(278, 23);
            OutputField.TabIndex = 5;
            OutputField.TextChanged += OutputField_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 95);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Вывод";
            // 
            // TakeOffButton
            // 
            TakeOffButton.Location = new Point(10, 69);
            TakeOffButton.Name = "TakeOffButton";
            TakeOffButton.Size = new Size(141, 23);
            TakeOffButton.TabIndex = 7;
            TakeOffButton.Text = "Взлететь";
            TakeOffButton.UseVisualStyleBackColor = true;
            TakeOffButton.Click += TakeOffButton_Click;
            // 
            // LandingButton
            // 
            LandingButton.Location = new Point(157, 69);
            LandingButton.Name = "LandingButton";
            LandingButton.Size = new Size(131, 23);
            LandingButton.TabIndex = 8;
            LandingButton.Text = "Сесть";
            LandingButton.UseVisualStyleBackColor = true;
            LandingButton.Click += LandingButton_Click;
            // 
            // CreateMachineButton
            // 
            CreateMachineButton.Location = new Point(294, 37);
            CreateMachineButton.Name = "CreateMachineButton";
            CreateMachineButton.Size = new Size(75, 23);
            CreateMachineButton.TabIndex = 9;
            CreateMachineButton.Text = "Создать";
            CreateMachineButton.UseVisualStyleBackColor = true;
            CreateMachineButton.Click += CreateMachineButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateMachineButton);
            Controls.Add(LandingButton);
            Controls.Add(TakeOffButton);
            Controls.Add(label3);
            Controls.Add(OutputField);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(altitudeField);
            Controls.Add(typeField);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox typeField;
        private TextBox altitudeField;
        private Label label1;
        private Label label2;
        private TextBox OutputField;
        private Label label3;
        private Button TakeOffButton;
        private Button LandingButton;
        private Button createButton;
        private Button CreateMachineButton;
    }
}
