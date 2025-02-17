namespace PasswordHelper;

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
        assessButton = new Button();
        generateButton = new Button();
        enterPasswordTextBox = new RichTextBox();
        generatePasswordTextBox = new RichTextBox();
        enterPasswordLabel = new Label();
        generatePasswordLabel = new Label();
        passwordStrengthBar = new ProgressBar();
        strengthLabel = new Label();
        passwordLengthTextBox = new RichTextBox();
        passwordLengthLabel = new Label();
        disclaimerLabel = new Label();
        disclaimerLabel2 = new Label();
        SuspendLayout();
        // 
        // assessButton
        // 
        assessButton.Location = new Point(939, 260);
        assessButton.Margin = new Padding(5, 6, 5, 6);
        assessButton.Name = "assessButton";
        assessButton.Size = new Size(202, 72);
        assessButton.TabIndex = 0;
        assessButton.Text = "Assess Strength";
        assessButton.UseVisualStyleBackColor = true;
        assessButton.Click += assessButton_Click;
        // 
        // generateButton
        // 
        generateButton.Location = new Point(939, 632);
        generateButton.Margin = new Padding(5, 6, 5, 6);
        generateButton.Name = "generateButton";
        generateButton.Size = new Size(202, 72);
        generateButton.TabIndex = 1;
        generateButton.Text = "Generate Password";
        generateButton.UseVisualStyleBackColor = true;
        generateButton.Click += generateButton_Click;
        // 
        // enterPasswordTextBox
        // 
        enterPasswordTextBox.Location = new Point(423, 260);
        enterPasswordTextBox.Margin = new Padding(5, 6, 5, 6);
        enterPasswordTextBox.Name = "enterPasswordTextBox";
        enterPasswordTextBox.Size = new Size(439, 68);
        enterPasswordTextBox.TabIndex = 2;
        enterPasswordTextBox.Text = "";
        // 
        // generatePasswordTextBox
        // 
        generatePasswordTextBox.Location = new Point(423, 632);
        generatePasswordTextBox.Margin = new Padding(5, 6, 5, 6);
        generatePasswordTextBox.Name = "generatePasswordTextBox";
        generatePasswordTextBox.Size = new Size(439, 68);
        generatePasswordTextBox.TabIndex = 3;
        generatePasswordTextBox.Text = "";
        // 
        // enterPasswordLabel
        // 
        enterPasswordLabel.AutoSize = true;
        enterPasswordLabel.Location = new Point(122, 282);
        enterPasswordLabel.Margin = new Padding(5, 0, 5, 0);
        enterPasswordLabel.Name = "enterPasswordLabel";
        enterPasswordLabel.Size = new Size(203, 30);
        enterPasswordLabel.TabIndex = 4;
        enterPasswordLabel.Text = "Enter Password Here";
        // 
        // generatePasswordLabel
        // 
        generatePasswordLabel.AutoSize = true;
        generatePasswordLabel.Location = new Point(423, 596);
        generatePasswordLabel.Margin = new Padding(5, 0, 5, 0);
        generatePasswordLabel.Name = "generatePasswordLabel";
        generatePasswordLabel.Size = new Size(239, 30);
        generatePasswordLabel.TabIndex = 5;
        generatePasswordLabel.Text = "Generate Password Here";
        // 
        // passwordStrengthBar
        // 
        passwordStrengthBar.Location = new Point(423, 392);
        passwordStrengthBar.Margin = new Padding(5, 6, 5, 6);
        passwordStrengthBar.Name = "passwordStrengthBar";
        passwordStrengthBar.Size = new Size(442, 64);
        passwordStrengthBar.TabIndex = 6;
        // 
        // strengthLabel
        // 
        strengthLabel.AutoSize = true;
        strengthLabel.Location = new Point(122, 414);
        strengthLabel.Margin = new Padding(5, 0, 5, 0);
        strengthLabel.Name = "strengthLabel";
        strengthLabel.Size = new Size(245, 30);
        strengthLabel.TabIndex = 7;
        strengthLabel.Text = "Password Strength: None";
        // 
        // passwordLengthTextBox
        // 
        passwordLengthTextBox.Location = new Point(122, 632);
        passwordLengthTextBox.Margin = new Padding(5, 6, 5, 6);
        passwordLengthTextBox.Name = "passwordLengthTextBox";
        passwordLengthTextBox.Size = new Size(206, 68);
        passwordLengthTextBox.TabIndex = 8;
        passwordLengthTextBox.Text = "";
        // 
        // passwordLengthLabel
        // 
        passwordLengthLabel.AutoSize = true;
        passwordLengthLabel.Location = new Point(122, 596);
        passwordLengthLabel.Margin = new Padding(5, 0, 5, 0);
        passwordLengthLabel.Name = "passwordLengthLabel";
        passwordLengthLabel.Size = new Size(169, 30);
        passwordLengthLabel.TabIndex = 9;
        passwordLengthLabel.Text = "Password Length";
        // 
        // disclaimerLabel
        // 
        disclaimerLabel.AutoSize = true;
        disclaimerLabel.Location = new Point(33, 102);
        disclaimerLabel.Margin = new Padding(5, 0, 5, 0);
        disclaimerLabel.Name = "disclaimerLabel";
        disclaimerLabel.Size = new Size(1108, 30);
        disclaimerLabel.TabIndex = 10;
        disclaimerLabel.Text = "DISCLAIMER: This application is a simple project and is NOT intended to generate passwords for real world situations. ";
        // 
        // disclaimerLabel2
        // 
        disclaimerLabel2.AutoSize = true;
        disclaimerLabel2.Location = new Point(164, 132);
        disclaimerLabel2.Name = "disclaimerLabel2";
        disclaimerLabel2.Size = new Size(264, 30);
        disclaimerLabel2.TabIndex = 11;
        disclaimerLabel2.Text = "Use at your own discretion.";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1371, 900);
        Controls.Add(disclaimerLabel2);
        Controls.Add(disclaimerLabel);
        Controls.Add(passwordLengthLabel);
        Controls.Add(passwordLengthTextBox);
        Controls.Add(strengthLabel);
        Controls.Add(passwordStrengthBar);
        Controls.Add(generatePasswordLabel);
        Controls.Add(enterPasswordLabel);
        Controls.Add(generatePasswordTextBox);
        Controls.Add(enterPasswordTextBox);
        Controls.Add(generateButton);
        Controls.Add(assessButton);
        Margin = new Padding(5, 6, 5, 6);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button assessButton;
    private Button generateButton;
    private RichTextBox enterPasswordTextBox;
    private RichTextBox generatePasswordTextBox;
    private Label enterPasswordLabel;
    private Label generatePasswordLabel;
    private ProgressBar passwordStrengthBar;
    private Label strengthLabel;
    private RichTextBox passwordLengthTextBox;
    private Label passwordLengthLabel;
    private Label disclaimerLabel;
    private Label disclaimerLabel2;
}
