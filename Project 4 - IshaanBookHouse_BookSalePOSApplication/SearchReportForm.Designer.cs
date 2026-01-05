namespace FinalAssignmentA4
{
    partial class SearchReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchReportForm));
            ReportOutput = new Label();
            ReportDisplayTextBox = new RichTextBox();
            SearchSaleButton = new Button();
            StockButton = new Button();
            SalesButton = new Button();
            SearchPanel = new Panel();
            LogoPictureBox = new PictureBox();
            DateExampleLabel = new Label();
            TransactionExampleLabel = new Label();
            ClearButton = new Button();
            SearchButton = new Button();
            SearchTransactionLabel = new Label();
            SearchTextBox = new TextBox();
            DateRadioButton = new RadioButton();
            TransactionRadioButton = new RadioButton();
            GenerateReportButton = new Button();
            BackButton = new Button();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ReportOutput
            // 
            ReportOutput.AutoSize = true;
            ReportOutput.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReportOutput.Location = new Point(31, 33);
            ReportOutput.Name = "ReportOutput";
            ReportOutput.Size = new Size(252, 25);
            ReportOutput.TabIndex = 26;
            ReportOutput.Text = "Reports/Search Output";
            // 
            // ReportDisplayTextBox
            // 
            ReportDisplayTextBox.Location = new Point(31, 74);
            ReportDisplayTextBox.Name = "ReportDisplayTextBox";
            ReportDisplayTextBox.ReadOnly = true;
            ReportDisplayTextBox.Size = new Size(646, 488);
            ReportDisplayTextBox.TabIndex = 25;
            ReportDisplayTextBox.Text = "Reports and Search results will display here.";
            // 
            // SearchSaleButton
            // 
            SearchSaleButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            SearchSaleButton.Location = new Point(696, 286);
            SearchSaleButton.Name = "SearchSaleButton";
            SearchSaleButton.Size = new Size(130, 35);
            SearchSaleButton.TabIndex = 24;
            SearchSaleButton.Text = "S&earch Sale";
            SearchSaleButton.UseVisualStyleBackColor = true;
            SearchSaleButton.Click += SearchSaleButton_Click;
            // 
            // StockButton
            // 
            StockButton.BackColor = SystemColors.ActiveCaption;
            StockButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            StockButton.Location = new Point(696, 192);
            StockButton.Name = "StockButton";
            StockButton.Size = new Size(130, 35);
            StockButton.TabIndex = 23;
            StockButton.Text = "Stock &Report";
            StockButton.UseVisualStyleBackColor = false;
            StockButton.Click += StockButton_Click;
            // 
            // SalesButton
            // 
            SalesButton.BackColor = SystemColors.ActiveCaption;
            SalesButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            SalesButton.Location = new Point(696, 103);
            SalesButton.Name = "SalesButton";
            SalesButton.Size = new Size(130, 35);
            SalesButton.TabIndex = 22;
            SalesButton.Text = "&Sales Report";
            SalesButton.UseVisualStyleBackColor = false;
            SalesButton.Click += SalesButton_Click;
            // 
            // SearchPanel
            // 
            SearchPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchPanel.Controls.Add(LogoPictureBox);
            SearchPanel.Controls.Add(DateExampleLabel);
            SearchPanel.Controls.Add(TransactionExampleLabel);
            SearchPanel.Controls.Add(ClearButton);
            SearchPanel.Controls.Add(SearchButton);
            SearchPanel.Controls.Add(SearchTransactionLabel);
            SearchPanel.Controls.Add(SearchTextBox);
            SearchPanel.Controls.Add(DateRadioButton);
            SearchPanel.Controls.Add(TransactionRadioButton);
            SearchPanel.Location = new Point(845, 74);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(358, 488);
            SearchPanel.TabIndex = 27;
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Image = (Image)resources.GetObject("LogoPictureBox.Image");
            LogoPictureBox.Location = new Point(93, 317);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(174, 149);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoPictureBox.TabIndex = 28;
            LogoPictureBox.TabStop = false;
            // 
            // DateExampleLabel
            // 
            DateExampleLabel.AutoSize = true;
            DateExampleLabel.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateExampleLabel.ForeColor = Color.SaddleBrown;
            DateExampleLabel.Location = new Point(194, 124);
            DateExampleLabel.Name = "DateExampleLabel";
            DateExampleLabel.Size = new Size(156, 25);
            DateExampleLabel.TabIndex = 31;
            DateExampleLabel.Text = "(YYYY-MM-DD)";
            // 
            // TransactionExampleLabel
            // 
            TransactionExampleLabel.AutoSize = true;
            TransactionExampleLabel.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TransactionExampleLabel.ForeColor = Color.SaddleBrown;
            TransactionExampleLabel.Location = new Point(189, 71);
            TransactionExampleLabel.Name = "TransactionExampleLabel";
            TransactionExampleLabel.Size = new Size(167, 25);
            TransactionExampleLabel.TabIndex = 30;
            TransactionExampleLabel.Text = "(e.g., IBH123456)";
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.DarkOrange;
            ClearButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            ClearButton.Location = new Point(210, 262);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 34);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.DarkOrange;
            SearchButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            SearchButton.Location = new Point(38, 262);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(112, 34);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Se&arch";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTransactionLabel
            // 
            SearchTransactionLabel.AutoSize = true;
            SearchTransactionLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            SearchTransactionLabel.Location = new Point(19, 24);
            SearchTransactionLabel.Name = "SearchTransactionLabel";
            SearchTransactionLabel.Size = new Size(214, 22);
            SearchTransactionLabel.TabIndex = 3;
            SearchTransactionLabel.Text = "Search Transaction By";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(38, 189);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(284, 31);
            SearchTextBox.TabIndex = 2;
            // 
            // DateRadioButton
            // 
            DateRadioButton.AutoSize = true;
            DateRadioButton.Font = new Font("Microsoft Sans Serif", 9F);
            DateRadioButton.Location = new Point(39, 123);
            DateRadioButton.Name = "DateRadioButton";
            DateRadioButton.Size = new Size(154, 26);
            DateRadioButton.TabIndex = 1;
            DateRadioButton.TabStop = true;
            DateRadioButton.Text = "Purchase Date";
            DateRadioButton.UseVisualStyleBackColor = true;
            DateRadioButton.CheckedChanged += DateRadioButton_CheckedChanged;
            // 
            // TransactionRadioButton
            // 
            TransactionRadioButton.AutoSize = true;
            TransactionRadioButton.Font = new Font("Microsoft Sans Serif", 9F);
            TransactionRadioButton.Location = new Point(38, 70);
            TransactionRadioButton.Name = "TransactionRadioButton";
            TransactionRadioButton.Size = new Size(152, 26);
            TransactionRadioButton.TabIndex = 0;
            TransactionRadioButton.TabStop = true;
            TransactionRadioButton.Text = "Transaction ID";
            TransactionRadioButton.UseVisualStyleBackColor = true;
            TransactionRadioButton.CheckedChanged += TransactionRadioButton_CheckedChanged;
            // 
            // GenerateReportButton
            // 
            GenerateReportButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            GenerateReportButton.Location = new Point(696, 385);
            GenerateReportButton.Name = "GenerateReportButton";
            GenerateReportButton.Size = new Size(130, 57);
            GenerateReportButton.TabIndex = 7;
            GenerateReportButton.Text = "&Generate Report";
            GenerateReportButton.UseVisualStyleBackColor = true;
            GenerateReportButton.Click += GenerateReportButton_Click;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            BackButton.ForeColor = SystemColors.ActiveCaptionText;
            BackButton.Location = new Point(696, 504);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(130, 34);
            BackButton.TabIndex = 5;
            BackButton.Text = "&Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SearchReportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1228, 644);
            Controls.Add(GenerateReportButton);
            Controls.Add(SearchPanel);
            Controls.Add(ReportOutput);
            Controls.Add(BackButton);
            Controls.Add(ReportDisplayTextBox);
            Controls.Add(SearchSaleButton);
            Controls.Add(StockButton);
            Controls.Add(SalesButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchReportForm";
            Text = "Ishaan Book House";
            Load += SearchReportForm_Load;
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ReportOutput;
        private RichTextBox ReportDisplayTextBox;
        private Button SearchSaleButton;
        private Button StockButton;
        private Button SalesButton;
        private Panel SearchPanel;
        private Button SearchButton;
        private Label SearchTransactionLabel;
        private TextBox SearchTextBox;
        private RadioButton DateRadioButton;
        private RadioButton TransactionRadioButton;
        private Button GenerateReportButton;
        private Button ClearButton;
        private Button BackButton;
        private Label TransactionExampleLabel;
        private Label DateExampleLabel;
        private PictureBox LogoPictureBox;
    }
}