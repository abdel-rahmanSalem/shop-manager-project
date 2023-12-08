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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.profitTextBox = new System.Windows.Forms.TextBox();
            this.profitLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.coatTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.searchLabelHeader = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.bynameButton = new System.Windows.Forms.Button();
            this.byidButton = new System.Windows.Forms.Button();
            this.nameLabelHeader = new System.Windows.Forms.Label();
            this.idLabelHeader = new System.Windows.Forms.Label();
            this.quantityLabelHeader = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.updateButton = new System.Windows.Forms.Button();
            this.totalpriceLabelHeader = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.shopmanagerlabel = new System.Windows.Forms.Label();
            this.nameLabelBody = new System.Windows.Forms.Label();
            this.idLabelBody = new System.Windows.Forms.Label();
            this.catagoryLabelBody = new System.Windows.Forms.Label();
            this.quantityLabelBody = new System.Windows.Forms.Label();
            this.totalpriceLabelBody = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.nameLabel.Location = new System.Drawing.Point(73, 177);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(105, 38);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.costLabel.ForeColor = System.Drawing.Color.LightGray;
            this.costLabel.Location = new System.Drawing.Point(79, 263);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(90, 38);
            this.costLabel.TabIndex = 1;
            this.costLabel.Text = "Cost";
            this.costLabel.Click += new System.EventHandler(this.costLabel_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameTextBox.Location = new System.Drawing.Point(198, 177);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(424, 40);
            this.nameTextBox.TabIndex = 2;
            // 
            // profitTextBox
            // 
            this.profitTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.profitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profitTextBox.Location = new System.Drawing.Point(483, 263);
            this.profitTextBox.Multiline = true;
            this.profitTextBox.Name = "profitTextBox";
            this.profitTextBox.Size = new System.Drawing.Size(139, 40);
            this.profitTextBox.TabIndex = 3;
            this.profitTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // profitLabel
            // 
            this.profitLabel.AutoSize = true;
            this.profitLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profitLabel.ForeColor = System.Drawing.Color.LightGray;
            this.profitLabel.Location = new System.Drawing.Point(360, 263);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(102, 38);
            this.profitLabel.TabIndex = 4;
            this.profitLabel.Text = "Profit";
            this.profitLabel.Click += new System.EventHandler(this.profitLabel_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryLabel.ForeColor = System.Drawing.Color.LightGray;
            this.categoryLabel.Location = new System.Drawing.Point(645, 177);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(160, 38);
            this.categoryLabel.TabIndex = 5;
            this.categoryLabel.Text = "Category";
            // 
            // coatTextBox
            // 
            this.coatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.coatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coatTextBox.Location = new System.Drawing.Point(198, 263);
            this.coatTextBox.Multiline = true;
            this.coatTextBox.Name = "coatTextBox";
            this.coatTextBox.Size = new System.Drawing.Size(131, 40);
            this.coatTextBox.TabIndex = 6;
            this.coatTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.Color.LightGray;
            this.categoryComboBox.ForeColor = System.Drawing.Color.Black;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Cameras",
            "Phones",
            "Accessories"});
            this.categoryComboBox.Location = new System.Drawing.Point(803, 187);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(276, 28);
            this.categoryComboBox.TabIndex = 7;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.ForeColor = System.Drawing.Color.LightGray;
            this.quantityLabel.Location = new System.Drawing.Point(1102, 187);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(150, 38);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "Quantity";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(1279, 281);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 51);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchLabelHeader
            // 
            this.searchLabelHeader.AutoSize = true;
            this.searchLabelHeader.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchLabelHeader.ForeColor = System.Drawing.Color.LightGray;
            this.searchLabelHeader.Location = new System.Drawing.Point(45, 393);
            this.searchLabelHeader.Name = "searchLabelHeader";
            this.searchLabelHeader.Size = new System.Drawing.Size(126, 38);
            this.searchLabelHeader.TabIndex = 11;
            this.searchLabelHeader.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.LightGray;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.ForeColor = System.Drawing.Color.White;
            this.searchTextBox.Location = new System.Drawing.Point(176, 384);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(827, 53);
            this.searchTextBox.TabIndex = 12;
            // 
            // bynameButton
            // 
            this.bynameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.bynameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bynameButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bynameButton.ForeColor = System.Drawing.Color.White;
            this.bynameButton.Location = new System.Drawing.Point(1029, 384);
            this.bynameButton.Name = "bynameButton";
            this.bynameButton.Size = new System.Drawing.Size(155, 49);
            this.bynameButton.TabIndex = 13;
            this.bynameButton.Text = "By Name";
            this.bynameButton.UseVisualStyleBackColor = false;
            // 
            // byidButton
            // 
            this.byidButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.byidButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.byidButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.byidButton.ForeColor = System.Drawing.Color.White;
            this.byidButton.Location = new System.Drawing.Point(1230, 384);
            this.byidButton.Name = "byidButton";
            this.byidButton.Size = new System.Drawing.Size(143, 49);
            this.byidButton.TabIndex = 14;
            this.byidButton.Text = "By ID";
            this.byidButton.UseVisualStyleBackColor = false;
            // 
            // nameLabelHeader
            // 
            this.nameLabelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.nameLabelHeader.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabelHeader.ForeColor = System.Drawing.Color.White;
            this.nameLabelHeader.Location = new System.Drawing.Point(45, 484);
            this.nameLabelHeader.Name = "nameLabelHeader";
            this.nameLabelHeader.Size = new System.Drawing.Size(163, 48);
            this.nameLabelHeader.TabIndex = 15;
            this.nameLabelHeader.Text = "    Name     ";
            this.nameLabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idLabelHeader
            // 
            this.idLabelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.idLabelHeader.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idLabelHeader.ForeColor = System.Drawing.Color.White;
            this.idLabelHeader.Location = new System.Drawing.Point(255, 484);
            this.idLabelHeader.Name = "idLabelHeader";
            this.idLabelHeader.Size = new System.Drawing.Size(147, 48);
            this.idLabelHeader.TabIndex = 16;
            this.idLabelHeader.Text = "       ID       ";
            this.idLabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantityLabelHeader
            // 
            this.quantityLabelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.quantityLabelHeader.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityLabelHeader.ForeColor = System.Drawing.Color.White;
            this.quantityLabelHeader.Location = new System.Drawing.Point(725, 484);
            this.quantityLabelHeader.Name = "quantityLabelHeader";
            this.quantityLabelHeader.Size = new System.Drawing.Size(179, 48);
            this.quantityLabelHeader.TabIndex = 18;
            this.quantityLabelHeader.Text = "   Quantity    ";
            this.quantityLabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteButton
            // 
            this.deleteButton.ImageIndex = 0;
            this.deleteButton.ImageList = this.imageList1;
            this.deleteButton.Location = new System.Drawing.Point(1148, 479);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(79, 64);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "R (1).png");
            this.imageList1.Images.SetKeyName(1, "R (2).png");
            // 
            // updateButton
            // 
            this.updateButton.ImageIndex = 1;
            this.updateButton.ImageList = this.imageList1;
            this.updateButton.Location = new System.Drawing.Point(1249, 479);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(79, 64);
            this.updateButton.TabIndex = 20;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // totalpriceLabelHeader
            // 
            this.totalpriceLabelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.totalpriceLabelHeader.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalpriceLabelHeader.ForeColor = System.Drawing.Color.White;
            this.totalpriceLabelHeader.Location = new System.Drawing.Point(943, 484);
            this.totalpriceLabelHeader.Name = "totalpriceLabelHeader";
            this.totalpriceLabelHeader.Size = new System.Drawing.Size(179, 48);
            this.totalpriceLabelHeader.TabIndex = 23;
            this.totalpriceLabelHeader.Text = "Total Price";
            this.totalpriceLabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(1265, 191);
            this.quantityNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(79, 27);
            this.quantityNumericUpDown.TabIndex = 24;
            this.quantityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityNumericUpDown.ValueChanged += new System.EventHandler(this.quantityNumericUpDown_ValueChanged);
            // 
            // shopmanagerlabel
            // 
            this.shopmanagerlabel.AutoSize = true;
            this.shopmanagerlabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shopmanagerlabel.ForeColor = System.Drawing.Color.LightGray;
            this.shopmanagerlabel.Location = new System.Drawing.Point(570, 59);
            this.shopmanagerlabel.Name = "shopmanagerlabel";
            this.shopmanagerlabel.Size = new System.Drawing.Size(277, 44);
            this.shopmanagerlabel.TabIndex = 25;
            this.shopmanagerlabel.Text = "Shop Manager";
            // 
            // nameLabelBody
            // 
            this.nameLabelBody.AutoSize = true;
            this.nameLabelBody.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabelBody.ForeColor = System.Drawing.Color.LightGray;
            this.nameLabelBody.Location = new System.Drawing.Point(73, 547);
            this.nameLabelBody.Name = "nameLabelBody";
            this.nameLabelBody.Size = new System.Drawing.Size(136, 32);
            this.nameLabelBody.TabIndex = 26;
            this.nameLabelBody.Text = "samsung";
            // 
            // idLabelBody
            // 
            this.idLabelBody.AutoSize = true;
            this.idLabelBody.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idLabelBody.ForeColor = System.Drawing.Color.LightGray;
            this.idLabelBody.Location = new System.Drawing.Point(282, 547);
            this.idLabelBody.Name = "idLabelBody";
            this.idLabelBody.Size = new System.Drawing.Size(88, 32);
            this.idLabelBody.TabIndex = 27;
            this.idLabelBody.Text = "11023";
            // 
            // catagoryLabelBody
            // 
            this.catagoryLabelBody.AutoSize = true;
            this.catagoryLabelBody.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.catagoryLabelBody.ForeColor = System.Drawing.Color.LightGray;
            this.catagoryLabelBody.Location = new System.Drawing.Point(505, 547);
            this.catagoryLabelBody.Name = "catagoryLabelBody";
            this.catagoryLabelBody.Size = new System.Drawing.Size(98, 32);
            this.catagoryLabelBody.TabIndex = 29;
            this.catagoryLabelBody.Text = "Phone";
            this.catagoryLabelBody.Click += new System.EventHandler(this.label3_Click);
            // 
            // quantityLabelBody
            // 
            this.quantityLabelBody.AutoSize = true;
            this.quantityLabelBody.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityLabelBody.ForeColor = System.Drawing.Color.LightGray;
            this.quantityLabelBody.Location = new System.Drawing.Point(792, 547);
            this.quantityLabelBody.Name = "quantityLabelBody";
            this.quantityLabelBody.Size = new System.Drawing.Size(29, 32);
            this.quantityLabelBody.TabIndex = 30;
            this.quantityLabelBody.Text = "3";
            // 
            // totalpriceLabelBody
            // 
            this.totalpriceLabelBody.AutoSize = true;
            this.totalpriceLabelBody.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalpriceLabelBody.ForeColor = System.Drawing.Color.LightGray;
            this.totalpriceLabelBody.Location = new System.Drawing.Point(1001, 547);
            this.totalpriceLabelBody.Name = "totalpriceLabelBody";
            this.totalpriceLabelBody.Size = new System.Drawing.Size(89, 32);
            this.totalpriceLabelBody.TabIndex = 31;
            this.totalpriceLabelBody.Text = "10000";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(434, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 48);
            this.label1.TabIndex = 32;
            this.label1.Text = "    Category    ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = global::shopManager.Properties.Resources.R;
            this.pictureBox1.Location = new System.Drawing.Point(878, 384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1445, 908);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalpriceLabelBody);
            this.Controls.Add(this.quantityLabelBody);
            this.Controls.Add(this.catagoryLabelBody);
            this.Controls.Add(this.idLabelBody);
            this.Controls.Add(this.nameLabelBody);
            this.Controls.Add(this.shopmanagerlabel);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.totalpriceLabelHeader);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.quantityLabelHeader);
            this.Controls.Add(this.idLabelHeader);
            this.Controls.Add(this.nameLabelHeader);
            this.Controls.Add(this.byidButton);
            this.Controls.Add(this.bynameButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabelHeader);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.coatTextBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.profitLabel);
            this.Controls.Add(this.profitTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private TextBox coatTextBox;
        private ComboBox categoryComboBox;
        private Label quantityLabel;
        private Button addButton;
        private Label searchLabelHeader;
        private TextBox searchTextBox;
        private Button bynameButton;
        private Button byidButton;
        private Label nameLabelHeader;
        private Label idLabelHeader;
        private Label quantityLabelHeader;
        private Button deleteButton;
        private Button updateButton;
        private Label totalpriceLabelHeader;
        private NumericUpDown quantityNumericUpDown;
        private Label shopmanagerlabel;
        private Label nameLabelBody;
        private Label idLabelBody;
        private Label catagoryLabelBody;
        private Label quantityLabelBody;
        private Label totalpriceLabelBody;
        private ImageList imageList1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}