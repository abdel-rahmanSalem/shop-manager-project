namespace shopManager
{
    partial class SellProductForm
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
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Calculatetotalprice = new System.Windows.Forms.TextBox();
            this.sellButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sellIdTextBox = new System.Windows.Forms.TextBox();
            this.sellIdLapel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.quantityLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.quantityLabel.Location = new System.Drawing.Point(39, 177);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(126, 35);
            this.quantityLabel.TabIndex = 23;
            this.quantityLabel.Text = "Quantity";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.quantityNumericUpDown.BackColor = System.Drawing.Color.LightGray;
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityNumericUpDown.ForeColor = System.Drawing.Color.Black;
            this.quantityNumericUpDown.Location = new System.Drawing.Point(224, 183);
            this.quantityNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.ReadOnly = true;
            this.quantityNumericUpDown.Size = new System.Drawing.Size(286, 35);
            this.quantityNumericUpDown.TabIndex = 1;
            this.quantityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityNumericUpDown.ValueChanged += new System.EventHandler(this.quantityNumericUpDown_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(43, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "TotalPrice: ";
            // 
            // Calculatetotalprice
            // 
            this.Calculatetotalprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Calculatetotalprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.Calculatetotalprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calculatetotalprice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculatetotalprice.ForeColor = System.Drawing.Color.LightGray;
            this.Calculatetotalprice.Location = new System.Drawing.Point(224, 260);
            this.Calculatetotalprice.Name = "Calculatetotalprice";
            this.Calculatetotalprice.ReadOnly = true;
            this.Calculatetotalprice.Size = new System.Drawing.Size(291, 36);
            this.Calculatetotalprice.TabIndex = 100;
            this.Calculatetotalprice.Visible = false;
            // 
            // sellButton
            // 
            this.sellButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sellButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sellButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sellButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sellButton.ForeColor = System.Drawing.Color.White;
            this.sellButton.Location = new System.Drawing.Point(30, 407);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(246, 49);
            this.sellButton.TabIndex = 2;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = false;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(309, 407);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(219, 49);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // sellIdTextBox
            // 
            this.sellIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sellIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.sellIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sellIdTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellIdTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.sellIdTextBox.Location = new System.Drawing.Point(224, 97);
            this.sellIdTextBox.Name = "sellIdTextBox";
            this.sellIdTextBox.Size = new System.Drawing.Size(291, 36);
            this.sellIdTextBox.TabIndex = 0;
            this.sellIdTextBox.Visible = false;
            this.sellIdTextBox.TextChanged += new System.EventHandler(this.sellIdTextBox_TextChanged_1);
            // 
            // sellIdLapel
            // 
            this.sellIdLapel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sellIdLapel.AutoSize = true;
            this.sellIdLapel.BackColor = System.Drawing.Color.Transparent;
            this.sellIdLapel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellIdLapel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sellIdLapel.Location = new System.Drawing.Point(43, 97);
            this.sellIdLapel.Name = "sellIdLapel";
            this.sellIdLapel.Size = new System.Drawing.Size(155, 35);
            this.sellIdLapel.TabIndex = 29;
            this.sellIdLapel.Text = "Product ID";
            this.sellIdLapel.Visible = false;
            // 
            // SellProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.BackgroundImage = global::shopManager.Properties.Resources.Screenshot__54_;
            this.ClientSize = new System.Drawing.Size(565, 533);
            this.Controls.Add(this.sellIdTextBox);
            this.Controls.Add(this.sellIdLapel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.Calculatetotalprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.quantityLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SellButton;
        private Button CancelButton;
        private Label quantityLabel;
        private NumericUpDown quantityNumericUpDown;
        private Label label1;
        private TextBox Calculatetotalprice;
        private Button sellButton;
        private Button cancelButton;
        private TextBox sellIdTextBox;
        private Label sellIdLapel;
    }
}