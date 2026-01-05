namespace FinalAssignmentA4
{
    partial class CheckoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm));
            BookListBox = new ListBox();
            TypeListBox = new ListBox();
            PriceTextBox = new Label();
            StockLabel = new Label();
            PriceDisplayLabel = new Label();
            StockDisplayLabel = new Label();
            NumberQuantity = new NumericUpDown();
            QuantityLabel = new Label();
            AddToOrderButton = new Button();
            CurrentBasketListBox = new ListBox();
            CurrentBasketLabel = new Label();
            RemoveButton = new Button();
            ClearButton = new Button();
            TotalCostLabel = new Label();
            TotalCostDisplayLabel = new Label();
            Checkoutbutton = new Button();
            BookListLabel = new Label();
            LogoPictureBox = new PictureBox();
            TypeLabel = new Label();
            ReportSearchButton = new Button();
            DiscountLabel = new Label();
            LogoutButton = new Button();
            DiscountDisplayLabel = new Label();
            AddToOrderToolTip = new ToolTip(components);
            RemoveToolTip = new ToolTip(components);
            ClearToolTip = new ToolTip(components);
            LogoutToolTip = new ToolTip(components);
            CheckoutToolTip = new ToolTip(components);
            ReportSearchToolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)NumberQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // BookListBox
            // 
            BookListBox.FormattingEnabled = true;
            BookListBox.ItemHeight = 25;
            BookListBox.Location = new Point(12, 56);
            BookListBox.Name = "BookListBox";
            BookListBox.Size = new Size(222, 404);
            BookListBox.TabIndex = 0;
            BookListBox.SelectedIndexChanged += BookListBox_SelectedIndexChanged;
            // 
            // TypeListBox
            // 
            TypeListBox.FormattingEnabled = true;
            TypeListBox.ItemHeight = 25;
            TypeListBox.Location = new Point(252, 56);
            TypeListBox.Name = "TypeListBox";
            TypeListBox.Size = new Size(233, 404);
            TypeListBox.TabIndex = 1;
            TypeListBox.SelectedIndexChanged += TypeListBox_SelectedIndexChanged;
            // 
            // PriceTextBox
            // 
            PriceTextBox.AutoSize = true;
            PriceTextBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceTextBox.Location = new Point(491, 50);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(56, 22);
            PriceTextBox.TabIndex = 2;
            PriceTextBox.Text = "Price:";
            // 
            // StockLabel
            // 
            StockLabel.AutoSize = true;
            StockLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StockLabel.Location = new Point(491, 89);
            StockLabel.Name = "StockLabel";
            StockLabel.Size = new Size(60, 22);
            StockLabel.TabIndex = 3;
            StockLabel.Text = "Stock:";
            // 
            // PriceDisplayLabel
            // 
            PriceDisplayLabel.AutoSize = true;
            PriceDisplayLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceDisplayLabel.Location = new Point(579, 50);
            PriceDisplayLabel.Name = "PriceDisplayLabel";
            PriceDisplayLabel.Size = new Size(71, 25);
            PriceDisplayLabel.TabIndex = 4;
            PriceDisplayLabel.Text = "€0.00";
            // 
            // StockDisplayLabel
            // 
            StockDisplayLabel.AutoSize = true;
            StockDisplayLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StockDisplayLabel.Location = new Point(582, 89);
            StockDisplayLabel.Name = "StockDisplayLabel";
            StockDisplayLabel.Size = new Size(25, 25);
            StockDisplayLabel.TabIndex = 5;
            StockDisplayLabel.Text = "0";
            // 
            // NumberQuantity
            // 
            NumberQuantity.Location = new Point(579, 127);
            NumberQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberQuantity.Name = "NumberQuantity";
            NumberQuantity.Size = new Size(98, 31);
            NumberQuantity.TabIndex = 2;
            NumberQuantity.TextAlign = HorizontalAlignment.Center;
            NumberQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // QuantityLabel
            // 
            QuantityLabel.AccessibleDescription = "";
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuantityLabel.Location = new Point(491, 130);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(82, 22);
            QuantityLabel.TabIndex = 7;
            QuantityLabel.Text = "Quantity:";
            // 
            // AddToOrderButton
            // 
            AddToOrderButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddToOrderButton.Location = new Point(513, 181);
            AddToOrderButton.Name = "AddToOrderButton";
            AddToOrderButton.Size = new Size(164, 42);
            AddToOrderButton.TabIndex = 3;
            AddToOrderButton.Text = "&Add to Order";
            AddToOrderToolTip.SetToolTip(AddToOrderButton, "Click Here to Add the Product to Basket");
            AddToOrderButton.UseVisualStyleBackColor = true;
            AddToOrderButton.Click += AddToOrderButton_Click;
            // 
            // CurrentBasketListBox
            // 
            CurrentBasketListBox.FormattingEnabled = true;
            CurrentBasketListBox.ItemHeight = 25;
            CurrentBasketListBox.Location = new Point(708, 54);
            CurrentBasketListBox.Name = "CurrentBasketListBox";
            CurrentBasketListBox.Size = new Size(423, 254);
            CurrentBasketListBox.TabIndex = 4;
            // 
            // CurrentBasketLabel
            // 
            CurrentBasketLabel.AutoSize = true;
            CurrentBasketLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CurrentBasketLabel.Location = new Point(704, 27);
            CurrentBasketLabel.Name = "CurrentBasketLabel";
            CurrentBasketLabel.Size = new Size(169, 25);
            CurrentBasketLabel.TabIndex = 10;
            CurrentBasketLabel.Text = "Current Basket";
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(708, 320);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(120, 34);
            RemoveButton.TabIndex = 5;
            RemoveButton.Text = "&Remove Item";
            RemoveToolTip.SetToolTip(RemoveButton, "Click Here To Remove the Product");
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(845, 320);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(120, 34);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "&Clear";
            ClearToolTip.SetToolTip(ClearButton, "Click Here to Clear the Basket");
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalCostLabel.Location = new Point(703, 370);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(80, 29);
            TotalCostLabel.TabIndex = 13;
            TotalCostLabel.Text = "Total:";
            // 
            // TotalCostDisplayLabel
            // 
            TotalCostDisplayLabel.AutoSize = true;
            TotalCostDisplayLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalCostDisplayLabel.ForeColor = Color.Maroon;
            TotalCostDisplayLabel.Location = new Point(777, 370);
            TotalCostDisplayLabel.Name = "TotalCostDisplayLabel";
            TotalCostDisplayLabel.Size = new Size(76, 29);
            TotalCostDisplayLabel.TabIndex = 14;
            TotalCostDisplayLabel.Text = "€0.00";
            // 
            // Checkoutbutton
            // 
            Checkoutbutton.BackColor = Color.ForestGreen;
            Checkoutbutton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Checkoutbutton.ForeColor = Color.White;
            Checkoutbutton.Location = new Point(981, 362);
            Checkoutbutton.Name = "Checkoutbutton";
            Checkoutbutton.Size = new Size(150, 45);
            Checkoutbutton.TabIndex = 7;
            Checkoutbutton.Text = "Check&Out";
            CheckoutToolTip.SetToolTip(Checkoutbutton, "Click Here to Checkout the Products");
            Checkoutbutton.UseVisualStyleBackColor = false;
            Checkoutbutton.Click += Checkoutbutton_Click;
            // 
            // BookListLabel
            // 
            BookListLabel.AutoSize = true;
            BookListLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookListLabel.Location = new Point(12, 27);
            BookListLabel.Name = "BookListLabel";
            BookListLabel.Size = new Size(110, 25);
            BookListLabel.TabIndex = 22;
            BookListLabel.Text = "Book List";
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Image = (Image)resources.GetObject("LogoPictureBox.Image");
            LogoPictureBox.Location = new Point(513, 250);
            LogoPictureBox.Margin = new Padding(0);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(164, 138);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPictureBox.TabIndex = 23;
            LogoPictureBox.TabStop = false;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TypeLabel.Location = new Point(250, 27);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(124, 25);
            TypeLabel.TabIndex = 24;
            TypeLabel.Text = "Book Type";
            // 
            // ReportSearchButton
            // 
            ReportSearchButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReportSearchButton.Location = new Point(708, 481);
            ReportSearchButton.Name = "ReportSearchButton";
            ReportSearchButton.Size = new Size(423, 39);
            ReportSearchButton.TabIndex = 25;
            ReportSearchButton.Text = "Reports and &Search";
            ReportSearchToolTip.SetToolTip(ReportSearchButton, "Click Here to Search or Generate Report");
            ReportSearchButton.UseVisualStyleBackColor = true;
            ReportSearchButton.Click += ReportSearchButton_Click;
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Font = new Font("Bauhaus 93", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiscountLabel.ForeColor = Color.Red;
            DiscountLabel.Location = new Point(12, 481);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(306, 46);
            DiscountLabel.TabIndex = 26;
            DiscountLabel.Text = "5% off on total value above €25\r\n10% off on total value above €75";
            // 
            // LogoutButton
            // 
            LogoutButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            LogoutButton.ForeColor = SystemColors.ActiveCaptionText;
            LogoutButton.Location = new Point(520, 484);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(130, 34);
            LogoutButton.TabIndex = 27;
            LogoutButton.Text = "&Logout";
            LogoutToolTip.SetToolTip(LogoutButton, "Click Here to LogOut the Application");
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // DiscountDisplayLabel
            // 
            DiscountDisplayLabel.Font = new Font("Elephant", 9.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DiscountDisplayLabel.ForeColor = Color.SteelBlue;
            DiscountDisplayLabel.Location = new Point(708, 435);
            DiscountDisplayLabel.Name = "DiscountDisplayLabel";
            DiscountDisplayLabel.Size = new Size(423, 35);
            DiscountDisplayLabel.TabIndex = 28;
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1154, 553);
            Controls.Add(DiscountDisplayLabel);
            Controls.Add(LogoutButton);
            Controls.Add(DiscountLabel);
            Controls.Add(ReportSearchButton);
            Controls.Add(TypeLabel);
            Controls.Add(LogoPictureBox);
            Controls.Add(BookListLabel);
            Controls.Add(Checkoutbutton);
            Controls.Add(TotalCostDisplayLabel);
            Controls.Add(TotalCostLabel);
            Controls.Add(ClearButton);
            Controls.Add(RemoveButton);
            Controls.Add(CurrentBasketLabel);
            Controls.Add(CurrentBasketListBox);
            Controls.Add(AddToOrderButton);
            Controls.Add(QuantityLabel);
            Controls.Add(NumberQuantity);
            Controls.Add(StockDisplayLabel);
            Controls.Add(PriceDisplayLabel);
            Controls.Add(StockLabel);
            Controls.Add(PriceTextBox);
            Controls.Add(TypeListBox);
            Controls.Add(BookListBox);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CheckoutForm";
            Text = "Ishaan Book House";
            Load += CheckoutForm_Load;
            ((System.ComponentModel.ISupportInitialize)NumberQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        // Inventory Selection
        private System.Windows.Forms.ListBox BookListBox; 
        private System.Windows.Forms.ListBox TypeListBox;    
        private System.Windows.Forms.Label PriceTextBox;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.Label PriceDisplayLabel;     
        private System.Windows.Forms.Label StockDisplayLabel;     
        private System.Windows.Forms.NumericUpDown NumberQuantity; 
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Button AddToOrderButton; 

        // Basket / Transaction
        private System.Windows.Forms.ListBox CurrentBasketListBox;    
        private System.Windows.Forms.Label CurrentBasketLabel;
        private System.Windows.Forms.Button RemoveButton; 
        private System.Windows.Forms.Button ClearButton; 
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label TotalCostDisplayLabel;      
        private System.Windows.Forms.Button Checkoutbutton; 
        private System.Windows.Forms.Label BookListLabel;
        private PictureBox LogoPictureBox;
        private Label TypeLabel;
        private Button ReportSearchButton;
        private Label DiscountLabel;
        private Button LogoutButton;
        private Label DiscountDisplayLabel;
        private ToolTip AddToOrderToolTip;
        private ToolTip RemoveToolTip;
        private ToolTip ClearToolTip;
        private ToolTip LogoutToolTip;
        private ToolTip CheckoutToolTip;
        private ToolTip ReportSearchToolTip;
    }
}