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
        errorLabel = new Label();
        SuspendLayout();
        // 
        // assessButton
        // 
        assessButton.Location = new Point(548, 122);
        assessButton.Name = "assessButton";
        assessButton.Size = new Size(118, 36);
        assessButton.TabIndex = 0;
        assessButton.Text = "Assess Strength";
        assessButton.UseVisualStyleBackColor = true;
        assessButton.Click += assessButton_Click;
        // 
        // generateButton
        // 
        generateButton.Location = new Point(548, 308);
        generateButton.Name = "generateButton";
        generateButton.Size = new Size(118, 36);
        generateButton.TabIndex = 1;
        generateButton.Text = "Generate Password";
        generateButton.UseVisualStyleBackColor = true;
        generateButton.Click += generateButton_Click;
        // 
        // enterPasswordTextBox
        // 
        enterPasswordTextBox.Location = new Point(247, 122);
        enterPasswordTextBox.Name = "enterPasswordTextBox";
        enterPasswordTextBox.Size = new Size(258, 36);
        enterPasswordTextBox.TabIndex = 2;
        enterPasswordTextBox.Text = "";
        // 
        // generatePasswordTextBox
        // 
        generatePasswordTextBox.Location = new Point(247, 316);
        generatePasswordTextBox.Name = "generatePasswordTextBox";
        generatePasswordTextBox.Size = new Size(258, 24);
        generatePasswordTextBox.TabIndex = 3;
        generatePasswordTextBox.Text = "";
        // 
        // enterPasswordLabel
        // 
        enterPasswordLabel.AutoSize = true;
        enterPasswordLabel.Location = new Point(71, 133);
        enterPasswordLabel.Name = "enterPasswordLabel";
        enterPasswordLabel.Size = new Size(115, 15);
        enterPasswordLabel.TabIndex = 4;
        enterPasswordLabel.Text = "Enter Password Here";
        // 
        // generatePasswordLabel
        // 
        generatePasswordLabel.AutoSize = true;
        generatePasswordLabel.Location = new Point(247, 298);
        generatePasswordLabel.Name = "generatePasswordLabel";
        generatePasswordLabel.Size = new Size(135, 15);
        generatePasswordLabel.TabIndex = 5;
        generatePasswordLabel.Text = "Generate Password Here";
        // 
        // passwordStrengthBar
        // 
        passwordStrengthBar.Location = new Point(247, 196);
        passwordStrengthBar.Name = "passwordStrengthBar";
        passwordStrengthBar.Size = new Size(258, 32);
        passwordStrengthBar.TabIndex = 6;
        // 
        // strengthLabel
        // 
        strengthLabel.AutoSize = true;
        strengthLabel.Location = new Point(71, 196);
        strengthLabel.Name = "strengthLabel";
        strengthLabel.Size = new Size(140, 15);
        strengthLabel.TabIndex = 7;
        strengthLabel.Text = "Password Strength: None";
        // 
        // passwordLengthTextBox
        // 
        passwordLengthTextBox.Location = new Point(71, 316);
        passwordLengthTextBox.Name = "passwordLengthTextBox";
        passwordLengthTextBox.Size = new Size(97, 24);
        passwordLengthTextBox.TabIndex = 8;
        passwordLengthTextBox.Text = "";
        // 
        // passwordLengthLabel
        // 
        passwordLengthLabel.AutoSize = true;
        passwordLengthLabel.Location = new Point(71, 298);
        passwordLengthLabel.Name = "passwordLengthLabel";
        passwordLengthLabel.Size = new Size(97, 15);
        passwordLengthLabel.TabIndex = 9;
        passwordLengthLabel.Text = "Password Length";
        // 
        // disclaimerLabel
        // 
        disclaimerLabel.AutoSize = true;
        disclaimerLabel.Location = new Point(19, 51);
        disclaimerLabel.Name = "disclaimerLabel";
        disclaimerLabel.Size = new Size(626, 15);
        disclaimerLabel.TabIndex = 10;
        disclaimerLabel.Text = "DISCLAIMER: This application is a simple project and is NOT intended to generate passwords for real world situations. ";
        // 
        // disclaimerLabel2
        // 
        disclaimerLabel2.AutoSize = true;
        disclaimerLabel2.Location = new Point(96, 66);
        disclaimerLabel2.Margin = new Padding(2, 0, 2, 0);
        disclaimerLabel2.Name = "disclaimerLabel2";
        disclaimerLabel2.Size = new Size(150, 15);
        disclaimerLabel2.TabIndex = 11;
        disclaimerLabel2.Text = "Use at your own discretion.";
        // 
        // errorLabel
        // 
        errorLabel.AutoSize = true;
        errorLabel.Location = new Point(71, 213);
        errorLabel.Name = "errorLabel";
        errorLabel.Size = new Size(0, 15);
        errorLabel.TabIndex = 12;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(errorLabel);
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
        Name = "Form1";
        Text = "Password Helper";
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
    private Label errorLabel;
}
