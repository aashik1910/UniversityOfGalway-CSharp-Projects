namespace Finance_Form
{
    partial class LoanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanForm));
            OrderDetailsGroupBox = new GroupBox();
            TotalCostLabel = new Label();
            TotalCostTextBox = new Label();
            InstallationLabel = new Label();
            InstallationBox = new Label();
            WarrantyLabel = new Label();
            BrandLabel = new Label();
            QuantityLabel = new Label();
            QuantityBox = new Label();
            EquipmentLabel = new Label();
            WarrantyBox = new Label();
            EquipmentBox = new Label();
            BrandBox = new Label();
            CustomerGroupBox = new GroupBox();
            DateDetailLabel = new Label();
            DateDetailTextBox = new Label();
            TransactionIdDetailLabel = new Label();
            TransactionIdDetailTextBox = new Label();
            EmailAddressDetailLabel = new Label();
            EircodeDetailLabel = new Label();
            PhoneNumberDetailLabel = new Label();
            PhoneNumberDetailTextBox = new Label();
            ClientNameDetail = new Label();
            EmailAddressDetailTextBox = new Label();
            ClientNameDetailTextBox = new Label();
            EircodeDetailTextBox = new Label();
            LoanGroupBox = new GroupBox();
            LoanCalculatorLabel = new Label();
            LoanOutputLabel = new Label();
            NoLoanRadioButton = new RadioButton();
            RadioButtonFiveYear = new RadioButton();
            RadioButtonThreeYear = new RadioButton();
            RadioButtonOneYear = new RadioButton();
            ButtonClose = new Button();
            SubmitButton = new Button();
            LogoPictureBox = new PictureBox();
            ErrorMessageLabel = new Label();
            SubmitToolTip = new ToolTip(components);
            CloseToolTip = new ToolTip(components);
            BackButton = new Button();
            BackButtonToolTip = new ToolTip(components);
            OrderDetailsGroupBox.SuspendLayout();
            CustomerGroupBox.SuspendLayout();
            LoanGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // OrderDetailsGroupBox
            // 
            OrderDetailsGroupBox.BackColor = SystemColors.AppWorkspace;
            OrderDetailsGroupBox.Controls.Add(TotalCostLabel);
            OrderDetailsGroupBox.Controls.Add(TotalCostTextBox);
            OrderDetailsGroupBox.Controls.Add(InstallationLabel);
            OrderDetailsGroupBox.Controls.Add(InstallationBox);
            OrderDetailsGroupBox.Controls.Add(WarrantyLabel);
            OrderDetailsGroupBox.Controls.Add(BrandLabel);
            OrderDetailsGroupBox.Controls.Add(QuantityLabel);
            OrderDetailsGroupBox.Controls.Add(QuantityBox);
            OrderDetailsGroupBox.Controls.Add(EquipmentLabel);
            OrderDetailsGroupBox.Controls.Add(WarrantyBox);
            OrderDetailsGroupBox.Controls.Add(EquipmentBox);
            OrderDetailsGroupBox.Controls.Add(BrandBox);
            OrderDetailsGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            OrderDetailsGroupBox.Location = new Point(661, 27);
            OrderDetailsGroupBox.Name = "OrderDetailsGroupBox";
            OrderDetailsGroupBox.Size = new Size(426, 262);
            OrderDetailsGroupBox.TabIndex = 12;
            OrderDetailsGroupBox.TabStop = false;
            OrderDetailsGroupBox.Text = "Order Details";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Location = new Point(17, 222);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(96, 25);
            TotalCostLabel.TabIndex = 25;
            TotalCostLabel.Text = "Total Cost";
            // 
            // TotalCostTextBox
            // 
            TotalCostTextBox.BackColor = SystemColors.ActiveCaption;
            TotalCostTextBox.BorderStyle = BorderStyle.Fixed3D;
            TotalCostTextBox.Enabled = false;
            TotalCostTextBox.ForeColor = Color.OrangeRed;
            TotalCostTextBox.Location = new Point(190, 222);
            TotalCostTextBox.Name = "TotalCostTextBox";
            TotalCostTextBox.Size = new Size(170, 25);
            TotalCostTextBox.TabIndex = 24;
            TotalCostTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InstallationLabel
            // 
            InstallationLabel.AutoSize = true;
            InstallationLabel.Location = new Point(18, 183);
            InstallationLabel.Name = "InstallationLabel";
            InstallationLabel.Size = new Size(154, 25);
            InstallationLabel.TabIndex = 23;
            InstallationLabel.Text = "Installation Type";
            // 
            // InstallationBox
            // 
            InstallationBox.BackColor = SystemColors.ActiveCaption;
            InstallationBox.BorderStyle = BorderStyle.Fixed3D;
            InstallationBox.Enabled = false;
            InstallationBox.ForeColor = SystemColors.WindowText;
            InstallationBox.Location = new Point(190, 184);
            InstallationBox.Name = "InstallationBox";
            InstallationBox.Size = new Size(170, 25);
            InstallationBox.TabIndex = 22;
            InstallationBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WarrantyLabel
            // 
            WarrantyLabel.AutoSize = true;
            WarrantyLabel.Location = new Point(18, 143);
            WarrantyLabel.Name = "WarrantyLabel";
            WarrantyLabel.Size = new Size(91, 25);
            WarrantyLabel.TabIndex = 21;
            WarrantyLabel.Text = "Warranty";
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.Location = new Point(18, 70);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(63, 25);
            BrandLabel.TabIndex = 17;
            BrandLabel.Text = "Brand";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Location = new Point(17, 105);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(87, 25);
            QuantityLabel.TabIndex = 20;
            QuantityLabel.Text = "Quantity";
            // 
            // QuantityBox
            // 
            QuantityBox.BackColor = SystemColors.ActiveCaption;
            QuantityBox.BorderStyle = BorderStyle.Fixed3D;
            QuantityBox.Enabled = false;
            QuantityBox.ForeColor = SystemColors.WindowText;
            QuantityBox.Location = new Point(190, 106);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(170, 25);
            QuantityBox.TabIndex = 18;
            QuantityBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EquipmentLabel
            // 
            EquipmentLabel.AutoSize = true;
            EquipmentLabel.Location = new Point(17, 34);
            EquipmentLabel.Name = "EquipmentLabel";
            EquipmentLabel.Size = new Size(104, 25);
            EquipmentLabel.TabIndex = 16;
            EquipmentLabel.Text = "Equipment";
            // 
            // WarrantyBox
            // 
            WarrantyBox.BackColor = SystemColors.ActiveCaption;
            WarrantyBox.BorderStyle = BorderStyle.Fixed3D;
            WarrantyBox.Enabled = false;
            WarrantyBox.ForeColor = SystemColors.WindowText;
            WarrantyBox.Location = new Point(190, 145);
            WarrantyBox.Name = "WarrantyBox";
            WarrantyBox.Size = new Size(170, 25);
            WarrantyBox.TabIndex = 19;
            WarrantyBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EquipmentBox
            // 
            EquipmentBox.BackColor = SystemColors.ActiveCaption;
            EquipmentBox.BorderStyle = BorderStyle.Fixed3D;
            EquipmentBox.Enabled = false;
            EquipmentBox.ForeColor = SystemColors.WindowText;
            EquipmentBox.Location = new Point(190, 34);
            EquipmentBox.Name = "EquipmentBox";
            EquipmentBox.Size = new Size(170, 25);
            EquipmentBox.TabIndex = 14;
            EquipmentBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BrandBox
            // 
            BrandBox.BackColor = SystemColors.ActiveCaption;
            BrandBox.BorderStyle = BorderStyle.Fixed3D;
            BrandBox.Enabled = false;
            BrandBox.ForeColor = SystemColors.WindowText;
            BrandBox.Location = new Point(190, 70);
            BrandBox.Name = "BrandBox";
            BrandBox.Size = new Size(170, 25);
            BrandBox.TabIndex = 15;
            BrandBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerGroupBox
            // 
            CustomerGroupBox.BackColor = SystemColors.AppWorkspace;
            CustomerGroupBox.Controls.Add(DateDetailLabel);
            CustomerGroupBox.Controls.Add(DateDetailTextBox);
            CustomerGroupBox.Controls.Add(TransactionIdDetailLabel);
            CustomerGroupBox.Controls.Add(TransactionIdDetailTextBox);
            CustomerGroupBox.Controls.Add(EmailAddressDetailLabel);
            CustomerGroupBox.Controls.Add(EircodeDetailLabel);
            CustomerGroupBox.Controls.Add(PhoneNumberDetailLabel);
            CustomerGroupBox.Controls.Add(PhoneNumberDetailTextBox);
            CustomerGroupBox.Controls.Add(ClientNameDetail);
            CustomerGroupBox.Controls.Add(EmailAddressDetailTextBox);
            CustomerGroupBox.Controls.Add(ClientNameDetailTextBox);
            CustomerGroupBox.Controls.Add(EircodeDetailTextBox);
            CustomerGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CustomerGroupBox.Location = new Point(56, 27);
            CustomerGroupBox.Name = "CustomerGroupBox";
            CustomerGroupBox.Size = new Size(451, 262);
            CustomerGroupBox.TabIndex = 26;
            CustomerGroupBox.TabStop = false;
            CustomerGroupBox.Text = "Customer Details";
            // 
            // DateDetailLabel
            // 
            DateDetailLabel.AutoSize = true;
            DateDetailLabel.Location = new Point(17, 222);
            DateDetailLabel.Name = "DateDetailLabel";
            DateDetailLabel.Size = new Size(52, 25);
            DateDetailLabel.TabIndex = 25;
            DateDetailLabel.Text = "Date";
            // 
            // DateDetailTextBox
            // 
            DateDetailTextBox.BackColor = SystemColors.ActiveCaption;
            DateDetailTextBox.BorderStyle = BorderStyle.Fixed3D;
            DateDetailTextBox.Enabled = false;
            DateDetailTextBox.ForeColor = Color.Red;
            DateDetailTextBox.Location = new Point(195, 222);
            DateDetailTextBox.Name = "DateDetailTextBox";
            DateDetailTextBox.Size = new Size(209, 25);
            DateDetailTextBox.TabIndex = 24;
            DateDetailTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TransactionIdDetailLabel
            // 
            TransactionIdDetailLabel.AutoSize = true;
            TransactionIdDetailLabel.Location = new Point(18, 183);
            TransactionIdDetailLabel.Name = "TransactionIdDetailLabel";
            TransactionIdDetailLabel.Size = new Size(135, 25);
            TransactionIdDetailLabel.TabIndex = 23;
            TransactionIdDetailLabel.Text = "Transaction ID";
            // 
            // TransactionIdDetailTextBox
            // 
            TransactionIdDetailTextBox.BackColor = SystemColors.ActiveCaption;
            TransactionIdDetailTextBox.BorderStyle = BorderStyle.Fixed3D;
            TransactionIdDetailTextBox.Enabled = false;
            TransactionIdDetailTextBox.ForeColor = SystemColors.WindowText;
            TransactionIdDetailTextBox.Location = new Point(195, 184);
            TransactionIdDetailTextBox.Name = "TransactionIdDetailTextBox";
            TransactionIdDetailTextBox.Size = new Size(209, 25);
            TransactionIdDetailTextBox.TabIndex = 22;
            TransactionIdDetailTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmailAddressDetailLabel
            // 
            EmailAddressDetailLabel.AutoSize = true;
            EmailAddressDetailLabel.Location = new Point(18, 143);
            EmailAddressDetailLabel.Name = "EmailAddressDetailLabel";
            EmailAddressDetailLabel.Size = new Size(131, 25);
            EmailAddressDetailLabel.TabIndex = 21;
            EmailAddressDetailLabel.Text = "Email Address";
            // 
            // EircodeDetailLabel
            // 
            EircodeDetailLabel.AutoSize = true;
            EircodeDetailLabel.Location = new Point(18, 70);
            EircodeDetailLabel.Name = "EircodeDetailLabel";
            EircodeDetailLabel.Size = new Size(75, 25);
            EircodeDetailLabel.TabIndex = 17;
            EircodeDetailLabel.Text = "Eircode";
            // 
            // PhoneNumberDetailLabel
            // 
            PhoneNumberDetailLabel.AutoSize = true;
            PhoneNumberDetailLabel.Location = new Point(17, 105);
            PhoneNumberDetailLabel.Name = "PhoneNumberDetailLabel";
            PhoneNumberDetailLabel.Size = new Size(140, 25);
            PhoneNumberDetailLabel.TabIndex = 20;
            PhoneNumberDetailLabel.Text = "Phone Number";
            // 
            // PhoneNumberDetailTextBox
            // 
            PhoneNumberDetailTextBox.BackColor = SystemColors.ActiveCaption;
            PhoneNumberDetailTextBox.BorderStyle = BorderStyle.Fixed3D;
            PhoneNumberDetailTextBox.Enabled = false;
            PhoneNumberDetailTextBox.ForeColor = SystemColors.WindowText;
            PhoneNumberDetailTextBox.Location = new Point(195, 106);
            PhoneNumberDetailTextBox.Name = "PhoneNumberDetailTextBox";
            PhoneNumberDetailTextBox.Size = new Size(209, 25);
            PhoneNumberDetailTextBox.TabIndex = 18;
            PhoneNumberDetailTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClientNameDetail
            // 
            ClientNameDetail.AutoSize = true;
            ClientNameDetail.Location = new Point(17, 34);
            ClientNameDetail.Name = "ClientNameDetail";
            ClientNameDetail.Size = new Size(116, 25);
            ClientNameDetail.TabIndex = 16;
            ClientNameDetail.Text = "Client Name";
            // 
            // EmailAddressDetailTextBox
            // 
            EmailAddressDetailTextBox.BackColor = SystemColors.ActiveCaption;
            EmailAddressDetailTextBox.BorderStyle = BorderStyle.Fixed3D;
            EmailAddressDetailTextBox.Enabled = false;
            EmailAddressDetailTextBox.ForeColor = SystemColors.WindowText;
            EmailAddressDetailTextBox.Location = new Point(195, 145);
            EmailAddressDetailTextBox.Name = "EmailAddressDetailTextBox";
            EmailAddressDetailTextBox.Size = new Size(209, 25);
            EmailAddressDetailTextBox.TabIndex = 19;
            EmailAddressDetailTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClientNameDetailTextBox
            // 
            ClientNameDetailTextBox.BackColor = SystemColors.ActiveCaption;
            ClientNameDetailTextBox.BorderStyle = BorderStyle.Fixed3D;
            ClientNameDetailTextBox.Enabled = false;
            ClientNameDetailTextBox.ForeColor = SystemColors.WindowText;
            ClientNameDetailTextBox.Location = new Point(195, 34);
            ClientNameDetailTextBox.Name = "ClientNameDetailTextBox";
            ClientNameDetailTextBox.Size = new Size(209, 25);
            ClientNameDetailTextBox.TabIndex = 14;
            ClientNameDetailTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EircodeDetailTextBox
            // 
            EircodeDetailTextBox.BackColor = SystemColors.ActiveCaption;
            EircodeDetailTextBox.BorderStyle = BorderStyle.Fixed3D;
            EircodeDetailTextBox.Enabled = false;
            EircodeDetailTextBox.ForeColor = SystemColors.WindowText;
            EircodeDetailTextBox.Location = new Point(195, 70);
            EircodeDetailTextBox.Name = "EircodeDetailTextBox";
            EircodeDetailTextBox.Size = new Size(209, 25);
            EircodeDetailTextBox.TabIndex = 15;
            EircodeDetailTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoanGroupBox
            // 
            LoanGroupBox.Controls.Add(LoanCalculatorLabel);
            LoanGroupBox.Controls.Add(LoanOutputLabel);
            LoanGroupBox.Controls.Add(NoLoanRadioButton);
            LoanGroupBox.Controls.Add(RadioButtonFiveYear);
            LoanGroupBox.Controls.Add(RadioButtonThreeYear);
            LoanGroupBox.Controls.Add(RadioButtonOneYear);
            LoanGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LoanGroupBox.Location = new Point(122, 309);
            LoanGroupBox.Name = "LoanGroupBox";
            LoanGroupBox.Size = new Size(886, 207);
            LoanGroupBox.TabIndex = 28;
            LoanGroupBox.TabStop = false;
            LoanGroupBox.Text = "Loan FInance Option";
            // 
            // LoanCalculatorLabel
            // 
            LoanCalculatorLabel.Location = new Point(285, 17);
            LoanCalculatorLabel.Name = "LoanCalculatorLabel";
            LoanCalculatorLabel.Size = new Size(304, 33);
            LoanCalculatorLabel.TabIndex = 33;
            LoanCalculatorLabel.Text = "Loan Calculation:";
            // 
            // LoanOutputLabel
            // 
            LoanOutputLabel.BackColor = SystemColors.ActiveCaption;
            LoanOutputLabel.ForeColor = SystemColors.ActiveCaptionText;
            LoanOutputLabel.Location = new Point(285, 50);
            LoanOutputLabel.Name = "LoanOutputLabel";
            LoanOutputLabel.Size = new Size(566, 129);
            LoanOutputLabel.TabIndex = 32;
            // 
            // NoLoanRadioButton
            // 
            NoLoanRadioButton.AutoCheck = false;
            NoLoanRadioButton.AutoSize = true;
            NoLoanRadioButton.Location = new Point(30, 147);
            NoLoanRadioButton.Name = "NoLoanRadioButton";
            NoLoanRadioButton.Size = new Size(190, 29);
            NoLoanRadioButton.TabIndex = 3;
            NoLoanRadioButton.TabStop = true;
            NoLoanRadioButton.Text = "No Loan Required";
            NoLoanRadioButton.UseVisualStyleBackColor = true;
            NoLoanRadioButton.CheckedChanged += NoLoanRadioButton_CheckedChanged;
            // 
            // RadioButtonFiveYear
            // 
            RadioButtonFiveYear.AutoCheck = false;
            RadioButtonFiveYear.AutoSize = true;
            RadioButtonFiveYear.Location = new Point(30, 112);
            RadioButtonFiveYear.Name = "RadioButtonFiveYear";
            RadioButtonFiveYear.Size = new Size(135, 29);
            RadioButtonFiveYear.TabIndex = 2;
            RadioButtonFiveYear.TabStop = true;
            RadioButtonFiveYear.Text = "Term 5 Year";
            RadioButtonFiveYear.UseVisualStyleBackColor = true;
            RadioButtonFiveYear.CheckedChanged += RadioButtonFiveYear_CheckedChanged;
            // 
            // RadioButtonThreeYear
            // 
            RadioButtonThreeYear.AutoCheck = false;
            RadioButtonThreeYear.AutoSize = true;
            RadioButtonThreeYear.Location = new Point(30, 75);
            RadioButtonThreeYear.Name = "RadioButtonThreeYear";
            RadioButtonThreeYear.Size = new Size(135, 29);
            RadioButtonThreeYear.TabIndex = 1;
            RadioButtonThreeYear.TabStop = true;
            RadioButtonThreeYear.Text = "Term 3 Year";
            RadioButtonThreeYear.UseVisualStyleBackColor = true;
            RadioButtonThreeYear.CheckedChanged += RadioButtonThreeYear_CheckedChanged;
            // 
            // RadioButtonOneYear
            // 
            RadioButtonOneYear.AutoCheck = false;
            RadioButtonOneYear.AutoSize = true;
            RadioButtonOneYear.Location = new Point(30, 36);
            RadioButtonOneYear.Name = "RadioButtonOneYear";
            RadioButtonOneYear.Size = new Size(135, 29);
            RadioButtonOneYear.TabIndex = 0;
            RadioButtonOneYear.TabStop = true;
            RadioButtonOneYear.Text = "Term 1 Year";
            RadioButtonOneYear.UseVisualStyleBackColor = true;
            RadioButtonOneYear.CheckedChanged += RadioButtonOneYear_CheckedChanged;
            // 
            // ButtonClose
            // 
            ButtonClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonClose.Location = new Point(963, 535);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(173, 34);
            ButtonClose.TabIndex = 31;
            ButtonClose.Text = "&Close";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SubmitButton.Location = new Point(767, 535);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(173, 34);
            SubmitButton.TabIndex = 30;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Image = (Image)resources.GetObject("LogoPictureBox.Image");
            LogoPictureBox.Location = new Point(523, 133);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(125, 65);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoPictureBox.TabIndex = 32;
            LogoPictureBox.TabStop = false;
            // 
            // ErrorMessageLabel
            // 
            ErrorMessageLabel.Location = new Point(199, 537);
            ErrorMessageLabel.Name = "ErrorMessageLabel";
            ErrorMessageLabel.Size = new Size(559, 24);
            ErrorMessageLabel.TabIndex = 33;
            // 
            // SubmitToolTip
            // 
            SubmitToolTip.ToolTipTitle = "Click to submit the order";
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BackButton.Location = new Point(16, 530);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(173, 34);
            BackButton.TabIndex = 34;
            BackButton.Text = "&Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // LoanForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1189, 594);
            Controls.Add(BackButton);
            Controls.Add(ErrorMessageLabel);
            Controls.Add(LogoPictureBox);
            Controls.Add(ButtonClose);
            Controls.Add(SubmitButton);
            Controls.Add(LoanGroupBox);
            Controls.Add(CustomerGroupBox);
            Controls.Add(OrderDetailsGroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loan Calculator";
            Load += LoanForm_Load;
            OrderDetailsGroupBox.ResumeLayout(false);
            OrderDetailsGroupBox.PerformLayout();
            CustomerGroupBox.ResumeLayout(false);
            CustomerGroupBox.PerformLayout();
            LoanGroupBox.ResumeLayout(false);
            LoanGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox OrderDetailsGroupBox;
        private Label InstallationLabel;
        private Label InstallationBox;
        private Label WarrantyLabel;
        private Label BrandLabel;
        private Label QuantityLabel;
        private Label QuantityBox;
        private Label EquipmentLabel;
        private Label WarrantyBox;
        private Label EquipmentBox;
        private Label BrandBox;
        private Label TotalCostLabel;
        private Label TotalCostTextBox;
        private GroupBox CustomerGroupBox;
        private Label DateDetailLabel;
        private Label DateDetailTextBox;
        private Label TransactionIdDetailLabel;
        private Label TransactionIdDetailTextBox;
        private Label EmailAddressDetailLabel;
        private Label EircodeDetailLabel;
        private Label PhoneNumberDetailLabel;
        private Label PhoneNumberDetailTextBox;
        private Label ClientNameDetail;
        private Label EmailAddressDetailTextBox;
        private Label ClientNameDetailTextBox;
        private Label EircodeDetailTextBox;
        private GroupBox LoanGroupBox;
        private Button ButtonClose;
        private Button SubmitButton;
        private RadioButton RadioButtonFiveYear;
        private RadioButton RadioButtonThreeYear;
        private RadioButton RadioButtonOneYear;
        private RadioButton NoLoanRadioButton;
        private Label LoanCalculatorLabel;
        private Label LoanOutputLabel;
        private PictureBox LogoPictureBox;
        private Label ErrorMessageLabel;
        private ToolTip SubmitToolTip;
        private ToolTip CloseToolTip;
        private Button BackButton;
        private ToolTip BackButtonToolTip;
    }
}