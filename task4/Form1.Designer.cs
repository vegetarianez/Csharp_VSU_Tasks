
partial class Form1
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
        txtPath = new TextBox();
        btnLoad = new Button();
        lstClasses = new ListBox();
        lstMethods = new ListBox();
        pnlParams = new FlowLayoutPanel();
        btnExecute = new Button();
        lblResult = new Label();
        SuspendLayout();
        // 
        // txtPath
        // 
        txtPath.Location = new Point(12, 12);
        txtPath.Name = "txtPath";
        txtPath.Size = new Size(506, 23);
        txtPath.TabIndex = 0;
        txtPath.Text = "C:\\Users\\Nick\\source\\repos\\FlyingMachineLib\\bin\\Debug\\net8.0\\FlyingMachineLib.dll";
        // 
        // btnLoad
        // 
        btnLoad.Location = new Point(524, 12);
        btnLoad.Name = "btnLoad";
        btnLoad.Size = new Size(75, 23);
        btnLoad.TabIndex = 1;
        btnLoad.Text = "button1";
        btnLoad.UseVisualStyleBackColor = true;
        btnLoad.Click += btnLoad_Click;
        // 
        // lstClasses
        // 
        lstClasses.FormattingEnabled = true;
        lstClasses.ItemHeight = 15;
        lstClasses.Location = new Point(12, 41);
        lstClasses.Name = "lstClasses";
        lstClasses.Size = new Size(120, 94);
        lstClasses.TabIndex = 2;
        lstClasses.SelectedIndexChanged += lstClasses_SelectedIndexChanged_1;
        // 
        // lstMethods
        // 
        lstMethods.FormattingEnabled = true;
        lstMethods.ItemHeight = 15;
        lstMethods.Location = new Point(12, 141);
        lstMethods.Name = "lstMethods";
        lstMethods.Size = new Size(120, 94);
        lstMethods.TabIndex = 3;
        // 
        // pnlParams
        // 
        pnlParams.Location = new Point(12, 241);
        pnlParams.Name = "pnlParams";
        pnlParams.Size = new Size(200, 100);
        pnlParams.TabIndex = 4;
        // 
        // btnExecute
        // 
        btnExecute.Location = new Point(266, 273);
        btnExecute.Name = "btnExecute";
        btnExecute.Size = new Size(75, 23);
        btnExecute.TabIndex = 0;
        btnExecute.Text = "button1";
        btnExecute.UseVisualStyleBackColor = true;
        btnExecute.Click += btnExecute_Click;
        // 
        // lblResult
        // 
        lblResult.AutoSize = true;
        lblResult.Location = new Point(431, 281);
        lblResult.Name = "lblResult";
        lblResult.Size = new Size(38, 15);
        lblResult.TabIndex = 5;
        lblResult.Text = "label1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lblResult);
        Controls.Add(btnExecute);
        Controls.Add(pnlParams);
        Controls.Add(lstMethods);
        Controls.Add(lstClasses);
        Controls.Add(btnLoad);
        Controls.Add(txtPath);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtPath;
    private Button btnLoad;
    private ListBox lstClasses;
    private ListBox lstMethods;
    private FlowLayoutPanel pnlParams;
    private Button btnExecute;
    private Label lblResult;
}
