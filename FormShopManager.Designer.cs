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
            addButton = new Button();
            searchLabelHeader = new Label();
            searchTextBox = new TextBox();
            bynameButton = new Button();
            byidButton = new Button();
            imageList1 = new ImageList(components);
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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButton.BackColor = Color.FromArgb(114, 0, 0);
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(1408, 148);
            addButton.Name = "addButton";
            addButton.Size = new Size(216, 49);
            addButton.TabIndex = 5;
            addButton.Text = "Add New Product";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // searchLabelHeader
            // 
            searchLabelHeader.AutoSize = true;
            searchLabelHeader.Font = new Font("Arial", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            searchLabelHeader.ForeColor = Color.LightGray;
            searchLabelHeader.Location = new Point(159, 55);
            searchLabelHeader.Name = "searchLabelHeader";
            searchLabelHeader.Size = new Size(126, 38);
            searchLabelHeader.TabIndex = 24;
            searchLabelHeader.Text = "Search";
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.LightGray;
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.ForeColor = Color.Black;
            searchTextBox.Location = new Point(291, 57);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(806, 36);
            searchTextBox.TabIndex = 7;
            // 
            // bynameButton
            // 
            bynameButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bynameButton.BackColor = Color.FromArgb(42, 61, 85);
            bynameButton.FlatStyle = FlatStyle.Popup;
            bynameButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bynameButton.ForeColor = Color.White;
            bynameButton.Location = new Point(1125, 55);
            bynameButton.Name = "bynameButton";
            bynameButton.Size = new Size(143, 49);
            bynameButton.TabIndex = 8;
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
            byidButton.Location = new Point(1301, 57);
            byidButton.Name = "byidButton";
            byidButton.Size = new Size(143, 49);
            byidButton.TabIndex = 9;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.Image = Properties.Resources.R;
            pictureBox1.Location = new Point(1067, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(byidButton);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(bynameButton);
            panel2.Controls.Add(searchLabelHeader);
            panel2.Controls.Add(searchTextBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1650, 215);
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
            dataGridView.Location = new Point(86, 15);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.ShowEditingIcon = false;
            dataGridView.Size = new Size(1362, 23);
            dataGridView.TabIndex = 6;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "ID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Category";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Price";
            Column5.MinimumWidth = 6;
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
            Column6.MinimumWidth = 6;
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
            Column7.MinimumWidth = 6;
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
            panel1.Controls.Add(dataGridView);
            panel1.Location = new Point(34, 242);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1590, 610);
            panel1.TabIndex = 36;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 24, 33);
            ClientSize = new Size(1650, 881);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button addButton;
        private Label searchLabelHeader;
        private TextBox searchTextBox;
        private Button bynameButton;
        private Button byidButton;
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
        private Panel panel1;
    }
}