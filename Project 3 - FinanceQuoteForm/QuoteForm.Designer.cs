namespace Finance_Form
{
    partial class QuoteForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuoteForm));
            EquipmentListBox = new ListBox();
            BrandListBox = new ListBox();
            QuantityTextBox = new TextBox();
            EquipmentNameLabel = new Label();
            ServiceWarrantyGroupBox = new GroupBox();
            NoWarrantyButton = new RadioButton();
            Year5RadioButton = new RadioButton();
            Year3RadioButton = new RadioButton();
            Year1RadioButton = new RadioButton();
            EquipmentCostLabel = new Label();
            BrandNameLabel = new Label();
            BrandDiscountLabel = new Label();
            QuantityLabel = new Label();
            LogoPictureBox = new PictureBox();
            ExpeditedInstallCheckBox = new CheckBox();
            OutputLabel = new Label();
            TopPanel = new Panel();
            QuoteButton = new Button();
            OrderButton = new Button();
            SearchButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            ButtonPanel = new Panel();
            ProceedButton = new Button();
            ClientInputGroupBox = new GroupBox();
            ErrorMessageLabel = new Label();
            TransanctionIDLabel = new Label();
            TransactionLabelBox = new Label();
            DateLabelBox = new Label();
            ClientNameTextBox = new TextBox();
            EircodeTextBox = new TextBox();
            EmailLabel = new Label();
            PhoneNumberTextBox = new TextBox();
            PhoneLabel = new Label();
            EmailAddressTextBox = new TextBox();
            EircodeLabel = new Label();
            DateLabel = new Label();
            ClientNameLabel = new Label();
            QuoteToolTip = new ToolTip(components);
            OrderToolTip = new ToolTip(components);
            ProceedToolTip = new ToolTip(components);
            SearchToolTip = new ToolTip(components);
            ClearToolTip = new ToolTip(components);
            ExitToolTip = new ToolTip(components);
            ServiceWarrantyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            TopPanel.SuspendLayout();
            ButtonPanel.SuspendLayout();
            ClientInputGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EquipmentListBox
            // 
            EquipmentListBox.BackColor = SystemColors.Window;
            EquipmentListBox.Font = new Font("Comic Sans MS", 9F);
            EquipmentListBox.FormattingEnabled = true;
            EquipmentListBox.Items.AddRange(new object[] { "Elliptical\t\t             €1199", "Threadmill\t              €899", "Exercise Bike\t              €499", "Rowing Machine\t              €699", "Stair Climber\t              €799" });
            EquipmentListBox.Location = new Point(26, 68);
            EquipmentListBox.Name = "EquipmentListBox";
            EquipmentListBox.Size = new Size(320, 124);
            EquipmentListBox.TabIndex = 0;
            // 
            // BrandListBox
            // 
            BrandListBox.BackColor = SystemColors.Window;
            BrandListBox.Font = new Font("Comic Sans MS", 9F);
            BrandListBox.FormattingEnabled = true;
            BrandListBox.Items.AddRange(new object[] { "Own Brand\t              -20%", "Techno Gym\t              -10%", "Proform\t\t                0%", "NordicTrack\t               15%", "Peloton\t\t               25%" });
            BrandListBox.Location = new Point(368, 68);
            BrandListBox.Name = "BrandListBox";
            BrandListBox.Size = new Size(320, 124);
            BrandListBox.TabIndex = 1;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuantityTextBox.Location = new Point(719, 70);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(104, 26);
            QuantityTextBox.TabIndex = 2;
            QuantityTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // EquipmentNameLabel
            // 
            EquipmentNameLabel.AutoSize = true;
            EquipmentNameLabel.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            EquipmentNameLabel.Location = new Point(26, 31);
            EquipmentNameLabel.Name = "EquipmentNameLabel";
            EquipmentNameLabel.Size = new Size(154, 25);
            EquipmentNameLabel.TabIndex = 2;
            EquipmentNameLabel.Text = "Equipment Name";
            // 
            // ServiceWarrantyGroupBox
            // 
            ServiceWarrantyGroupBox.Controls.Add(NoWarrantyButton);
            ServiceWarrantyGroupBox.Controls.Add(Year5RadioButton);
            ServiceWarrantyGroupBox.Controls.Add(Year3RadioButton);
            ServiceWarrantyGroupBox.Controls.Add(Year1RadioButton);
            ServiceWarrantyGroupBox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ServiceWarrantyGroupBox.Location = new Point(854, 34);
            ServiceWarrantyGroupBox.Name = "ServiceWarrantyGroupBox";
            ServiceWarrantyGroupBox.Size = new Size(229, 158);
            ServiceWarrantyGroupBox.TabIndex = 3;
            ServiceWarrantyGroupBox.TabStop = false;
            ServiceWarrantyGroupBox.Text = "Service Warranty";
            // 
            // NoWarrantyButton
            // 
            NoWarrantyButton.AutoSize = true;
            NoWarrantyButton.Location = new Point(18, 124);
            NoWarrantyButton.Name = "NoWarrantyButton";
            NoWarrantyButton.Size = new Size(143, 28);
            NoWarrantyButton.TabIndex = 3;
            NoWarrantyButton.TabStop = true;
            NoWarrantyButton.Text = "No Warranty";
            NoWarrantyButton.UseVisualStyleBackColor = true;
            // 
            // Year5RadioButton
            // 
            Year5RadioButton.AutoSize = true;
            Year5RadioButton.Location = new Point(20, 90);
            Year5RadioButton.Name = "Year5RadioButton";
            Year5RadioButton.Size = new Size(183, 28);
            Year5RadioButton.TabIndex = 2;
            Year5RadioButton.TabStop = true;
            Year5RadioButton.Text = "5 Year           30%";
            Year5RadioButton.UseVisualStyleBackColor = true;
            // 
            // Year3RadioButton
            // 
            Year3RadioButton.AutoSize = true;
            Year3RadioButton.Location = new Point(20, 60);
            Year3RadioButton.Name = "Year3RadioButton";
            Year3RadioButton.Size = new Size(183, 28);
            Year3RadioButton.TabIndex = 1;
            Year3RadioButton.TabStop = true;
            Year3RadioButton.Text = "3 Year           25%";
            Year3RadioButton.UseVisualStyleBackColor = true;
            // 
            // Year1RadioButton
            // 
            Year1RadioButton.AutoSize = true;
            Year1RadioButton.Location = new Point(20, 29);
            Year1RadioButton.Name = "Year1RadioButton";
            Year1RadioButton.Size = new Size(182, 28);
            Year1RadioButton.TabIndex = 0;
            Year1RadioButton.TabStop = true;
            Year1RadioButton.Text = "1 Year            15%";
            Year1RadioButton.UseVisualStyleBackColor = true;
            // 
            // EquipmentCostLabel
            // 
            EquipmentCostLabel.AutoSize = true;
            EquipmentCostLabel.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            EquipmentCostLabel.Location = new Point(197, 31);
            EquipmentCostLabel.Name = "EquipmentCostLabel";
            EquipmentCostLabel.Size = new Size(142, 25);
            EquipmentCostLabel.TabIndex = 4;
            EquipmentCostLabel.Text = "Equipment Cost";
            // 
            // BrandNameLabel
            // 
            BrandNameLabel.AutoSize = true;
            BrandNameLabel.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            BrandNameLabel.Location = new Point(368, 31);
            BrandNameLabel.Name = "BrandNameLabel";
            BrandNameLabel.Size = new Size(119, 25);
            BrandNameLabel.TabIndex = 5;
            BrandNameLabel.Text = "Brand Name";
            // 
            // BrandDiscountLabel
            // 
            BrandDiscountLabel.AutoSize = true;
            BrandDiscountLabel.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            BrandDiscountLabel.Location = new Point(538, 31);
            BrandDiscountLabel.Name = "BrandDiscountLabel";
            BrandDiscountLabel.Size = new Size(141, 25);
            BrandDiscountLabel.TabIndex = 6;
            BrandDiscountLabel.Text = "Brand Discount";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            QuantityLabel.Location = new Point(719, 31);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(87, 25);
            QuantityLabel.TabIndex = 7;
            QuantityLabel.Text = "Quantity";
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.BorderStyle = BorderStyle.FixedSingle;
            LogoPictureBox.Image = (Image)resources.GetObject("LogoPictureBox.Image");
            LogoPictureBox.InitialImage = (Image)resources.GetObject("LogoPictureBox.InitialImage");
            LogoPictureBox.Location = new Point(719, 135);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(104, 57);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoPictureBox.TabIndex = 8;
            LogoPictureBox.TabStop = false;
            // 
            // ExpeditedInstallCheckBox
            // 
            ExpeditedInstallCheckBox.AutoSize = true;
            ExpeditedInstallCheckBox.Font = new Font("Comic Sans MS", 9F);
            ExpeditedInstallCheckBox.Location = new Point(873, 205);
            ExpeditedInstallCheckBox.Name = "ExpeditedInstallCheckBox";
            ExpeditedInstallCheckBox.Size = new Size(182, 28);
            ExpeditedInstallCheckBox.TabIndex = 9;
            ExpeditedInstallCheckBox.Text = "Expedited Install";
            ExpeditedInstallCheckBox.UseVisualStyleBackColor = true;
            // 
            // OutputLabel
            // 
            OutputLabel.BackColor = SystemColors.ButtonHighlight;
            OutputLabel.BorderStyle = BorderStyle.FixedSingle;
            OutputLabel.ImageAlign = ContentAlignment.MiddleRight;
            OutputLabel.Location = new Point(21, 270);
            OutputLabel.Margin = new Padding(3);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(452, 304);
            OutputLabel.TabIndex = 0;
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(ExpeditedInstallCheckBox);
            TopPanel.Controls.Add(LogoPictureBox);
            TopPanel.Controls.Add(QuantityLabel);
            TopPanel.Controls.Add(BrandDiscountLabel);
            TopPanel.Controls.Add(BrandNameLabel);
            TopPanel.Controls.Add(EquipmentCostLabel);
            TopPanel.Controls.Add(ServiceWarrantyGroupBox);
            TopPanel.Controls.Add(EquipmentNameLabel);
            TopPanel.Controls.Add(QuantityTextBox);
            TopPanel.Controls.Add(BrandListBox);
            TopPanel.Controls.Add(EquipmentListBox);
            TopPanel.Location = new Point(20, 12);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1139, 240);
            TopPanel.TabIndex = 0;
            // 
            // QuoteButton
            // 
            QuoteButton.BackColor = SystemColors.ControlLightLight;
            QuoteButton.Font = new Font("Comic Sans MS", 9F);
            QuoteButton.Location = new Point(54, 29);
            QuoteButton.Name = "QuoteButton";
            QuoteButton.Size = new Size(123, 33);
            QuoteButton.TabIndex = 0;
            QuoteButton.Text = "&Quote";
            QuoteButton.UseVisualStyleBackColor = false;
            QuoteButton.Click += QuoteButton_Click;
            // 
            // OrderButton
            // 
            OrderButton.BackColor = SystemColors.ControlLightLight;
            OrderButton.Font = new Font("Comic Sans MS", 9F);
            OrderButton.Location = new Point(54, 71);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(123, 33);
            OrderButton.TabIndex = 1;
            OrderButton.Text = "&Order";
            OrderButton.UseVisualStyleBackColor = false;
            OrderButton.Click += OrderButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = SystemColors.ControlLightLight;
            SearchButton.Font = new Font("Comic Sans MS", 9F);
            SearchButton.Location = new Point(54, 163);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(123, 33);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "&Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = SystemColors.ControlLightLight;
            ClearButton.Font = new Font("Comic Sans MS", 9F);
            ClearButton.Location = new Point(54, 205);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(123, 33);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = SystemColors.ControlLightLight;
            ExitButton.Font = new Font("Comic Sans MS", 9F);
            ExitButton.Location = new Point(54, 251);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(123, 33);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "&Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(ExitButton);
            ButtonPanel.Controls.Add(ClearButton);
            ButtonPanel.Controls.Add(SearchButton);
            ButtonPanel.Controls.Add(OrderButton);
            ButtonPanel.Controls.Add(ProceedButton);
            ButtonPanel.Controls.Add(QuoteButton);
            ButtonPanel.Location = new Point(933, 273);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(226, 301);
            ButtonPanel.TabIndex = 2;
            // 
            // ProceedButton
            // 
            ProceedButton.BackColor = SystemColors.ButtonHighlight;
            ProceedButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProceedButton.Location = new Point(54, 118);
            ProceedButton.Name = "ProceedButton";
            ProceedButton.Size = new Size(123, 33);
            ProceedButton.TabIndex = 13;
            ProceedButton.Text = "&Proceed";
            ProceedButton.UseVisualStyleBackColor = false;
            ProceedButton.Click += ProceedButton_Click_1;
            // 
            // ClientInputGroupBox
            // 
            ClientInputGroupBox.Controls.Add(ErrorMessageLabel);
            ClientInputGroupBox.Controls.Add(TransanctionIDLabel);
            ClientInputGroupBox.Controls.Add(TransactionLabelBox);
            ClientInputGroupBox.Controls.Add(DateLabelBox);
            ClientInputGroupBox.Controls.Add(ClientNameTextBox);
            ClientInputGroupBox.Controls.Add(EircodeTextBox);
            ClientInputGroupBox.Controls.Add(EmailLabel);
            ClientInputGroupBox.Controls.Add(PhoneNumberTextBox);
            ClientInputGroupBox.Controls.Add(PhoneLabel);
            ClientInputGroupBox.Controls.Add(EmailAddressTextBox);
            ClientInputGroupBox.Controls.Add(EircodeLabel);
            ClientInputGroupBox.Controls.Add(DateLabel);
            ClientInputGroupBox.Controls.Add(ClientNameLabel);
            ClientInputGroupBox.Location = new Point(484, 254);
            ClientInputGroupBox.Name = "ClientInputGroupBox";
            ClientInputGroupBox.Size = new Size(440, 421);
            ClientInputGroupBox.TabIndex = 28;
            ClientInputGroupBox.TabStop = false;
            // 
            // ErrorMessageLabel
            // 
            ErrorMessageLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ErrorMessageLabel.ForeColor = Color.Red;
            ErrorMessageLabel.Location = new Point(16, 271);
            ErrorMessageLabel.Name = "ErrorMessageLabel";
            ErrorMessageLabel.Size = new Size(398, 38);
            ErrorMessageLabel.TabIndex = 29;
            // 
            // TransanctionIDLabel
            // 
            TransanctionIDLabel.AutoSize = true;
            TransanctionIDLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            TransanctionIDLabel.ForeColor = Color.DarkSlateGray;
            TransanctionIDLabel.Location = new Point(16, 29);
            TransanctionIDLabel.Name = "TransanctionIDLabel";
            TransanctionIDLabel.Size = new Size(119, 21);
            TransanctionIDLabel.TabIndex = 6;
            TransanctionIDLabel.Text = "Transaction ID";
            // 
            // TransactionLabelBox
            // 
            TransactionLabelBox.BackColor = SystemColors.AppWorkspace;
            TransactionLabelBox.BorderStyle = BorderStyle.Fixed3D;
            TransactionLabelBox.Enabled = false;
            TransactionLabelBox.Font = new Font("Segoe UI", 8F);
            TransactionLabelBox.Location = new Point(160, 29);
            TransactionLabelBox.Name = "TransactionLabelBox";
            TransactionLabelBox.Size = new Size(254, 25);
            TransactionLabelBox.TabIndex = 0;
            TransactionLabelBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateLabelBox
            // 
            DateLabelBox.BackColor = SystemColors.AppWorkspace;
            DateLabelBox.BorderStyle = BorderStyle.Fixed3D;
            DateLabelBox.Enabled = false;
            DateLabelBox.Font = new Font("Segoe UI", 8F);
            DateLabelBox.Location = new Point(160, 65);
            DateLabelBox.Name = "DateLabelBox";
            DateLabelBox.Size = new Size(254, 25);
            DateLabelBox.TabIndex = 1;
            DateLabelBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClientNameTextBox
            // 
            ClientNameTextBox.Font = new Font("Segoe UI", 8F);
            ClientNameTextBox.Location = new Point(159, 104);
            ClientNameTextBox.Name = "ClientNameTextBox";
            ClientNameTextBox.Size = new Size(255, 29);
            ClientNameTextBox.TabIndex = 2;
            ClientNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // EircodeTextBox
            // 
            EircodeTextBox.Font = new Font("Segoe UI", 8F);
            EircodeTextBox.Location = new Point(159, 144);
            EircodeTextBox.Name = "EircodeTextBox";
            EircodeTextBox.Size = new Size(255, 29);
            EircodeTextBox.TabIndex = 3;
            EircodeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            EmailLabel.ForeColor = Color.DarkSlateGray;
            EmailLabel.Location = new Point(16, 224);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(117, 21);
            EmailLabel.TabIndex = 11;
            EmailLabel.Text = "Email Address";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Font = new Font("Segoe UI", 8F);
            PhoneNumberTextBox.Location = new Point(159, 183);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(255, 29);
            PhoneNumberTextBox.TabIndex = 4;
            PhoneNumberTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            PhoneLabel.ForeColor = Color.DarkSlateGray;
            PhoneLabel.Location = new Point(16, 186);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(126, 21);
            PhoneLabel.TabIndex = 10;
            PhoneLabel.Text = "Phone Number";
            // 
            // EmailAddressTextBox
            // 
            EmailAddressTextBox.Font = new Font("Segoe UI", 8F);
            EmailAddressTextBox.Location = new Point(160, 225);
            EmailAddressTextBox.Name = "EmailAddressTextBox";
            EmailAddressTextBox.Size = new Size(255, 29);
            EmailAddressTextBox.TabIndex = 5;
            EmailAddressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // EircodeLabel
            // 
            EircodeLabel.AutoSize = true;
            EircodeLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            EircodeLabel.ForeColor = Color.DarkSlateGray;
            EircodeLabel.Location = new Point(16, 144);
            EircodeLabel.Name = "EircodeLabel";
            EircodeLabel.Size = new Size(67, 21);
            EircodeLabel.TabIndex = 9;
            EircodeLabel.Text = "Eircode";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            DateLabel.ForeColor = Color.DarkSlateGray;
            DateLabel.Location = new Point(17, 67);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(46, 21);
            DateLabel.TabIndex = 7;
            DateLabel.Text = "Date";
            // 
            // ClientNameLabel
            // 
            ClientNameLabel.AutoSize = true;
            ClientNameLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            ClientNameLabel.ForeColor = Color.DarkSlateGray;
            ClientNameLabel.Location = new Point(16, 107);
            ClientNameLabel.Name = "ClientNameLabel";
            ClientNameLabel.Size = new Size(105, 21);
            ClientNameLabel.TabIndex = 8;
            ClientNameLabel.Text = "Client Name";
            // 
            // QuoteToolTip
            // 
            QuoteToolTip.ToolTipTitle = "Click to generate the Quote";
            // 
            // OrderToolTip
            // 
            OrderToolTip.ToolTipTitle = "Click here to order the equipments";
            // 
            // ProceedToolTip
            // 
            ProceedToolTip.ToolTipTitle = "Click to proceed to loan";
            // 
            // SearchToolTip
            // 
            SearchToolTip.ToolTipTitle = "Click to search for orders";
            // 
            // ClearToolTip
            // 
            ClearToolTip.ToolTipTitle = "Click to cllear the form";
            // 
            // ExitToolTip
            // 
            ExitToolTip.ToolTipTitle = "Click to exit the application";
            // 
            // QuoteForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1189, 594);
            Controls.Add(ClientInputGroupBox);
            Controls.Add(OutputLabel);
            Controls.Add(ButtonPanel);
            Controls.Add(TopPanel);
            Font = new Font("Comic Sans MS", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QuoteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Quote Calculator";
            Load += HomePage_Load;
            ServiceWarrantyGroupBox.ResumeLayout(false);
            ServiceWarrantyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            ClientInputGroupBox.ResumeLayout(false);
            ClientInputGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox EquipmentListBox;
        private ListBox BrandListBox;
        private TextBox QuantityTextBox;
        private Label EquipmentNameLabel;
        private GroupBox ServiceWarrantyGroupBox;
        private RadioButton Year5RadioButton;
        private RadioButton Year3RadioButton;
        private RadioButton Year1RadioButton;
        private Label EquipmentCostLabel;
        private Label BrandNameLabel;
        private Label BrandDiscountLabel;
        private Label QuantityLabel;
        private PictureBox LogoPictureBox;
        private CheckBox ExpeditedInstallCheckBox;
        private Label OutputLabel;
        private Panel TopPanel;
        private Button QuoteButton;
        private Button OrderButton;
        private Button SearchButton;
        private Button ClearButton;
        private Button ExitButton;
        private Panel ButtonPanel;
        private RadioButton NoWarrantyButton;
        private GroupBox ClientInputGroupBox;
        private Label ErrorMessageLabel;
        private Label TransanctionIDLabel;
        private Label TransactionLabelBox;
        private Label DateLabelBox;
        private Button ProceedButton;
        private TextBox ClientNameTextBox;
        private TextBox EircodeTextBox;
        private Label EmailLabel;
        private TextBox PhoneNumberTextBox;
        private Label PhoneLabel;
        private TextBox EmailAddressTextBox;
        private Label EircodeLabel;
        private Label DateLabel;
        private Label ClientNameLabel;
        private ToolTip QuoteToolTip;
        private ToolTip OrderToolTip;
        private ToolTip ProceedToolTip;
        private ToolTip SearchToolTip;
        private ToolTip ClearToolTip;
        private ToolTip ExitToolTip;
    }
}
