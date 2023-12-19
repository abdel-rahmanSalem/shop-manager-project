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
            quantityLabel = new Label();
            quantityNumericUpDown = new NumericUpDown();
            label1 = new Label();
            Calculatetotalprice = new TextBox();
            sellButton = new Button();
            cancelButton = new Button();
            sellIdTextBox = new TextBox();
            sellIdLapel = new Label();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // quantityLabel
            // 
            quantityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            quantityLabel.AutoSize = true;
            quantityLabel.BackColor = Color.Transparent;
            quantityLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            quantityLabel.ForeColor = Color.WhiteSmoke;
            quantityLabel.Location = new Point(34, 133);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(103, 27);
            quantityLabel.TabIndex = 23;
            quantityLabel.Text = "Quantity";
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            quantityNumericUpDown.BackColor = Color.LightGray;
            quantityNumericUpDown.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            quantityNumericUpDown.ForeColor = Color.Black;
            quantityNumericUpDown.Location = new Point(196, 137);
            quantityNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.ReadOnly = true;
            quantityNumericUpDown.Size = new Size(250, 29);
            quantityNumericUpDown.TabIndex = 1;
            quantityNumericUpDown.TextAlign = HorizontalAlignment.Center;
            quantityNumericUpDown.ValueChanged += quantityNumericUpDown_ValueChanged_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(38, 195);
            label1.Name = "label1";
            label1.Size = new Size(130, 27);
            label1.TabIndex = 25;
            label1.Text = "TotalPrice: ";
            // 
            // Calculatetotalprice
            // 
            Calculatetotalprice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Calculatetotalprice.BackColor = Color.FromArgb(15, 16, 43);
            Calculatetotalprice.BorderStyle = BorderStyle.None;
            Calculatetotalprice.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Calculatetotalprice.ForeColor = Color.LightGray;
            Calculatetotalprice.Location = new Point(196, 195);
            Calculatetotalprice.Margin = new Padding(3, 2, 3, 2);
            Calculatetotalprice.Name = "Calculatetotalprice";
            Calculatetotalprice.ReadOnly = true;
            Calculatetotalprice.Size = new Size(255, 29);
            Calculatetotalprice.TabIndex = 100;
            Calculatetotalprice.Visible = false;
            // 
            // sellButton
            // 
            sellButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sellButton.BackColor = Color.FromArgb(114, 0, 0);
            sellButton.Cursor = Cursors.Hand;
            sellButton.FlatStyle = FlatStyle.Popup;
            sellButton.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            sellButton.ForeColor = Color.White;
            sellButton.Location = new Point(26, 305);
            sellButton.Margin = new Padding(3, 2, 3, 2);
            sellButton.Name = "sellButton";
            sellButton.Size = new Size(192, 37);
            sellButton.TabIndex = 2;
            sellButton.Text = "Sell";
            sellButton.UseVisualStyleBackColor = false;
            sellButton.Click += sellButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cancelButton.BackColor = Color.Transparent;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(270, 305);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(192, 37);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // sellIdTextBox
            // 
            sellIdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            sellIdTextBox.BackColor = Color.FromArgb(31, 32, 60);
            sellIdTextBox.BorderStyle = BorderStyle.None;
            sellIdTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            sellIdTextBox.ForeColor = Color.LightGray;
            sellIdTextBox.Location = new Point(196, 73);
            sellIdTextBox.Margin = new Padding(3, 2, 3, 2);
            sellIdTextBox.Name = "sellIdTextBox";
            sellIdTextBox.Size = new Size(255, 29);
            sellIdTextBox.TabIndex = 0;
            sellIdTextBox.Visible = false;
            sellIdTextBox.TextChanged += sellIdTextBox_TextChanged_1;
            // 
            // sellIdLapel
            // 
            sellIdLapel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            sellIdLapel.AutoSize = true;
            sellIdLapel.BackColor = Color.Transparent;
            sellIdLapel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sellIdLapel.ForeColor = Color.WhiteSmoke;
            sellIdLapel.Location = new Point(38, 73);
            sellIdLapel.Name = "sellIdLapel";
            sellIdLapel.Size = new Size(126, 27);
            sellIdLapel.TabIndex = 29;
            sellIdLapel.Text = "Product ID";
            sellIdLapel.Visible = false;
            // 
            // SellProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 32);
            BackgroundImage = Properties.Resources.Screenshot__54_;
            ClientSize = new Size(494, 400);
            Controls.Add(sellIdTextBox);
            Controls.Add(sellIdLapel);
            Controls.Add(cancelButton);
            Controls.Add(sellButton);
            Controls.Add(Calculatetotalprice);
            Controls.Add(label1);
            Controls.Add(quantityNumericUpDown);
            Controls.Add(quantityLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SellProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SellProductForm";
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
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