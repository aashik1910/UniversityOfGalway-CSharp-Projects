namespace Finance_Form
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
            LoginPanel = new Panel();
            LoginErrorLabel = new Label();
            UserNameLabel = new Label();
            label1 = new Label();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            ButtonCancel = new Button();
            LoginButton = new Button();
            LoginToolTip = new ToolTip(components);
            CancelToolTip = new ToolTip(components);
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(LoginErrorLabel);
            LoginPanel.Controls.Add(UserNameLabel);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(PasswordLabel);
            LoginPanel.Controls.Add(PasswordTextBox);
            LoginPanel.Controls.Add(ButtonCancel);
            LoginPanel.Controls.Add(LoginButton);
            LoginPanel.Location = new Point(8, 3);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(654, 293);
            LoginPanel.TabIndex = 0;
            // 
            // LoginErrorLabel
            // 
            LoginErrorLabel.Location = new Point(78, 141);
            LoginErrorLabel.Name = "LoginErrorLabel";
            LoginErrorLabel.Size = new Size(483, 36);
            LoginErrorLabel.TabIndex = 8;
            // 
            // UserNameLabel
            // 
            UserNameLabel.BackColor = SystemColors.ActiveCaption;
            UserNameLabel.Location = new Point(305, 34);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(264, 29);
            UserNameLabel.TabIndex = 7;
            UserNameLabel.Text = "Sales Rep Admin";
            UserNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(78, 34);
            label1.Name = "label1";
            label1.Size = new Size(153, 38);
            label1.TabIndex = 6;
            label1.Text = "Password";
            // 
            // PasswordLabel
            // 
            PasswordLabel.Location = new Point(78, 93);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(153, 38);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(305, 93);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(264, 31);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(368, 194);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(193, 45);
            ButtonCancel.TabIndex = 1;
            ButtonCancel.Text = "&Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += CancelButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(78, 194);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(193, 45);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "&Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginToolTip
            // 
            LoginToolTip.ToolTipTitle = "Click to login into the form";
            // 
            // CancelToolTip
            // 
            CancelToolTip.ToolTipTitle = "Click to cancel the form";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(678, 294);
            Controls.Add(LoginPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "N4U Quote Login";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPanel;
        private Button ButtonCancel;
        private Button LoginButton;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Label UserNameLabel;
        private Label label1;
        private Label LoginErrorLabel;
        private ToolTip LoginToolTip;
        private ToolTip CancelToolTip;
    }
}