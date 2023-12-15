namespace shopManager
{
    partial class updateForm
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
            this.updateLabel2 = new System.Windows.Forms.Label();
            this.idUpdatedTextBox = new System.Windows.Forms.TextBox();
            this.idUpdatedLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateNumricUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.prupdatedlist = new System.Windows.Forms.ColumnHeader();
            this.quanupdatedlist = new System.Windows.Forms.ColumnHeader();
            this.lowstockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updateNumricUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateLabel2
            // 
            this.updateLabel2.AutoSize = true;
            this.updateLabel2.BackColor = System.Drawing.Color.Transparent;
            this.updateLabel2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateLabel2.ForeColor = System.Drawing.Color.LightGray;
            this.updateLabel2.Location = new System.Drawing.Point(21, 177);
            this.updateLabel2.Name = "updateLabel2";
            this.updateLabel2.Size = new System.Drawing.Size(150, 38);
            this.updateLabel2.TabIndex = 1;
            this.updateLabel2.Text = "Quantity";
            // 
            // idUpdatedTextBox
            // 
            this.idUpdatedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.idUpdatedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idUpdatedTextBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idUpdatedTextBox.ForeColor = System.Drawing.Color.White;
            this.idUpdatedTextBox.Location = new System.Drawing.Point(193, 66);
            this.idUpdatedTextBox.Name = "idUpdatedTextBox";
            this.idUpdatedTextBox.Size = new System.Drawing.Size(270, 36);
            this.idUpdatedTextBox.TabIndex = 0;
            // 
            // idUpdatedLabel
            // 
            this.idUpdatedLabel.AutoSize = true;
            this.idUpdatedLabel.BackColor = System.Drawing.Color.Transparent;
            this.idUpdatedLabel.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idUpdatedLabel.ForeColor = System.Drawing.Color.LightGray;
            this.idUpdatedLabel.Location = new System.Drawing.Point(21, 66);
            this.idUpdatedLabel.Name = "idUpdatedLabel";
            this.idUpdatedLabel.Size = new System.Drawing.Size(55, 44);
            this.idUpdatedLabel.TabIndex = 0;
            this.idUpdatedLabel.Text = "ID";
            this.idUpdatedLabel.Click += new System.EventHandler(this.idUpdatedLabel_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightGray;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.updateButton.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(193, 291);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(115, 40);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // updateNumricUpDown
            // 
            this.updateNumricUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.updateNumricUpDown.BackColor = System.Drawing.Color.LightGray;
            this.updateNumricUpDown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateNumricUpDown.Location = new System.Drawing.Point(193, 177);
            this.updateNumricUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updateNumricUpDown.Name = "updateNumricUpDown";
            this.updateNumricUpDown.Size = new System.Drawing.Size(270, 35);
            this.updateNumricUpDown.TabIndex = 2;
            this.updateNumricUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateNumricUpDown.ValueChanged += new System.EventHandler(this.updateNumricUpDown_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.idUpdatedLabel);
            this.groupBox1.Controls.Add(this.idUpdatedTextBox);
            this.groupBox1.Controls.Add(this.updateNumricUpDown);
            this.groupBox1.Controls.Add(this.updateLabel2);
            this.groupBox1.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(45, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 381);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restock Status ";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(43)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.quanupdatedlist,
            this.prupdatedlist});
            this.listView1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.ForeColor = System.Drawing.Color.LightGray;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(45, 65);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(564, 299);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // prupdatedlist
            // 
            this.prupdatedlist.DisplayIndex = 0;
            this.prupdatedlist.Tag = "1";
            this.prupdatedlist.Text = "Product ID";
            this.prupdatedlist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prupdatedlist.Width = 280;
            // 
            // quanupdatedlist
            // 
            this.quanupdatedlist.DisplayIndex = 1;
            this.quanupdatedlist.Tag = "1";
            this.quanupdatedlist.Text = "                 Quantity";
            this.quanupdatedlist.Width = 280;
            // 
            // lowstockLabel
            // 
            this.lowstockLabel.AutoSize = true;
            this.lowstockLabel.BackColor = System.Drawing.Color.Transparent;
            this.lowstockLabel.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lowstockLabel.ForeColor = System.Drawing.Color.LightGray;
            this.lowstockLabel.Location = new System.Drawing.Point(45, 18);
            this.lowstockLabel.Name = "lowstockLabel";
            this.lowstockLabel.Size = new System.Drawing.Size(319, 32);
            this.lowstockLabel.TabIndex = 7;
            this.lowstockLabel.Text = "Low Stock Products :";
            // 
            // updateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::shopManager.Properties.Resources.Screenshot__54_;
            this.ClientSize = new System.Drawing.Size(645, 784);
            this.Controls.Add(this.lowstockLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "updateForm";
            this.Text = "updateForm";
            ((System.ComponentModel.ISupportInitialize)(this.updateNumricUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label updateLabel2;
        private TextBox idUpdatedTextBox;
        private Label idUpdatedLabel;
        private Button updateButton;
        private NumericUpDown updateNumricUpDown;
        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader prupdatedlist;
        private ColumnHeader quanupdatedlist;
        private Label lowstockLabel;
    }
}