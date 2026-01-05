namespace New_Quote_Generator
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            EquipmentListBox = new ListBox();
            BrandListBox = new ListBox();
            QuantityTextBox = new TextBox();
            EquipmentNameLabel = new Label();
            ServiceWarrantyGroupBox = new GroupBox();
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
            SummaryButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            ButtonPanel = new Panel();
            QuoteToolTip = new ToolTip(components);
            OrderToolTip = new ToolTip(components);
            SummaryToolTip = new ToolTip(components);
            ClearToolTip = new ToolTip(components);
            ExitToolTip = new ToolTip(components);
            ServiceWarrantyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            TopPanel.SuspendLayout();
            ButtonPanel.SuspendLayout();
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
            ServiceWarrantyGroupBox.Controls.Add(Year5RadioButton);
            ServiceWarrantyGroupBox.Controls.Add(Year3RadioButton);
            ServiceWarrantyGroupBox.Controls.Add(Year1RadioButton);
            ServiceWarrantyGroupBox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ServiceWarrantyGroupBox.Location = new Point(854, 34);
            ServiceWarrantyGroupBox.Name = "ServiceWarrantyGroupBox";
            ServiceWarrantyGroupBox.Size = new Size(229, 136);
            ServiceWarrantyGroupBox.TabIndex = 3;
            ServiceWarrantyGroupBox.TabStop = false;
            ServiceWarrantyGroupBox.Text = "Service Warranty";
            // 
            // Year5RadioButton
            // 
            Year5RadioButton.AutoSize = true;
            Year5RadioButton.Location = new Point(20, 101);
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
            Year3RadioButton.Location = new Point(20, 67);
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
            Year1RadioButton.Location = new Point(20, 34);
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
            ExpeditedInstallCheckBox.Location = new Point(873, 186);
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
            OutputLabel.Location = new Point(49, 258);
            OutputLabel.Margin = new Padding(3);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(771, 304);
            OutputLabel.TabIndex = 0;
            OutputLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            QuoteButton.Location = new Point(98, 41);
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
            OrderButton.Location = new Point(98, 83);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(123, 33);
            OrderButton.TabIndex = 1;
            OrderButton.Text = "&Order";
            OrderButton.UseVisualStyleBackColor = false;
            OrderButton.Click += OrderButton_Click;
            // 
            // SummaryButton
            // 
            SummaryButton.BackColor = SystemColors.ControlLightLight;
            SummaryButton.Font = new Font("Comic Sans MS", 9F);
            SummaryButton.Location = new Point(98, 125);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(123, 33);
            SummaryButton.TabIndex = 2;
            SummaryButton.Text = "&Summary";
            SummaryButton.UseVisualStyleBackColor = false;
            SummaryButton.Click += SummaryButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = SystemColors.ControlLightLight;
            ClearButton.Font = new Font("Comic Sans MS", 9F);
            ClearButton.Location = new Point(98, 167);
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
            ExitButton.Location = new Point(98, 213);
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
            ButtonPanel.Controls.Add(SummaryButton);
            ButtonPanel.Controls.Add(OrderButton);
            ButtonPanel.Controls.Add(QuoteButton);
            ButtonPanel.Location = new Point(835, 263);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(324, 301);
            ButtonPanel.TabIndex = 2;
            // 
            // QuoteToolTip
            // 
            QuoteToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // OrderToolTip
            // 
            OrderToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // SummaryToolTip
            // 
            SummaryToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // ClearToolTip
            // 
            ClearToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // ExitToolTip
            // 
            ExitToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1189, 576);
            Controls.Add(OutputLabel);
            Controls.Add(ButtonPanel);
            Controls.Add(TopPanel);
            Font = new Font("Comic Sans MS", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "form1";
            Text = "Sales Quote Calculator";
            Load += HomePage_Load;
            ServiceWarrantyGroupBox.ResumeLayout(false);
            ServiceWarrantyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ButtonPanel.ResumeLayout(false);
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
        private Button SummaryButton;
        private Button ClearButton;
        private Button ExitButton;
        private Panel ButtonPanel;
        private ToolTip QuoteToolTip;
        private ToolTip OrderToolTip;
        private ToolTip SummaryToolTip;
        private ToolTip ClearToolTip;
        private ToolTip ExitToolTip;
    }
}
