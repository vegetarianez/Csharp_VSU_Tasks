namespace task1
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
            toDecNumerator = new TextBox();
            toDecDenominator = new TextBox();
            chooseOperation = new ComboBox();
            mathNumerator1 = new TextBox();
            mathDenominator1 = new TextBox();
            mathNumerator2 = new TextBox();
            mathDenominator2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            mathNumeratorOut = new TextBox();
            mathDenominatorOut = new TextBox();
            toDecResult = new TextBox();
            fromDec = new TextBox();
            label4 = new Label();
            fromDecDenominator = new TextBox();
            fromDecNumerator = new TextBox();
            normalizeDenominator = new TextBox();
            normalizeNumerator = new TextBox();
            buttonNormalize = new Button();
            fromDecButton = new Button();
            toDecButton = new Button();
            execMathOperButton = new Button();
            SuspendLayout();
            // 
            // toDecNumerator
            // 
            toDecNumerator.Location = new Point(12, 26);
            toDecNumerator.Name = "toDecNumerator";
            toDecNumerator.Size = new Size(45, 23);
            toDecNumerator.TabIndex = 0;
            // 
            // toDecDenominator
            // 
            toDecDenominator.Location = new Point(12, 55);
            toDecDenominator.Name = "toDecDenominator";
            toDecDenominator.Size = new Size(45, 23);
            toDecDenominator.TabIndex = 1;
            // 
            // chooseOperation
            // 
            chooseOperation.FormattingEnabled = true;
            chooseOperation.Location = new Point(63, 141);
            chooseOperation.Name = "chooseOperation";
            chooseOperation.Size = new Size(39, 23);
            chooseOperation.TabIndex = 2;
            chooseOperation.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // mathNumerator1
            // 
            mathNumerator1.Location = new Point(12, 126);
            mathNumerator1.Name = "mathNumerator1";
            mathNumerator1.Size = new Size(45, 23);
            mathNumerator1.TabIndex = 3;
            // 
            // mathDenominator1
            // 
            mathDenominator1.Location = new Point(12, 155);
            mathDenominator1.Name = "mathDenominator1";
            mathDenominator1.Size = new Size(45, 23);
            mathDenominator1.TabIndex = 4;
            // 
            // mathNumerator2
            // 
            mathNumerator2.Location = new Point(108, 126);
            mathNumerator2.Name = "mathNumerator2";
            mathNumerator2.Size = new Size(45, 23);
            mathNumerator2.TabIndex = 5;
            // 
            // mathDenominator2
            // 
            mathDenominator2.Location = new Point(108, 155);
            mathDenominator2.Name = "mathDenominator2";
            mathDenominator2.Size = new Size(45, 23);
            mathDenominator2.TabIndex = 6;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 144);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 7;
            label2.Text = "=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 45);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 8;
            label3.Text = "=";
            // 
            // mathNumeratorOut
            // 
            mathNumeratorOut.Location = new Point(180, 126);
            mathNumeratorOut.Name = "mathNumeratorOut";
            mathNumeratorOut.Size = new Size(45, 23);
            mathNumeratorOut.TabIndex = 9;
            // 
            // mathDenominatorOut
            // 
            mathDenominatorOut.Location = new Point(180, 155);
            mathDenominatorOut.Name = "mathDenominatorOut";
            mathDenominatorOut.Size = new Size(45, 23);
            mathDenominatorOut.TabIndex = 10;
            // 
            // toDecResult
            // 
            toDecResult.Location = new Point(84, 42);
            toDecResult.Name = "toDecResult";
            toDecResult.Size = new Size(75, 23);
            toDecResult.TabIndex = 11;
            // 
            // fromDec
            // 
            fromDec.Location = new Point(203, 42);
            fromDec.Name = "fromDec";
            fromDec.Size = new Size(75, 23);
            fromDec.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 45);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 14;
            label4.Text = "=";
            // 
            // fromDecDenominator
            // 
            fromDecDenominator.Location = new Point(305, 55);
            fromDecDenominator.Name = "fromDecDenominator";
            fromDecDenominator.Size = new Size(45, 23);
            fromDecDenominator.TabIndex = 13;
            // 
            // fromDecNumerator
            // 
            fromDecNumerator.Location = new Point(305, 26);
            fromDecNumerator.Name = "fromDecNumerator";
            fromDecNumerator.Size = new Size(45, 23);
            fromDecNumerator.TabIndex = 12;
            // 
            // normalizeDenominator
            // 
            normalizeDenominator.Location = new Point(276, 155);
            normalizeDenominator.Name = "normalizeDenominator";
            normalizeDenominator.Size = new Size(45, 23);
            normalizeDenominator.TabIndex = 17;
            // 
            // normalizeNumerator
            // 
            normalizeNumerator.Location = new Point(276, 126);
            normalizeNumerator.Name = "normalizeNumerator";
            normalizeNumerator.Size = new Size(45, 23);
            normalizeNumerator.TabIndex = 16;
            // 
            // buttonNormalize
            // 
            buttonNormalize.Location = new Point(247, 184);
            buttonNormalize.Name = "buttonNormalize";
            buttonNormalize.Size = new Size(103, 23);
            buttonNormalize.TabIndex = 18;
            buttonNormalize.Text = "Нормализовать";
            buttonNormalize.UseVisualStyleBackColor = true;
            buttonNormalize.Click += buttonNormalize_Click;
            // 
            // fromDecButton
            // 
            fromDecButton.Location = new Point(203, 84);
            fromDecButton.Name = "fromDecButton";
            fromDecButton.Size = new Size(147, 23);
            fromDecButton.TabIndex = 20;
            fromDecButton.Text = "В обыкновенную дробь";
            fromDecButton.UseVisualStyleBackColor = true;
            fromDecButton.Click += button2_Click;
            // 
            // toDecButton
            // 
            toDecButton.Location = new Point(12, 84);
            toDecButton.Name = "toDecButton";
            toDecButton.Size = new Size(147, 23);
            toDecButton.TabIndex = 21;
            toDecButton.Text = "В десятичную дробь";
            toDecButton.UseVisualStyleBackColor = true;
            toDecButton.Click += toDecButton_Click;
            // 
            // execMathOperButton
            // 
            execMathOperButton.Location = new Point(12, 184);
            execMathOperButton.Name = "execMathOperButton";
            execMathOperButton.Size = new Size(213, 23);
            execMathOperButton.TabIndex = 22;
            execMathOperButton.Text = "Выполнить операцию...";
            execMathOperButton.UseVisualStyleBackColor = true;
            execMathOperButton.Click += execMathOperButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(execMathOperButton);
            Controls.Add(toDecButton);
            Controls.Add(fromDecButton);
            Controls.Add(buttonNormalize);
            Controls.Add(normalizeDenominator);
            Controls.Add(normalizeNumerator);
            Controls.Add(fromDec);
            Controls.Add(label4);
            Controls.Add(fromDecDenominator);
            Controls.Add(fromDecNumerator);
            Controls.Add(toDecResult);
            Controls.Add(mathDenominatorOut);
            Controls.Add(mathNumeratorOut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mathDenominator2);
            Controls.Add(mathNumerator2);
            Controls.Add(mathDenominator1);
            Controls.Add(mathNumerator1);
            Controls.Add(chooseOperation);
            Controls.Add(toDecDenominator);
            Controls.Add(toDecNumerator);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox toDecNumerator;
        private TextBox toDecDenominator;
        private ComboBox chooseOperation;
        private TextBox mathNumerator1;
        private TextBox mathDenominator1;
        private TextBox mathNumerator2;
        private TextBox mathDenominator2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox mathNumeratorOut;
        private TextBox mathDenominatorOut;
        private TextBox toDecResult;
        private TextBox fromDec;
        private Label label4;
        private TextBox fromDecDenominator;
        private TextBox fromDecNumerator;
        private TextBox normalizeDenominator;
        private TextBox normalizeNumerator;
        private Button buttonNormalize;
        private Button fromDecButton;
        private Button toDecButton;
        private Button execMathOperButton;
    }
}
