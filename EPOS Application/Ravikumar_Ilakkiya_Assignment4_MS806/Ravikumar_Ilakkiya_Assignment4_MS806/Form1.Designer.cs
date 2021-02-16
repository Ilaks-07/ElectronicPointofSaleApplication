namespace Ravikumar_Ilakkiya_Assignment4_MS806
{
    partial class Form1
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
            this.ToyListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddtoCartButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PricePanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.QtyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GiftWrapRadioButton1 = new System.Windows.Forms.RadioButton();
            this.GiftWrapRadioButton2 = new System.Windows.Forms.RadioButton();
            this.NoThanksRadioButton = new System.Windows.Forms.RadioButton();
            this.GiftWrapRadioButton3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.CartPanel = new System.Windows.Forms.Panel();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CartListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Make = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gift = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransactionLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CartDetailLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.DailySalesReportButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PricePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QtyNumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.CartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToyListBox
            // 
            this.ToyListBox.FormattingEnabled = true;
            this.ToyListBox.ItemHeight = 16;
            this.ToyListBox.Items.AddRange(new object[] {
            "Thor\t\t€ 90",
            "Hulk\t\t€ 75",
            "Spidey\t\t€ 55",
            "Captain\t\t€ 50",
            "Groot\t\t€ 45",
            "Storm\t\t€ 60",
            "Thanos\t\t€ 85",
            "Hela\t\t€ 90",
            "Ironman\t\t€ 50",
            "Cable\t\t€ 98",
            "MystiQ\t\t€ 150",
            "Scarlet\t\t€ 45",
            "Luna\t\t€ 80"});
            this.ToyListBox.Location = new System.Drawing.Point(17, 48);
            this.ToyListBox.Name = "ToyListBox";
            this.ToyListBox.Size = new System.Drawing.Size(172, 212);
            this.ToyListBox.TabIndex = 0;
            this.ToyListBox.SelectedIndexChanged += new System.EventHandler(this.ToyListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Toys";
            // 
            // TypeListBox
            // 
            this.TypeListBox.FormattingEnabled = true;
            this.TypeListBox.ItemHeight = 16;
            this.TypeListBox.Items.AddRange(new object[] {
            "Mini Figures\t€ 50",
            "Collectibles\t€ 250",
            "Bobble Head\t€ 75",
            "Plush\t\t€ 35",
            "Electronic\t€ 90"});
            this.TypeListBox.Location = new System.Drawing.Point(195, 46);
            this.TypeListBox.Name = "TypeListBox";
            this.TypeListBox.Size = new System.Drawing.Size(172, 84);
            this.TypeListBox.TabIndex = 2;
            this.TypeListBox.SelectedIndexChanged += new System.EventHandler(this.TypeListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gift Wrap";
            // 
            // AddtoCartButton
            // 
            this.AddtoCartButton.Location = new System.Drawing.Point(58, 144);
            this.AddtoCartButton.Name = "AddtoCartButton";
            this.AddtoCartButton.Size = new System.Drawing.Size(95, 33);
            this.AddtoCartButton.TabIndex = 10;
            this.AddtoCartButton.Text = "&Add to Cart";
            this.AddtoCartButton.UseVisualStyleBackColor = true;
            this.AddtoCartButton.Click += new System.EventHandler(this.AddtoCartButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PricePanel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ToyListBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TypeListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 268);
            this.panel1.TabIndex = 12;
            // 
            // PricePanel
            // 
            this.PricePanel.Controls.Add(this.label5);
            this.PricePanel.Controls.Add(this.panel3);
            this.PricePanel.Controls.Add(this.AddtoCartButton);
            this.PricePanel.Enabled = false;
            this.PricePanel.Location = new System.Drawing.Point(532, 26);
            this.PricePanel.Name = "PricePanel";
            this.PricePanel.Size = new System.Drawing.Size(225, 193);
            this.PricePanel.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Price";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.PriceLabel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.QtyNumericUpDown);
            this.panel3.Location = new System.Drawing.Point(7, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 100);
            this.panel3.TabIndex = 23;
            // 
            // PriceLabel
            // 
            this.PriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceLabel.Location = new System.Drawing.Point(106, 60);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(81, 22);
            this.PriceLabel.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(16, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(13, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 46);
            this.label9.TabIndex = 15;
            this.label9.Text = "Quantity of Toys";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QtyNumericUpDown
            // 
            this.QtyNumericUpDown.Location = new System.Drawing.Point(104, 22);
            this.QtyNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.QtyNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QtyNumericUpDown.Name = "QtyNumericUpDown";
            this.QtyNumericUpDown.Size = new System.Drawing.Size(84, 22);
            this.QtyNumericUpDown.TabIndex = 16;
            this.QtyNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QtyNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QtyNumericUpDown.ValueChanged += new System.EventHandler(this.QtyNumericUpDown_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.GiftWrapRadioButton1);
            this.panel2.Controls.Add(this.GiftWrapRadioButton2);
            this.panel2.Controls.Add(this.NoThanksRadioButton);
            this.panel2.Controls.Add(this.GiftWrapRadioButton3);
            this.panel2.Location = new System.Drawing.Point(373, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 121);
            this.panel2.TabIndex = 21;
            // 
            // GiftWrapRadioButton1
            // 
            this.GiftWrapRadioButton1.AutoSize = true;
            this.GiftWrapRadioButton1.Location = new System.Drawing.Point(5, 63);
            this.GiftWrapRadioButton1.Name = "GiftWrapRadioButton1";
            this.GiftWrapRadioButton1.Size = new System.Drawing.Size(131, 21);
            this.GiftWrapRadioButton1.TabIndex = 26;
            this.GiftWrapRadioButton1.TabStop = true;
            this.GiftWrapRadioButton1.Text = "Chalkboard (€1)";
            this.GiftWrapRadioButton1.UseVisualStyleBackColor = true;
            this.GiftWrapRadioButton1.CheckedChanged += new System.EventHandler(this.GiftWrapRadioButton1_CheckedChanged);
            // 
            // GiftWrapRadioButton2
            // 
            this.GiftWrapRadioButton2.AutoSize = true;
            this.GiftWrapRadioButton2.Location = new System.Drawing.Point(5, 36);
            this.GiftWrapRadioButton2.Name = "GiftWrapRadioButton2";
            this.GiftWrapRadioButton2.Size = new System.Drawing.Size(96, 21);
            this.GiftWrapRadioButton2.TabIndex = 25;
            this.GiftWrapRadioButton2.TabStop = true;
            this.GiftWrapRadioButton2.Text = "Photo (€2)";
            this.GiftWrapRadioButton2.UseVisualStyleBackColor = true;
            this.GiftWrapRadioButton2.CheckedChanged += new System.EventHandler(this.GiftWrapRadioButton2_CheckedChanged);
            // 
            // NoThanksRadioButton
            // 
            this.NoThanksRadioButton.AutoSize = true;
            this.NoThanksRadioButton.Location = new System.Drawing.Point(5, 89);
            this.NoThanksRadioButton.Name = "NoThanksRadioButton";
            this.NoThanksRadioButton.Size = new System.Drawing.Size(98, 21);
            this.NoThanksRadioButton.TabIndex = 24;
            this.NoThanksRadioButton.TabStop = true;
            this.NoThanksRadioButton.Text = "No Thanks";
            this.NoThanksRadioButton.UseVisualStyleBackColor = true;
            this.NoThanksRadioButton.Visible = false;
            // 
            // GiftWrapRadioButton3
            // 
            this.GiftWrapRadioButton3.AutoSize = true;
            this.GiftWrapRadioButton3.Location = new System.Drawing.Point(5, 9);
            this.GiftWrapRadioButton3.Name = "GiftWrapRadioButton3";
            this.GiftWrapRadioButton3.Size = new System.Drawing.Size(98, 21);
            this.GiftWrapRadioButton3.TabIndex = 18;
            this.GiftWrapRadioButton3.TabStop = true;
            this.GiftWrapRadioButton3.Text = "Fabric (€3)";
            this.GiftWrapRadioButton3.UseVisualStyleBackColor = true;
            this.GiftWrapRadioButton3.CheckedChanged += new System.EventHandler(this.GiftWrapRadioButton3_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Toy Shopping";
            // 
            // CartPanel
            // 
            this.CartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CartPanel.Controls.Add(this.CheckOutButton);
            this.CartPanel.Controls.Add(this.RemoveButton);
            this.CartPanel.Controls.Add(this.CartListView);
            this.CartPanel.Controls.Add(this.TransactionLabel);
            this.CartPanel.Controls.Add(this.label8);
            this.CartPanel.Location = new System.Drawing.Point(12, 330);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(558, 268);
            this.CartPanel.TabIndex = 14;
            this.CartPanel.Visible = false;
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(392, 65);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(142, 33);
            this.CheckOutButton.TabIndex = 4;
            this.CheckOutButton.Text = "Check &Out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(392, 24);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(142, 33);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "&Remove from Cart";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CartListView
            // 
            this.CartListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.CartListView.AutoArrange = false;
            this.CartListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CartListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Item,
            this.Make,
            this.Gift,
            this.Quantity,
            this.Price});
            this.CartListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartListView.FullRowSelect = true;
            this.CartListView.GridLines = true;
            this.CartListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CartListView.HideSelection = false;
            this.CartListView.Location = new System.Drawing.Point(17, 65);
            this.CartListView.MultiSelect = false;
            this.CartListView.Name = "CartListView";
            this.CartListView.Size = new System.Drawing.Size(360, 198);
            this.CartListView.TabIndex = 2;
            this.CartListView.UseCompatibleStateImageBehavior = false;
            this.CartListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 100;
            // 
            // Make
            // 
            this.Make.Text = "Make";
            this.Make.Width = 70;
            // 
            // Gift
            // 
            this.Gift.Text = "Gift Wrap";
            this.Gift.Width = 70;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 61;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 50;
            // 
            // TransactionLabel
            // 
            this.TransactionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransactionLabel.Location = new System.Drawing.Point(161, 24);
            this.TransactionLabel.Name = "TransactionLabel";
            this.TransactionLabel.Size = new System.Drawing.Size(100, 23);
            this.TransactionLabel.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Transaction Number:";
            // 
            // CartDetailLabel
            // 
            this.CartDetailLabel.AutoSize = true;
            this.CartDetailLabel.Location = new System.Drawing.Point(46, 317);
            this.CartDetailLabel.Name = "CartDetailLabel";
            this.CartDetailLabel.Size = new System.Drawing.Size(81, 17);
            this.CartDetailLabel.TabIndex = 15;
            this.CartDetailLabel.Text = "Cart Details";
            this.CartDetailLabel.Visible = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(603, 345);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(178, 33);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(603, 396);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(178, 33);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(603, 452);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(178, 92);
            this.ReportButton.TabIndex = 19;
            this.ReportButton.Text = "Stock Re&port and Transcation Details";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // DailySalesReportButton
            // 
            this.DailySalesReportButton.Location = new System.Drawing.Point(603, 565);
            this.DailySalesReportButton.Name = "DailySalesReportButton";
            this.DailySalesReportButton.Size = new System.Drawing.Size(178, 33);
            this.DailySalesReportButton.TabIndex = 20;
            this.DailySalesReportButton.Text = "Sa&les Report";
            this.DailySalesReportButton.UseVisualStyleBackColor = true;
            this.DailySalesReportButton.Click += new System.EventHandler(this.DailySalesReportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 629);
            this.Controls.Add(this.DailySalesReportButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CartDetailLabel);
            this.Controls.Add(this.CartPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "World of Wonder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PricePanel.ResumeLayout(false);
            this.PricePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QtyNumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.CartPanel.ResumeLayout(false);
            this.CartPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ToyListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TypeListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddtoCartButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown QtyNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton GiftWrapRadioButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel CartPanel;
        private System.Windows.Forms.ListView CartListView;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label TransactionLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CartDetailLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.RadioButton NoThanksRadioButton;
        private System.Windows.Forms.Panel PricePanel;
        private System.Windows.Forms.ColumnHeader Make;
        private System.Windows.Forms.RadioButton GiftWrapRadioButton1;
        private System.Windows.Forms.RadioButton GiftWrapRadioButton2;
        private System.Windows.Forms.ColumnHeader Gift;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button DailySalesReportButton;
    }
}

