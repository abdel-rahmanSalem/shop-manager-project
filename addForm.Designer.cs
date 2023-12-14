namespace shopManager
{
    partial class addForm
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
            nameLabel = new Label();
            costLabel = new Label();
            profitLabel = new Label();
            catagoryLabel = new Label();
            quantityLabel = new Label();
            nameTextBox = new TextBox();
            costTextBox = new TextBox();
            profitTextBox = new TextBox();
            categoryBox = new ComboBox();
            panel1 = new Panel();
            backButton = new Button();
            addBtn = new Button();
            numericUpDown = new NumericUpDown();
            newproductLabel = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Arial", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.LightGray;
            nameLabel.Location = new Point(60, 110);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(103, 37);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.BackColor = Color.Transparent;
            costLabel.Font = new Font("Arial", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            costLabel.ForeColor = Color.LightGray;
            costLabel.Location = new Point(60, 205);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(88, 37);
            costLabel.TabIndex = 1;
            costLabel.Text = "Cost";
            // 
            // profitLabel
            // 
            profitLabel.AutoSize = true;
            profitLabel.BackColor = Color.Transparent;
            profitLabel.Font = new Font("Arial", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            profitLabel.ForeColor = Color.LightGray;
            profitLabel.Location = new Point(60, 294);
            profitLabel.Name = "profitLabel";
            profitLabel.Size = new Size(101, 37);
            profitLabel.TabIndex = 2;
            profitLabel.Text = "Profit";
            // 
            // catagoryLabel
            // 
            catagoryLabel.AutoSize = true;
            catagoryLabel.BackColor = Color.Transparent;
            catagoryLabel.Font = new Font("Arial", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            catagoryLabel.ForeColor = Color.LightGray;
            catagoryLabel.Location = new Point(83, 367);
            catagoryLabel.Name = "catagoryLabel";
            catagoryLabel.Size = new Size(155, 37);
            catagoryLabel.TabIndex = 3;
            catagoryLabel.Text = "Catagory";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.BackColor = Color.Transparent;
            quantityLabel.Font = new Font("Arial", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            quantityLabel.ForeColor = Color.LightGray;
            quantityLabel.Location = new Point(546, 367);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(146, 37);
            quantityLabel.TabIndex = 4;
            quantityLabel.Text = "Quantity";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.FromArgb(31, 32, 60);
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.ForeColor = Color.LightGray;
            nameTextBox.Location = new Point(188, 111);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(172, 36);
            nameTextBox.TabIndex = 5;
            // 
            // costTextBox
            // 
            costTextBox.BackColor = Color.FromArgb(31, 32, 60);
            costTextBox.BorderStyle = BorderStyle.None;
            costTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            costTextBox.ForeColor = Color.LightGray;
            costTextBox.Location = new Point(188, 205);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(172, 36);
            costTextBox.TabIndex = 6;
            // 
            // profitTextBox
            // 
            profitTextBox.BackColor = Color.FromArgb(31, 32, 60);
            profitTextBox.BorderStyle = BorderStyle.None;
            profitTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            profitTextBox.ForeColor = Color.LightGray;
            profitTextBox.Location = new Point(188, 294);
            profitTextBox.Name = "profitTextBox";
            profitTextBox.Size = new Size(172, 36);
            profitTextBox.TabIndex = 7;
            // 
            // categoryBox
            // 
            categoryBox.BackColor = Color.LightGray;
            categoryBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryBox.FormattingEnabled = true;
            categoryBox.Location = new Point(260, 367);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(258, 36);
            categoryBox.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(numericUpDown);
            panel1.Controls.Add(newproductLabel);
            panel1.Controls.Add(costLabel);
            panel1.Controls.Add(categoryBox);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(profitTextBox);
            panel1.Controls.Add(profitLabel);
            panel1.Controls.Add(costTextBox);
            panel1.Controls.Add(catagoryLabel);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(quantityLabel);
            panel1.Location = new Point(73, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 552);
            panel1.TabIndex = 9;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(114, 0, 0);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.ForeColor = Color.LightGray;
            backButton.Location = new Point(698, 42);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 41);
            backButton.TabIndex = 12;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(114, 0, 0);
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.ForeColor = Color.LightGray;
            addBtn.Location = new Point(392, 462);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 41);
            addBtn.TabIndex = 11;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addFormButton_Click;
            // 
            // numericUpDown
            // 
            numericUpDown.BackColor = Color.LightGray;
            numericUpDown.Location = new Point(698, 375);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(80, 27);
            numericUpDown.TabIndex = 10;
            numericUpDown.TextAlign = HorizontalAlignment.Center;
            // 
            // newproductLabel
            // 
            newproductLabel.AutoSize = true;
            newproductLabel.BackColor = Color.Transparent;
            newproductLabel.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            newproductLabel.ForeColor = Color.LightGray;
            newproductLabel.Location = new Point(294, 28);
            newproductLabel.Name = "newproductLabel";
            newproductLabel.Size = new Size(224, 40);
            newproductLabel.TabIndex = 9;
            newproductLabel.Text = "New Product";
            // 
            // addForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot__54_;
            ClientSize = new Size(1001, 665);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MinimumSize = new Size(800, 600);
            Name = "addForm";
            Text = "addForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label nameLabel;
        private Label costLabel;
        private Label profitLabel;
        private Label catagoryLabel;
        private Label quantityLabel;
        private TextBox nameTextBox;
        private TextBox costTextBox;
        private TextBox profitTextBox;
        private ComboBox categoryBox;
        private Panel panel1;
        private Label newproductLabel;
        private NumericUpDown numericUpDown;
        private Button addBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button backButton;
    }
}