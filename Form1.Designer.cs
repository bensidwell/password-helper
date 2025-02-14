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
        SuspendLayout();
        // 
        // assessButton
        // 
        assessButton.Location = new Point(548, 130);
        assessButton.Name = "assessButton";
        assessButton.Size = new Size(118, 36);
        assessButton.TabIndex = 0;
        assessButton.Text = "Assess Strength";
        assessButton.UseVisualStyleBackColor = true;
        assessButton.Click += assessButton_Click;
        // 
        // generateButton
        // 
        generateButton.Location = new Point(548, 316);
        generateButton.Name = "generateButton";
        generateButton.Size = new Size(118, 36);
        generateButton.TabIndex = 1;
        generateButton.Text = "Generate Password";
        generateButton.UseVisualStyleBackColor = true;
        generateButton.Click += generateButton_Click;
        // 
        // enterPasswordTextBox
        // 
        enterPasswordTextBox.Location = new Point(247, 130);
        enterPasswordTextBox.Name = "enterPasswordTextBox";
        enterPasswordTextBox.Size = new Size(258, 36);
        enterPasswordTextBox.TabIndex = 2;
        enterPasswordTextBox.Text = "";
        // 
        // generatePasswordTextBox
        // 
        generatePasswordTextBox.Location = new Point(247, 316);
        generatePasswordTextBox.Name = "generatePasswordTextBox";
        generatePasswordTextBox.Size = new Size(258, 36);
        generatePasswordTextBox.TabIndex = 3;
        generatePasswordTextBox.Text = "";
        // 
        // enterPasswordLabel
        // 
        enterPasswordLabel.AutoSize = true;
        enterPasswordLabel.Location = new Point(92, 141);
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
        strengthLabel.Location = new Point(102, 203);
        strengthLabel.Name = "strengthLabel";
        strengthLabel.Size = new Size(105, 15);
        strengthLabel.TabIndex = 7;
        strengthLabel.Text = "Password Strength";
        // 
        // passwordLengthTextBox
        // 
        passwordLengthTextBox.Location = new Point(92, 316);
        passwordLengthTextBox.Name = "passwordLengthTextBox";
        passwordLengthTextBox.Size = new Size(122, 36);
        passwordLengthTextBox.TabIndex = 8;
        passwordLengthTextBox.Text = "";
        // 
        // passwordLengthLabel
        // 
        passwordLengthLabel.AutoSize = true;
        passwordLengthLabel.Location = new Point(92, 298);
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
        disclaimerLabel.Size = new Size(769, 15);
        disclaimerLabel.TabIndex = 10;
        disclaimerLabel.Text = "DISCLAIMER: This application is a simple project and is NOT intended to generate passwords for real world situations. Use at your own discretion.";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
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
}
