namespace shopManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            nameLabel = new Label();
            costLabel = new Label();
            nameTextBox = new TextBox();
            profitTextBox = new TextBox();
            profitLabel = new Label();
            categoryLabel = new Label();
            coatTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            quantityLabel = new Label();
            addButton = new Button();
            searchLabelHeader = new Label();
            searchTextBox = new TextBox();
            bynameButton = new Button();
            byidButton = new Button();
            imageList1 = new ImageList(components);
            quantityNumericUpDown = new NumericUpDown();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Arial", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.LightGray;
            nameLabel.Location = new Point(145, 30);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(90, 32);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Arial", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            costLabel.ForeColor = Color.LightGray;
            costLabel.Location = new Point(145, 94);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(75, 32);
            costLabel.TabIndex = 1;
            costLabel.Text = "Cost";
            costLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.FromArgb(23, 37, 47);
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.ForeColor = Color.WhiteSmoke;
            nameTextBox.Location = new Point(254, 30);
            nameTextBox.Margin = new Padding(3, 2, 3, 2);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(371, 30);
            nameTextBox.TabIndex = 2;
            // 
            // profitTextBox
            // 
            profitTextBox.BackColor = Color.FromArgb(23, 37, 47);
            profitTextBox.BorderStyle = BorderStyle.None;
            profitTextBox.Location = new Point(505, 94);
            profitTextBox.Margin = new Padding(3, 2, 3, 2);
            profitTextBox.Multiline = true;
            profitTextBox.Name = "profitTextBox";
            profitTextBox.Size = new Size(120, 30);
            profitTextBox.TabIndex = 3;
            // 
            // profitLabel
            // 
            profitLabel.AutoSize = true;
            profitLabel.Font = new Font("Arial", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            profitLabel.ForeColor = Color.LightGray;
            profitLabel.Location = new Point(396, 94);
            profitLabel.Name = "profitLabel";
            profitLabel.Size = new Size(86, 32);
            profitLabel.TabIndex = 4;
            profitLabel.Text = "Profit";
            // 
            // categoryLabel
            // 
            categoryLabel.Anchor = AnchorStyles.Top;
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Arial", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            categoryLabel.ForeColor = Color.LightGray;
            categoryLabel.Location = new Point(645, 30);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(133, 32);
            categoryLabel.TabIndex = 5;
            categoryLabel.Text = "Category";
            // 
            // coatTextBox
            // 
            coatTextBox.BackColor = Color.FromArgb(23, 37, 47);
            coatTextBox.BorderStyle = BorderStyle.None;
            coatTextBox.Location = new Point(254, 94);
            coatTextBox.Margin = new Padding(3, 2, 3, 2);
            coatTextBox.Multiline = true;
            coatTextBox.Name = "coatTextBox";
            coatTextBox.Size = new Size(120, 30);
            coatTextBox.TabIndex = 6;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Anchor = AnchorStyles.Top;
            categoryComboBox.BackColor = Color.LightGray;
            categoryComboBox.ForeColor = Color.Black;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Cameras", "Phones", "Accessories" });
            categoryComboBox.Location = new Point(784, 37);
            categoryComboBox.Margin = new Padding(3, 2, 3, 2);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(242, 23);
            categoryComboBox.TabIndex = 7;
            // 
            // quantityLabel
            // 
            quantityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Arial", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            quantityLabel.ForeColor = Color.LightGray;
            quantityLabel.Location = new Point(1045, 37);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(125, 32);
            quantityLabel.TabIndex = 8;
            quantityLabel.Text = "Quantity";
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButton.BackColor = Color.FromArgb(114, 0, 0);
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(1199, 94);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(82, 37);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            //addButton.Click += new EventHandler(addButton_Click);
            // 
            // searchLabelHeader
            // 
            searchLabelHeader.AutoSize = true;
            searchLabelHeader.Font = new Font("Arial", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            searchLabelHeader.ForeColor = Color.LightGray;
            searchLabelHeader.Location = new Point(145, 190);
            searchLabelHeader.Name = "searchLabelHeader";
            searchLabelHeader.Size = new Size(105, 32);
            searchLabelHeader.TabIndex = 11;
            searchLabelHeader.Text = "Search";
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.LightGray;
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.ForeColor = Color.White;
            searchTextBox.Location = new Point(254, 185);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(705, 37);
            searchTextBox.TabIndex = 12;
            // 
            // bynameButton
            // 
            bynameButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bynameButton.BackColor = Color.FromArgb(42, 61, 85);
            bynameButton.FlatStyle = FlatStyle.Popup;
            bynameButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bynameButton.ForeColor = Color.White;
            bynameButton.Location = new Point(1001, 185);
            bynameButton.Margin = new Padding(3, 2, 3, 2);
            bynameButton.Name = "bynameButton";
            bynameButton.Size = new Size(125, 37);
            bynameButton.TabIndex = 13;
            bynameButton.Text = "By Name";
            bynameButton.UseVisualStyleBackColor = false;
            // 
            // byidButton
            // 
            byidButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            byidButton.BackColor = Color.FromArgb(42, 61, 85);
            byidButton.FlatStyle = FlatStyle.Popup;
            byidButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            byidButton.ForeColor = Color.White;
            byidButton.Location = new Point(1157, 185);
            byidButton.Margin = new Padding(3, 2, 3, 2);
            byidButton.Name = "byidButton";
            byidButton.Size = new Size(125, 37);
            byidButton.TabIndex = 14;
            byidButton.Text = "By ID";
            byidButton.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "R (1).png");
            imageList1.Images.SetKeyName(1, "R (2).png");
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            quantityNumericUpDown.Location = new Point(1212, 40);
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(69, 23);
            quantityNumericUpDown.TabIndex = 24;
            quantityNumericUpDown.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.Image = Properties.Resources.R;
            pictureBox1.Location = new Point(924, 186);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(addButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1444, 249);
            panel2.TabIndex = 35;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(23, 37, 47);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView.GridColor = Color.FromArgb(23, 37, 47);
            dataGridView.Location = new Point(73, 277);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.ShowEditingIcon = false;
            dataGridView.Size = new Size(1297, 372);
            dataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "Name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DefaultCellStyle = dataGridViewCellStyle1;
            Column2.HeaderText = "ID";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DefaultCellStyle = dataGridViewCellStyle1;
            Column3.HeaderText = "Category";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DefaultCellStyle = dataGridViewCellStyle1;
            Column4.HeaderText = "Quantity";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DefaultCellStyle = dataGridViewCellStyle1;
            Column5.HeaderText = "Price";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(6, 90, 37);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(6, 90, 37);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            Column6.DefaultCellStyle = dataGridViewCellStyle2;
            Column6.FlatStyle = FlatStyle.Flat;
            Column6.HeaderText = "";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Text = "Edit";
            Column6.UseColumnTextForButtonValue = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(63, 15, 22);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(63, 15, 22);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            Column7.DefaultCellStyle = dataGridViewCellStyle3;
            Column7.FlatStyle = FlatStyle.Flat;
            Column7.HeaderText = "";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Text = "Delete";
            Column7.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 24, 33);
            ClientSize = new Size(1444, 661);
            Controls.Add(dataGridView);
            Controls.Add(pictureBox1);
            Controls.Add(quantityNumericUpDown);
            Controls.Add(byidButton);
            Controls.Add(bynameButton);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabelHeader);
            Controls.Add(quantityLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(coatTextBox);
            Controls.Add(categoryLabel);
            Controls.Add(profitLabel);
            Controls.Add(profitTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(costLabel);
            Controls.Add(nameLabel);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label costLabel;
        private TextBox nameTextBox;
        private TextBox profitTextBox;
        private Label profitLabel;
        private Label categoryLabel;
        private TextBox coatTextBox;
        private ComboBox categoryComboBox;
        private Label quantityLabel;
        private Button addButton;
        private Label searchLabelHeader;
        private TextBox searchTextBox;
        private Button bynameButton;
        private Button byidButton;
        private NumericUpDown quantityNumericUpDown;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
    }
}