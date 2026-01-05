namespace FinanceQuoteForm
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            SearchPanel = new Panel();
            SearchTextBox = new TextBox();
            CloseButton = new Button();
            SearchButton = new Button();
            EmailRadioButton = new RadioButton();
            TransactionIdRadioButton = new RadioButton();
            SearchDisplayLabel = new Label();
            SearchToolTip = new ToolTip(components);
            CloseToolTip = new ToolTip(components);
            SearchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SearchPanel
            // 
            SearchPanel.Controls.Add(SearchTextBox);
            SearchPanel.Controls.Add(CloseButton);
            SearchPanel.Controls.Add(SearchButton);
            SearchPanel.Controls.Add(EmailRadioButton);
            SearchPanel.Controls.Add(TransactionIdRadioButton);
            SearchPanel.Location = new Point(47, 30);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(705, 161);
            SearchPanel.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(70, 97);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(408, 31);
            SearchTextBox.TabIndex = 4;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = SystemColors.ButtonHighlight;
            CloseButton.Location = new Point(550, 101);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(112, 34);
            CloseButton.TabIndex = 3;
            CloseButton.Text = "&Close";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = SystemColors.ButtonHighlight;
            SearchButton.Location = new Point(550, 32);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(112, 34);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "&Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // EmailRadioButton
            // 
            EmailRadioButton.AutoSize = true;
            EmailRadioButton.Location = new Point(311, 42);
            EmailRadioButton.Name = "EmailRadioButton";
            EmailRadioButton.Size = new Size(160, 29);
            EmailRadioButton.TabIndex = 1;
            EmailRadioButton.TabStop = true;
            EmailRadioButton.Text = "Search By Email";
            EmailRadioButton.UseVisualStyleBackColor = true;
            // 
            // TransactionIdRadioButton
            // 
            TransactionIdRadioButton.AutoSize = true;
            TransactionIdRadioButton.Location = new Point(71, 42);
            TransactionIdRadioButton.Name = "TransactionIdRadioButton";
            TransactionIdRadioButton.Size = new Size(229, 29);
            TransactionIdRadioButton.TabIndex = 0;
            TransactionIdRadioButton.TabStop = true;
            TransactionIdRadioButton.Text = "Search By Transaction ID";
            TransactionIdRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchDisplayLabel
            // 
            SearchDisplayLabel.BorderStyle = BorderStyle.FixedSingle;
            SearchDisplayLabel.Location = new Point(47, 230);
            SearchDisplayLabel.Name = "SearchDisplayLabel";
            SearchDisplayLabel.Size = new Size(705, 436);
            SearchDisplayLabel.TabIndex = 1;
            // 
            // SearchToolTip
            // 
            SearchToolTip.ToolTipTitle = "Click to search for the transactions";
            // 
            // CloseToolTip
            // 
            CloseToolTip.ToolTipTitle = "Close the application";
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 695);
            Controls.Add(SearchDisplayLabel);
            Controls.Add(SearchPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Form";
            Load += SearchForm_Load;
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SearchPanel;
        private Button CloseButton;
        private Button SearchButton;
        private RadioButton EmailRadioButton;
        private RadioButton TransactionIdRadioButton;
        private TextBox SearchTextBox;
        private Label SearchDisplayLabel;
        private ToolTip SearchToolTip;
        private ToolTip CloseToolTip;
    }
}