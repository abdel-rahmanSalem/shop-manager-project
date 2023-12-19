namespace shopManager
{
    partial class StockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockForm));
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            checkOutBtn = new Button();
            addItemBtn = new Button();
            home3buttnPage = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(31, 32, 60);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(205, 76);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(833, 370);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Quantity";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // checkOutBtn
            // 
            checkOutBtn.Anchor = AnchorStyles.None;
            checkOutBtn.BackColor = Color.Maroon;
            checkOutBtn.Cursor = Cursors.Hand;
            checkOutBtn.FlatStyle = FlatStyle.Popup;
            checkOutBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkOutBtn.ForeColor = Color.White;
            checkOutBtn.Location = new Point(720, 500);
            checkOutBtn.Name = "checkOutBtn";
            checkOutBtn.Size = new Size(108, 30);
            checkOutBtn.TabIndex = 1;
            checkOutBtn.Text = "Check Out";
            checkOutBtn.UseVisualStyleBackColor = false;
            checkOutBtn.Click += checkOutBtn_Click;
            // 
            // addItemBtn
            // 
            addItemBtn.Anchor = AnchorStyles.None;
            addItemBtn.BackColor = Color.FromArgb(6, 90, 37);
            addItemBtn.Cursor = Cursors.Hand;
            addItemBtn.FlatStyle = FlatStyle.Popup;
            addItemBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addItemBtn.ForeColor = Color.White;
            addItemBtn.Location = new Point(380, 500);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Size = new Size(108, 30);
            addItemBtn.TabIndex = 2;
            addItemBtn.Text = "Add Item";
            addItemBtn.UseVisualStyleBackColor = false;
            addItemBtn.Click += addItemBtn_Click;
            // 
            // home3buttnPage
            // 
            home3buttnPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            home3buttnPage.BackColor = Color.FromArgb(15, 16, 43);
            home3buttnPage.BackgroundImage = Properties.Resources.homepage1;
            home3buttnPage.BackgroundImageLayout = ImageLayout.Zoom;
            home3buttnPage.Cursor = Cursors.Hand;
            home3buttnPage.FlatStyle = FlatStyle.Flat;
            home3buttnPage.Location = new Point(34, 593);
            home3buttnPage.Margin = new Padding(3, 2, 3, 2);
            home3buttnPage.Name = "home3buttnPage";
            home3buttnPage.Size = new Size(75, 51);
            home3buttnPage.TabIndex = 3;
            home3buttnPage.UseVisualStyleBackColor = false;
            home3buttnPage.Click += home3buttnPage_Click;
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 32);
            BackgroundImage = Properties.Resources.Screenshot__54_;
            ClientSize = new Size(1264, 661);
            Controls.Add(home3buttnPage);
            Controls.Add(addItemBtn);
            Controls.Add(checkOutBtn);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "StockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shoping Cart";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        public DataGridView DataGridView1
        {
            get { return dataGridView1; }
        }
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button checkOutBtn;
        private Button addItemBtn;
        private Button home3buttnPage;
    }
}