
namespace ContactsUI
{
    partial class ProfilesNavigator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contactCard = new MaterialSkin.Controls.MaterialCard();
            this.previousProfileButton = new MaterialSkin.Controls.MaterialButton();
            this.addressText = new MaterialSkin.Controls.MaterialLabel();
            this.nextProfileButton = new MaterialSkin.Controls.MaterialButton();
            this.phoneText = new MaterialSkin.Controls.MaterialLabel();
            this.ageText = new MaterialSkin.Controls.MaterialLabel();
            this.nameText = new MaterialSkin.Controls.MaterialLabel();
            this.addressLabel = new MaterialSkin.Controls.MaterialLabel();
            this.phoneNumberLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ageLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.noProfilesLabel = new System.Windows.Forms.Label();
            this.contactCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contactCard
            // 
            this.contactCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contactCard.Controls.Add(this.previousProfileButton);
            this.contactCard.Controls.Add(this.addressText);
            this.contactCard.Controls.Add(this.nextProfileButton);
            this.contactCard.Controls.Add(this.phoneText);
            this.contactCard.Controls.Add(this.ageText);
            this.contactCard.Controls.Add(this.nameText);
            this.contactCard.Controls.Add(this.addressLabel);
            this.contactCard.Controls.Add(this.phoneNumberLabel);
            this.contactCard.Controls.Add(this.ageLabel);
            this.contactCard.Controls.Add(this.nameLabel);
            this.contactCard.Controls.Add(this.profilePictureBox);
            this.contactCard.Depth = 0;
            this.contactCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contactCard.Location = new System.Drawing.Point(14, 14);
            this.contactCard.Margin = new System.Windows.Forms.Padding(14);
            this.contactCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.contactCard.Name = "contactCard";
            this.contactCard.Padding = new System.Windows.Forms.Padding(14);
            this.contactCard.Size = new System.Drawing.Size(762, 375);
            this.contactCard.TabIndex = 1;
            // 
            // previousProfileButton
            // 
            this.previousProfileButton.AutoSize = false;
            this.previousProfileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previousProfileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.previousProfileButton.Depth = 0;
            this.previousProfileButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.previousProfileButton.HighEmphasis = true;
            this.previousProfileButton.Icon = null;
            this.previousProfileButton.Location = new System.Drawing.Point(18, 161);
            this.previousProfileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.previousProfileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.previousProfileButton.Name = "previousProfileButton";
            this.previousProfileButton.Size = new System.Drawing.Size(32, 36);
            this.previousProfileButton.TabIndex = 4;
            this.previousProfileButton.Text = "ᐊ";
            this.previousProfileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.previousProfileButton.UseAccentColor = false;
            this.previousProfileButton.UseVisualStyleBackColor = true;
            this.previousProfileButton.Click += new System.EventHandler(this.previousProfileButton_Click);
            // 
            // addressText
            // 
            this.addressText.AutoSize = true;
            this.addressText.Depth = 0;
            this.addressText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addressText.Location = new System.Drawing.Point(485, 244);
            this.addressText.MaximumSize = new System.Drawing.Size(200, 0);
            this.addressText.MouseState = MaterialSkin.MouseState.HOVER;
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(1, 0);
            this.addressText.TabIndex = 8;
            this.addressText.UseAccent = true;
            // 
            // nextProfileButton
            // 
            this.nextProfileButton.AutoEllipsis = true;
            this.nextProfileButton.AutoSize = false;
            this.nextProfileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextProfileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.nextProfileButton.Depth = 0;
            this.nextProfileButton.HighEmphasis = true;
            this.nextProfileButton.Icon = null;
            this.nextProfileButton.Location = new System.Drawing.Point(712, 161);
            this.nextProfileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nextProfileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextProfileButton.Name = "nextProfileButton";
            this.nextProfileButton.Size = new System.Drawing.Size(32, 36);
            this.nextProfileButton.TabIndex = 3;
            this.nextProfileButton.Text = "ᐅ";
            this.nextProfileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.nextProfileButton.UseAccentColor = false;
            this.nextProfileButton.UseVisualStyleBackColor = true;
            this.nextProfileButton.Click += new System.EventHandler(this.nextProfileButton_Click);
            // 
            // phoneText
            // 
            this.phoneText.AutoSize = true;
            this.phoneText.Depth = 0;
            this.phoneText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneText.Location = new System.Drawing.Point(485, 194);
            this.phoneText.MaximumSize = new System.Drawing.Size(200, 0);
            this.phoneText.MouseState = MaterialSkin.MouseState.HOVER;
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(1, 0);
            this.phoneText.TabIndex = 7;
            this.phoneText.UseAccent = true;
            // 
            // ageText
            // 
            this.ageText.AutoSize = true;
            this.ageText.Depth = 0;
            this.ageText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ageText.Location = new System.Drawing.Point(485, 144);
            this.ageText.MaximumSize = new System.Drawing.Size(200, 0);
            this.ageText.MouseState = MaterialSkin.MouseState.HOVER;
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(1, 0);
            this.ageText.TabIndex = 6;
            this.ageText.UseAccent = true;
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Depth = 0;
            this.nameText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameText.Location = new System.Drawing.Point(485, 94);
            this.nameText.MaximumSize = new System.Drawing.Size(200, 0);
            this.nameText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(1, 0);
            this.nameText.TabIndex = 5;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Depth = 0;
            this.addressLabel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.addressLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.addressLabel.Location = new System.Drawing.Point(400, 244);
            this.addressLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(57, 17);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address:";
            this.addressLabel.UseAccent = true;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Depth = 0;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.phoneNumberLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.phoneNumberLabel.Location = new System.Drawing.Point(400, 194);
            this.phoneNumberLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(46, 17);
            this.phoneNumberLabel.TabIndex = 3;
            this.phoneNumberLabel.Text = "Phone:";
            this.phoneNumberLabel.UseAccent = true;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Depth = 0;
            this.ageLabel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ageLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.ageLabel.Location = new System.Drawing.Point(400, 144);
            this.ageLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(30, 17);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Age:";
            this.ageLabel.UseAccent = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Depth = 0;
            this.nameLabel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.nameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.nameLabel.Location = new System.Drawing.Point(400, 94);
            this.nameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            this.nameLabel.UseAccent = true;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.ErrorImage = global::ContactsUI.Properties.Resources.wanted;
            this.profilePictureBox.Image = global::ContactsUI.Properties.Resources.user;
            this.profilePictureBox.InitialImage = global::ContactsUI.Properties.Resources.user;
            this.profilePictureBox.Location = new System.Drawing.Point(70, 31);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Padding = new System.Windows.Forms.Padding(10);
            this.profilePictureBox.Size = new System.Drawing.Size(300, 300);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // noProfilesLabel
            // 
            this.noProfilesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noProfilesLabel.ForeColor = System.Drawing.Color.Gray;
            this.noProfilesLabel.Location = new System.Drawing.Point(0, 147);
            this.noProfilesLabel.Name = "noProfilesLabel";
            this.noProfilesLabel.Size = new System.Drawing.Size(790, 75);
            this.noProfilesLabel.TabIndex = 2;
            this.noProfilesLabel.Text = "You don\'t have any contacts yet :(\r\nAdd new contacts in the upper left menu";
            this.noProfilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfilesNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contactCard);
            this.Controls.Add(this.noProfilesLabel);
            this.Name = "ProfilesNavigator";
            this.Size = new System.Drawing.Size(790, 408);
            this.VisibleChanged += new System.EventHandler(this.ProfilesNavigator_VisibleChanged);
            this.contactCard.ResumeLayout(false);
            this.contactCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard contactCard;
        private MaterialSkin.Controls.MaterialLabel addressText;
        private MaterialSkin.Controls.MaterialLabel phoneText;
        private MaterialSkin.Controls.MaterialLabel ageText;
        private MaterialSkin.Controls.MaterialLabel nameText;
        private MaterialSkin.Controls.MaterialLabel addressLabel;
        private MaterialSkin.Controls.MaterialLabel phoneNumberLabel;
        private MaterialSkin.Controls.MaterialLabel ageLabel;
        private MaterialSkin.Controls.MaterialLabel nameLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private MaterialSkin.Controls.MaterialButton previousProfileButton;
        private MaterialSkin.Controls.MaterialButton nextProfileButton;
        private System.Windows.Forms.Label noProfilesLabel;
    }
}
