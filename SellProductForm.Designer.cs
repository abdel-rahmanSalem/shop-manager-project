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
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // quantityLabel
            // 
            quantityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            quantityLabel.BackColor = Color.Transparent;
            quantityLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            quantityLabel.ForeColor = Color.WhiteSmoke;
            quantityLabel.Location = new Point(39, 125);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(135, 110);
            quantityLabel.TabIndex = 23;
            quantityLabel.Text = "Quantity";
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            quantityNumericUpDown.BackColor = Color.LightGray;
            quantityNumericUpDown.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            quantityNumericUpDown.ForeColor = Color.Black;
            quantityNumericUpDown.Location = new Point(224, 130);
            quantityNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            quantityNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(286, 35);
            quantityNumericUpDown.TabIndex = 24;
            quantityNumericUpDown.TextAlign = HorizontalAlignment.Center;
            quantityNumericUpDown.ValueChanged += quantityNumericUpDown_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(39, 248);
            label1.Name = "label1";
            label1.Size = new Size(150, 110);
            label1.TabIndex = 25;
            label1.Text = "TotalPrice";
            // 
            // Calculatetotalprice
            // 
            Calculatetotalprice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Calculatetotalprice.BackColor = Color.FromArgb(44, 45, 60);
            Calculatetotalprice.BorderStyle = BorderStyle.None;
            Calculatetotalprice.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Calculatetotalprice.ForeColor = Color.White;
            Calculatetotalprice.Location = new Point(219, 248);
            Calculatetotalprice.Name = "Calculatetotalprice";
            Calculatetotalprice.Size = new Size(291, 36);
            Calculatetotalprice.TabIndex = 26;
            // 
            // sellButton
            // 
            sellButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sellButton.BackColor = Color.FromArgb(114, 0, 0);
            sellButton.Cursor = Cursors.Hand;
            sellButton.FlatStyle = FlatStyle.Popup;
            sellButton.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            sellButton.ForeColor = Color.White;
            sellButton.Location = new Point(30, 407);
            sellButton.Name = "sellButton";
            sellButton.Size = new Size(246, 49);
            sellButton.TabIndex = 27;
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
            cancelButton.Location = new Point(308, 407);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(220, 49);
            cancelButton.TabIndex = 28;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // SellProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 32);
            ClientSize = new Size(565, 533);
            Controls.Add(cancelButton);
            Controls.Add(sellButton);
            Controls.Add(Calculatetotalprice);
            Controls.Add(label1);
            Controls.Add(quantityNumericUpDown);
            Controls.Add(quantityLabel);
            Name = "SellProductForm";
            Text = "SellProductForm";
            Load += SellProductForm_Load;
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
    }
}