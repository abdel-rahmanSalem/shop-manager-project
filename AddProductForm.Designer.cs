namespace shopManager
{
    partial class AddProductForm
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
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.profitTextBox = new System.Windows.Forms.TextBox();
            this.profitLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addProdLapel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.quantityNumericUpDown.BackColor = System.Drawing.Color.LightGray;
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityNumericUpDown.ForeColor = System.Drawing.Color.Black;
            this.quantityNumericUpDown.Location = new System.Drawing.Point(307, 488);
            this.quantityNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(286, 35);
            this.quantityNumericUpDown.TabIndex = 3;
            this.quantityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameLabel.Location = new System.Drawing.Point(63, 309);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(94, 35);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // costLabel
            // 
            this.costLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.costLabel.BackColor = System.Drawing.Color.Transparent;
            this.costLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.costLabel.Location = new System.Drawing.Point(63, 385);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(86, 40);
            this.costLabel.TabIndex = 23;
            this.costLabel.Text = "Cost";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(169, 309);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(424, 36);
            this.nameTextBox.TabIndex = 0;
            // 
            // profitTextBox
            // 
            this.profitTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.profitTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.profitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profitTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profitTextBox.ForeColor = System.Drawing.Color.White;
            this.profitTextBox.Location = new System.Drawing.Point(456, 384);
            this.profitTextBox.Name = "profitTextBox";
            this.profitTextBox.Size = new System.Drawing.Size(137, 36);
            this.profitTextBox.TabIndex = 2;
            // 
            // profitLabel
            // 
            this.profitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.profitLabel.BackColor = System.Drawing.Color.Transparent;
            this.profitLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profitLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.profitLabel.Location = new System.Drawing.Point(347, 385);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(87, 40);
            this.profitLabel.TabIndex = 25;
            this.profitLabel.Text = "Profit";
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.categoryLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.categoryLabel.Location = new System.Drawing.Point(63, 551);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(135, 35);
            this.categoryLabel.TabIndex = 21;
            this.categoryLabel.Text = "Category";
            // 
            // costTextBox
            // 
            this.costTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.costTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costTextBox.ForeColor = System.Drawing.Color.White;
            this.costTextBox.Location = new System.Drawing.Point(171, 385);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(137, 36);
            this.costTextBox.TabIndex = 1;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.categoryComboBox.BackColor = System.Drawing.Color.LightGray;
            this.categoryComboBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryComboBox.ForeColor = System.Drawing.Color.Black;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Cameras",
            "Phones",
            "Accessories"});
            this.categoryComboBox.Location = new System.Drawing.Point(307, 551);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(285, 37);
            this.categoryComboBox.TabIndex = 4;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.quantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.quantityLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.quantityLabel.Location = new System.Drawing.Point(63, 488);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(135, 40);
            this.quantityLabel.TabIndex = 22;
            this.quantityLabel.Text = "Quantity";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(63, 696);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(246, 49);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addProdLapel
            // 
            this.addProdLapel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addProdLapel.BackColor = System.Drawing.Color.Transparent;
            this.addProdLapel.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addProdLapel.ForeColor = System.Drawing.Color.White;
            this.addProdLapel.Location = new System.Drawing.Point(126, 89);
            this.addProdLapel.Name = "addProdLapel";
            this.addProdLapel.Size = new System.Drawing.Size(446, 72);
            this.addProdLapel.TabIndex = 26;
            this.addProdLapel.Text = "ADD NEW PRODUCT!";
            this.addProdLapel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(347, 696);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(246, 49);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.BackgroundImage = global::shopManager.Properties.Resources.Screenshot__54_;
            this.ClientSize = new System.Drawing.Size(663, 831);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addProdLapel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.profitLabel);
            this.Controls.Add(this.profitTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.nameLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(686, 960);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private Label costLabel;
        private TextBox nameTextBox;
        private TextBox profitTextBox;
        private Label profitLabel;
        private Label categoryLabel;
        private TextBox costTextBox;
        private ComboBox categoryComboBox;
        private Label quantityLabel;
        private NumericUpDown quantityNumericUpDown;
        private Button addButton;
        private Label addProdLapel;
        private Button cancelButton;
    }
}