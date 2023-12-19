namespace shopManager
{
    partial class HomepageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.homepageLabel = new System.Windows.Forms.Label();
            this.notificationPictureBox = new System.Windows.Forms.PictureBox();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.stockButton = new System.Windows.Forms.Button();
            this.addprodButton = new System.Windows.Forms.Button();
            this.hiLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.settingsPictureBox = new System.Windows.Forms.PictureBox();
            this.accountPictureBox = new System.Windows.Forms.PictureBox();
            this.locationPictureBox = new System.Windows.Forms.PictureBox();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notificationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.homepageLabel);
            this.panel1.Controls.Add(this.notificationPictureBox);
            this.panel1.Controls.Add(this.profilePictureBox);
            this.panel1.Controls.Add(this.inventoryButton);
            this.panel1.Controls.Add(this.stockButton);
            this.panel1.Controls.Add(this.addprodButton);
            this.panel1.Controls.Add(this.hiLabel);
            this.panel1.Location = new System.Drawing.Point(216, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1480, 867);
            this.panel1.TabIndex = 0;
            // 
            // homepageLabel
            // 
            this.homepageLabel.AutoSize = true;
            this.homepageLabel.BackColor = System.Drawing.Color.Transparent;
            this.homepageLabel.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homepageLabel.ForeColor = System.Drawing.Color.LightGray;
            this.homepageLabel.Location = new System.Drawing.Point(66, 67);
            this.homepageLabel.Name = "homepageLabel";
            this.homepageLabel.Size = new System.Drawing.Size(241, 52);
            this.homepageLabel.TabIndex = 7;
            this.homepageLabel.Text = "Homepage";
            // 
            // notificationPictureBox
            // 
            this.notificationPictureBox.BackgroundImage = global::shopManager.Properties.Resources.noification;
            this.notificationPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.notificationPictureBox.Location = new System.Drawing.Point(1497, 0);
            this.notificationPictureBox.Name = "notificationPictureBox";
            this.notificationPictureBox.Size = new System.Drawing.Size(50, 45);
            this.notificationPictureBox.TabIndex = 6;
            this.notificationPictureBox.TabStop = false;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackgroundImage = global::shopManager.Properties.Resources.profile;
            this.profilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profilePictureBox.Location = new System.Drawing.Point(1554, 0);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(51, 45);
            this.profilePictureBox.TabIndex = 5;
            this.profilePictureBox.TabStop = false;
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(43)))));
            this.inventoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inventoryButton.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inventoryButton.ForeColor = System.Drawing.Color.LightGray;
            this.inventoryButton.Location = new System.Drawing.Point(1146, 233);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(453, 119);
            this.inventoryButton.TabIndex = 4;
            this.inventoryButton.Text = "Stock";
            this.inventoryButton.UseVisualStyleBackColor = false;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // stockButton
            // 
            this.stockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(43)))));
            this.stockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stockButton.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stockButton.ForeColor = System.Drawing.Color.LightGray;
            this.stockButton.Location = new System.Drawing.Point(602, 233);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(459, 119);
            this.stockButton.TabIndex = 3;
            this.stockButton.Text = "Shopping Cart";
            this.stockButton.UseVisualStyleBackColor = false;
            this.stockButton.Click += new System.EventHandler(this.stockButton_Click);
            // 
            // addprodButton
            // 
            this.addprodButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(43)))));
            this.addprodButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addprodButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addprodButton.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addprodButton.ForeColor = System.Drawing.Color.LightGray;
            this.addprodButton.Location = new System.Drawing.Point(79, 233);
            this.addprodButton.Name = "addprodButton";
            this.addprodButton.Size = new System.Drawing.Size(448, 119);
            this.addprodButton.TabIndex = 2;
            this.addprodButton.Text = "Add Product";
            this.addprodButton.UseVisualStyleBackColor = false;
            this.addprodButton.Click += new System.EventHandler(this.addprodButton_Click);
            // 
            // hiLabel
            // 
            this.hiLabel.AutoSize = true;
            this.hiLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hiLabel.ForeColor = System.Drawing.Color.LightGray;
            this.hiLabel.Location = new System.Drawing.Point(111, 125);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(122, 27);
            this.hiLabel.TabIndex = 1;
            this.hiLabel.Text = "Hi, Employee";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.logoutButton);
            this.panel2.Controls.Add(this.settingsPictureBox);
            this.panel2.Controls.Add(this.accountPictureBox);
            this.panel2.Controls.Add(this.locationPictureBox);
            this.panel2.Controls.Add(this.homePictureBox);
            this.panel2.Controls.Add(this.settingsLabel);
            this.panel2.Controls.Add(this.logoutLabel);
            this.panel2.Controls.Add(this.accountLabel);
            this.panel2.Controls.Add(this.locationLabel);
            this.panel2.Controls.Add(this.homeLabel);
            this.panel2.Location = new System.Drawing.Point(11, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 867);
            this.panel2.TabIndex = 5;
            // 
            // logoutButton
            // 
            this.logoutButton.BackgroundImage = global::shopManager.Properties.Resources.logout;
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(43)))));
            this.logoutButton.Location = new System.Drawing.Point(11, 213);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(37, 35);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // settingsPictureBox
            // 
            this.settingsPictureBox.BackgroundImage = global::shopManager.Properties.Resources.settings;
            this.settingsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsPictureBox.Location = new System.Drawing.Point(11, 799);
            this.settingsPictureBox.Name = "settingsPictureBox";
            this.settingsPictureBox.Size = new System.Drawing.Size(39, 45);
            this.settingsPictureBox.TabIndex = 5;
            this.settingsPictureBox.TabStop = false;
            // 
            // accountPictureBox
            // 
            this.accountPictureBox.BackgroundImage = global::shopManager.Properties.Resources.profile;
            this.accountPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accountPictureBox.Location = new System.Drawing.Point(11, 125);
            this.accountPictureBox.Name = "accountPictureBox";
            this.accountPictureBox.Size = new System.Drawing.Size(34, 27);
            this.accountPictureBox.TabIndex = 5;
            this.accountPictureBox.TabStop = false;
            // 
            // locationPictureBox
            // 
            this.locationPictureBox.BackgroundImage = global::shopManager.Properties.Resources.locations;
            this.locationPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.locationPictureBox.Location = new System.Drawing.Point(9, 91);
            this.locationPictureBox.Name = "locationPictureBox";
            this.locationPictureBox.Size = new System.Drawing.Size(41, 27);
            this.locationPictureBox.TabIndex = 5;
            this.locationPictureBox.TabStop = false;
            // 
            // homePictureBox
            // 
            this.homePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.homePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePictureBox.BackgroundImage")));
            this.homePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homePictureBox.Location = new System.Drawing.Point(11, 57);
            this.homePictureBox.Name = "homePictureBox";
            this.homePictureBox.Size = new System.Drawing.Size(37, 24);
            this.homePictureBox.TabIndex = 5;
            this.homePictureBox.TabStop = false;
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsLabel.ForeColor = System.Drawing.Color.LightGray;
            this.settingsLabel.Location = new System.Drawing.Point(51, 812);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(69, 24);
            this.settingsLabel.TabIndex = 4;
            this.settingsLabel.Text = "Settings";
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutLabel.ForeColor = System.Drawing.Color.LightGray;
            this.logoutLabel.Location = new System.Drawing.Point(51, 217);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(69, 24);
            this.logoutLabel.TabIndex = 3;
            this.logoutLabel.Text = "Log Out";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountLabel.ForeColor = System.Drawing.Color.LightGray;
            this.accountLabel.Location = new System.Drawing.Point(51, 129);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(69, 24);
            this.accountLabel.TabIndex = 2;
            this.accountLabel.Text = "Account";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locationLabel.ForeColor = System.Drawing.Color.LightGray;
            this.locationLabel.Location = new System.Drawing.Point(51, 93);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(79, 24);
            this.locationLabel.TabIndex = 1;
            this.locationLabel.Text = "Locations";
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeLabel.ForeColor = System.Drawing.Color.LightGray;
            this.homeLabel.Location = new System.Drawing.Point(51, 57);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(91, 24);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "Homepage";
            // 
            // HomepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::shopManager.Properties.Resources.Screenshot__54_;
            this.ClientSize = new System.Drawing.Size(1445, 881);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HomepageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomepageForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notificationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label hiLabel;
        private Button addprodButton;
        private Button inventoryButton;
        private Button stockButton;
        private Panel panel2;
        private Label homeLabel;
        private Label locationLabel;
        private Label settingsLabel;
        private Label logoutLabel;
        private Label accountLabel;
        private PictureBox homePictureBox;
        private PictureBox locationPictureBox;
        private PictureBox settingsPictureBox;
        private PictureBox accountPictureBox;
        private PictureBox profilePictureBox;
        private PictureBox notificationPictureBox;
        private Label homepageLabel;
        private Button logoutButton;
    }
}