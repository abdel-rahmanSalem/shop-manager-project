namespace shopManager
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            searchLabelHeader = new Label();
            searchTextBox = new TextBox();
            imageList1 = new ImageList(components);
            searchIcon = new PictureBox();
            dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            panel1 = new Panel();
            cancelSearchButton = new Button();
            addProdButton = new Button();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // searchLabelHeader
            // 
            searchLabelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            searchLabelHeader.Font = new Font("Arial", 19F, FontStyle.Regular, GraphicsUnit.Point);
            searchLabelHeader.ForeColor = Color.LightGray;
            searchLabelHeader.Location = new Point(176, 21);
            searchLabelHeader.Name = "searchLabelHeader";
            searchLabelHeader.Size = new Size(101, 29);
            searchLabelHeader.TabIndex = 24;
            searchLabelHeader.Text = "Search";
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            searchTextBox.BackColor = Color.LightGray;
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.ForeColor = Color.Black;
            searchTextBox.Location = new Point(270, 21);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(705, 29);
            searchTextBox.TabIndex = 7;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "R (1).png");
            imageList1.Images.SetKeyName(1, "R (2).png");
            // 
            // searchIcon
            // 
            searchIcon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            searchIcon.BackColor = Color.LightGray;
            searchIcon.Cursor = Cursors.Hand;
            searchIcon.Image = Properties.Resources.R;
            searchIcon.Location = new Point(949, 25);
            searchIcon.Margin = new Padding(3, 2, 3, 2);
            searchIcon.MaximumSize = new Size(26, 25);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(26, 25);
            searchIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            searchIcon.TabIndex = 33;
            searchIcon.TabStop = false;
            searchIcon.Click += searchIcon_Click;
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
            dataGridView.Location = new Point(43, 78);
            dataGridView.MaximumSize = new Size(1461, 10000);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.ShowEditingIcon = false;
            dataGridView.Size = new Size(1161, 375);
            dataGridView.TabIndex = 6;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(23, 37, 47);
            panel1.Controls.Add(cancelSearchButton);
            panel1.Controls.Add(dataGridView);
            panel1.Controls.Add(searchIcon);
            panel1.Controls.Add(searchTextBox);
            panel1.Controls.Add(searchLabelHeader);
            panel1.Location = new Point(12, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(1240, 473);
            panel1.TabIndex = 36;
            // 
            // cancelSearchButton
            // 
            cancelSearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cancelSearchButton.BackColor = Color.Maroon;
            cancelSearchButton.Cursor = Cursors.Hand;
            cancelSearchButton.FlatStyle = FlatStyle.Popup;
            cancelSearchButton.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            cancelSearchButton.ForeColor = Color.AliceBlue;
            cancelSearchButton.Location = new Point(985, 21);
            cancelSearchButton.Margin = new Padding(3, 2, 3, 2);
            cancelSearchButton.MaximumSize = new Size(29, 29);
            cancelSearchButton.Name = "cancelSearchButton";
            cancelSearchButton.Size = new Size(29, 29);
            cancelSearchButton.TabIndex = 37;
            cancelSearchButton.Text = "X";
            cancelSearchButton.UseVisualStyleBackColor = false;
            cancelSearchButton.Click += cancelSearchButton_Click;
            // 
            // addProdButton
            // 
            addProdButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addProdButton.BackColor = Color.Maroon;
            addProdButton.Cursor = Cursors.Hand;
            addProdButton.FlatStyle = FlatStyle.Popup;
            addProdButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProdButton.ForeColor = Color.White;
            addProdButton.Location = new Point(1046, 48);
            addProdButton.Margin = new Padding(3, 2, 3, 2);
            addProdButton.Name = "addProdButton";
            addProdButton.Size = new Size(184, 37);
            addProdButton.TabIndex = 8;
            addProdButton.Text = "ADD PRODUCT";
            addProdButton.UseVisualStyleBackColor = false;
            addProdButton.Click += addProdButton_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 24, 33);
            ClientSize = new Size(1264, 681);
            Controls.Add(addProdButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "InventoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop Manager";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label searchLabelHeader;
        private TextBox searchTextBox;
        private ImageList imageList1;
        private PictureBox searchIcon;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
        private Panel panel1;
        private Button addProdButton;
        private Button cancelSearchButton;
        private DataGridView dataGridView;
    }
}