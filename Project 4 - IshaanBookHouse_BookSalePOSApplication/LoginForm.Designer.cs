namespace FinalAssignmentA4
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginLogoPicture = new PictureBox();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            LoginButton = new Button();
            ExitButton = new Button();
            LoginToolTip = new ToolTip(components);
            ExitToolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)LoginLogoPicture).BeginInit();
            SuspendLayout();
            // 
            // LoginLogoPicture
            // 
            LoginLogoPicture.Image = (Image)resources.GetObject("LoginLogoPicture.Image");
            LoginLogoPicture.Location = new Point(300, 38);
            LoginLogoPicture.Name = "LoginLogoPicture";
            LoginLogoPicture.Size = new Size(168, 118);
            LoginLogoPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            LoginLogoPicture.TabIndex = 0;
            LoginLogoPicture.TabStop = false;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(300, 213);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(303, 31);
            UserNameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(300, 284);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(303, 31);
            PasswordTextBox.TabIndex = 2;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UserNameLabel.Location = new Point(128, 219);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(109, 22);
            UserNameLabel.TabIndex = 3;
            UserNameLabel.Text = "User Name";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(128, 293);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(97, 22);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.ActiveCaption;
            LoginButton.Location = new Point(169, 364);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(168, 39);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "&Login";
            LoginToolTip.SetToolTip(LoginButton, "Please Click to Login");
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = SystemColors.ActiveCaption;
            ExitButton.Location = new Point(406, 364);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(168, 39);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "&Exit";
            ExitToolTip.SetToolTip(ExitButton, "Click to Exit the Application");
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(LoginLogoPicture);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Ishaan Book House Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)LoginLogoPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LoginLogoPicture;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
        private Label UserNameLabel;
        private Label PasswordLabel;
        private Button LoginButton;
        private Button ExitButton;
        private ToolTip LoginToolTip;
        private ToolTip ExitToolTip;
    }
}