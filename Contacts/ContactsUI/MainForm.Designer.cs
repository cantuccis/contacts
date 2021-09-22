
namespace ContactsUI
{
    partial class Contacts
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
            this.tabsControl = new MaterialSkin.Controls.MaterialTabControl();
            this.contactsTab = new System.Windows.Forms.TabPage();
            this.previousProfileButton = new MaterialSkin.Controls.MaterialButton();
            this.nextProfileButton = new MaterialSkin.Controls.MaterialButton();
            this.contactCard = new MaterialSkin.Controls.MaterialCard();
            this.addressText = new MaterialSkin.Controls.MaterialLabel();
            this.phoneText = new MaterialSkin.Controls.MaterialLabel();
            this.ageText = new MaterialSkin.Controls.MaterialLabel();
            this.nameText = new MaterialSkin.Controls.MaterialLabel();
            this.addressLabel = new MaterialSkin.Controls.MaterialLabel();
            this.phoneNumberLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ageLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.contactPicture = new System.Windows.Forms.PictureBox();
            this.newContactTab = new System.Windows.Forms.TabPage();
            this.saveProfileButton = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.chooseFileButton = new MaterialSkin.Controls.MaterialButton();
            this.profilePictureFilenameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.addressInput = new MaterialSkin.Controls.MaterialTextBox();
            this.phoneInput = new MaterialSkin.Controls.MaterialTextBox();
            this.lastNameInput = new MaterialSkin.Controls.MaterialTextBox();
            this.firstNameInput = new MaterialSkin.Controls.MaterialTextBox();
            this.newProfilePicture = new System.Windows.Forms.PictureBox();
            this.resultLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tabsControl.SuspendLayout();
            this.contactsTab.SuspendLayout();
            this.contactCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactPicture)).BeginInit();
            this.newContactTab.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.contactsTab);
            this.tabsControl.Controls.Add(this.newContactTab);
            this.tabsControl.Depth = 0;
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Location = new System.Drawing.Point(3, 64);
            this.tabsControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabsControl.Multiline = true;
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(794, 534);
            this.tabsControl.TabIndex = 3;
            // 
            // contactsTab
            // 
            this.contactsTab.BackColor = System.Drawing.Color.White;
            this.contactsTab.Controls.Add(this.previousProfileButton);
            this.contactsTab.Controls.Add(this.nextProfileButton);
            this.contactsTab.Controls.Add(this.contactCard);
            this.contactsTab.Location = new System.Drawing.Point(4, 29);
            this.contactsTab.Name = "contactsTab";
            this.contactsTab.Padding = new System.Windows.Forms.Padding(3);
            this.contactsTab.Size = new System.Drawing.Size(786, 501);
            this.contactsTab.TabIndex = 0;
            this.contactsTab.Text = "Contacts";
            // 
            // previousProfileButton
            // 
            this.previousProfileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previousProfileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.previousProfileButton.Depth = 0;
            this.previousProfileButton.HighEmphasis = true;
            this.previousProfileButton.Icon = null;
            this.previousProfileButton.Location = new System.Drawing.Point(313, 412);
            this.previousProfileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.previousProfileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.previousProfileButton.Name = "previousProfileButton";
            this.previousProfileButton.Size = new System.Drawing.Size(64, 36);
            this.previousProfileButton.TabIndex = 2;
            this.previousProfileButton.Text = "Prev";
            this.previousProfileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.previousProfileButton.UseAccentColor = false;
            this.previousProfileButton.UseVisualStyleBackColor = true;
            // 
            // nextProfileButton
            // 
            this.nextProfileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextProfileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.nextProfileButton.Depth = 0;
            this.nextProfileButton.HighEmphasis = true;
            this.nextProfileButton.Icon = null;
            this.nextProfileButton.Location = new System.Drawing.Point(408, 412);
            this.nextProfileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nextProfileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextProfileButton.Name = "nextProfileButton";
            this.nextProfileButton.Size = new System.Drawing.Size(64, 36);
            this.nextProfileButton.TabIndex = 1;
            this.nextProfileButton.Text = "Next";
            this.nextProfileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.nextProfileButton.UseAccentColor = false;
            this.nextProfileButton.UseVisualStyleBackColor = true;
            this.nextProfileButton.Click += new System.EventHandler(this.nextProfileButton_Click);
            // 
            // contactCard
            // 
            this.contactCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contactCard.Controls.Add(this.addressText);
            this.contactCard.Controls.Add(this.phoneText);
            this.contactCard.Controls.Add(this.ageText);
            this.contactCard.Controls.Add(this.nameText);
            this.contactCard.Controls.Add(this.addressLabel);
            this.contactCard.Controls.Add(this.phoneNumberLabel);
            this.contactCard.Controls.Add(this.ageLabel);
            this.contactCard.Controls.Add(this.nameLabel);
            this.contactCard.Controls.Add(this.contactPicture);
            this.contactCard.Depth = 0;
            this.contactCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contactCard.Location = new System.Drawing.Point(17, 17);
            this.contactCard.Margin = new System.Windows.Forms.Padding(14);
            this.contactCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.contactCard.Name = "contactCard";
            this.contactCard.Padding = new System.Windows.Forms.Padding(14);
            this.contactCard.Size = new System.Drawing.Size(752, 375);
            this.contactCard.TabIndex = 0;
            // 
            // addressText
            // 
            this.addressText.AutoSize = true;
            this.addressText.Depth = 0;
            this.addressText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addressText.Location = new System.Drawing.Point(460, 230);
            this.addressText.MouseState = MaterialSkin.MouseState.HOVER;
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(1, 0);
            this.addressText.TabIndex = 8;
            this.addressText.UseAccent = true;
            // 
            // phoneText
            // 
            this.phoneText.AutoSize = true;
            this.phoneText.Depth = 0;
            this.phoneText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneText.Location = new System.Drawing.Point(460, 180);
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
            this.ageText.Location = new System.Drawing.Point(460, 130);
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
            this.nameText.Location = new System.Drawing.Point(460, 80);
            this.nameText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(1, 0);
            this.nameText.TabIndex = 5;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Depth = 0;
            this.addressLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addressLabel.Location = new System.Drawing.Point(375, 230);
            this.addressLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(62, 19);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address:";
            this.addressLabel.UseAccent = true;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Depth = 0;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneNumberLabel.Location = new System.Drawing.Point(375, 180);
            this.phoneNumberLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(50, 19);
            this.phoneNumberLabel.TabIndex = 3;
            this.phoneNumberLabel.Text = "Phone:";
            this.phoneNumberLabel.UseAccent = true;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Depth = 0;
            this.ageLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ageLabel.Location = new System.Drawing.Point(375, 130);
            this.ageLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(32, 19);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Age:";
            this.ageLabel.UseAccent = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Depth = 0;
            this.nameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameLabel.Location = new System.Drawing.Point(375, 80);
            this.nameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 19);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            this.nameLabel.UseAccent = true;
            // 
            // contactPicture
            // 
            this.contactPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactPicture.Location = new System.Drawing.Point(17, 17);
            this.contactPicture.Name = "contactPicture";
            this.contactPicture.Size = new System.Drawing.Size(300, 300);
            this.contactPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contactPicture.TabIndex = 0;
            this.contactPicture.TabStop = false;
            // 
            // newContactTab
            // 
            this.newContactTab.BackColor = System.Drawing.Color.White;
            this.newContactTab.Controls.Add(this.resultLabel);
            this.newContactTab.Controls.Add(this.saveProfileButton);
            this.newContactTab.Controls.Add(this.materialCard1);
            this.newContactTab.Location = new System.Drawing.Point(4, 29);
            this.newContactTab.Name = "newContactTab";
            this.newContactTab.Padding = new System.Windows.Forms.Padding(3);
            this.newContactTab.Size = new System.Drawing.Size(786, 501);
            this.newContactTab.TabIndex = 1;
            this.newContactTab.Text = "New contact";
            // 
            // saveProfileButton
            // 
            this.saveProfileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveProfileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveProfileButton.Depth = 0;
            this.saveProfileButton.HighEmphasis = true;
            this.saveProfileButton.Icon = null;
            this.saveProfileButton.Location = new System.Drawing.Point(351, 412);
            this.saveProfileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveProfileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveProfileButton.Name = "saveProfileButton";
            this.saveProfileButton.Size = new System.Drawing.Size(64, 36);
            this.saveProfileButton.TabIndex = 2;
            this.saveProfileButton.Text = "Save";
            this.saveProfileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveProfileButton.UseAccentColor = false;
            this.saveProfileButton.UseVisualStyleBackColor = true;
            this.saveProfileButton.Click += new System.EventHandler(this.saveProfileButton_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.chooseFileButton);
            this.materialCard1.Controls.Add(this.profilePictureFilenameLabel);
            this.materialCard1.Controls.Add(this.addressInput);
            this.materialCard1.Controls.Add(this.phoneInput);
            this.materialCard1.Controls.Add(this.lastNameInput);
            this.materialCard1.Controls.Add(this.firstNameInput);
            this.materialCard1.Controls.Add(this.newProfilePicture);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 17);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(752, 375);
            this.materialCard1.TabIndex = 1;
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chooseFileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.chooseFileButton.Depth = 0;
            this.chooseFileButton.HighEmphasis = true;
            this.chooseFileButton.Icon = null;
            this.chooseFileButton.Location = new System.Drawing.Point(238, 326);
            this.chooseFileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.chooseFileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(79, 36);
            this.chooseFileButton.TabIndex = 3;
            this.chooseFileButton.Text = "Choose";
            this.chooseFileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.chooseFileButton.UseAccentColor = false;
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // profilePictureFilenameLabel
            // 
            this.profilePictureFilenameLabel.AutoSize = true;
            this.profilePictureFilenameLabel.Depth = 0;
            this.profilePictureFilenameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.profilePictureFilenameLabel.Location = new System.Drawing.Point(17, 337);
            this.profilePictureFilenameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.profilePictureFilenameLabel.Name = "profilePictureFilenameLabel";
            this.profilePictureFilenameLabel.Size = new System.Drawing.Size(1, 0);
            this.profilePictureFilenameLabel.TabIndex = 3;
            // 
            // addressInput
            // 
            this.addressInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressInput.Depth = 0;
            this.addressInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addressInput.Hint = "Address";
            this.addressInput.LeadingIcon = null;
            this.addressInput.Location = new System.Drawing.Point(334, 185);
            this.addressInput.MaxLength = 50;
            this.addressInput.MouseState = MaterialSkin.MouseState.OUT;
            this.addressInput.Multiline = false;
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(401, 50);
            this.addressInput.TabIndex = 4;
            this.addressInput.Text = "";
            this.addressInput.TrailingIcon = null;
            // 
            // phoneInput
            // 
            this.phoneInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneInput.Depth = 0;
            this.phoneInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneInput.Hint = "Phone number";
            this.phoneInput.LeadingIcon = null;
            this.phoneInput.Location = new System.Drawing.Point(334, 129);
            this.phoneInput.MaxLength = 50;
            this.phoneInput.MouseState = MaterialSkin.MouseState.OUT;
            this.phoneInput.Multiline = false;
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(401, 50);
            this.phoneInput.TabIndex = 3;
            this.phoneInput.Text = "";
            this.phoneInput.TrailingIcon = null;
            // 
            // lastNameInput
            // 
            this.lastNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameInput.Depth = 0;
            this.lastNameInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lastNameInput.Hint = "Last name";
            this.lastNameInput.LeadingIcon = null;
            this.lastNameInput.Location = new System.Drawing.Point(334, 73);
            this.lastNameInput.MaxLength = 50;
            this.lastNameInput.MouseState = MaterialSkin.MouseState.OUT;
            this.lastNameInput.Multiline = false;
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(401, 50);
            this.lastNameInput.TabIndex = 2;
            this.lastNameInput.Text = "";
            this.lastNameInput.TrailingIcon = null;
            // 
            // firstNameInput
            // 
            this.firstNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameInput.Depth = 0;
            this.firstNameInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.firstNameInput.Hint = "First name";
            this.firstNameInput.LeadingIcon = null;
            this.firstNameInput.Location = new System.Drawing.Point(334, 17);
            this.firstNameInput.MaxLength = 50;
            this.firstNameInput.MouseState = MaterialSkin.MouseState.OUT;
            this.firstNameInput.Multiline = false;
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(401, 50);
            this.firstNameInput.TabIndex = 1;
            this.firstNameInput.Text = "";
            this.firstNameInput.TrailingIcon = null;
            // 
            // newProfilePicture
            // 
            this.newProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newProfilePicture.Location = new System.Drawing.Point(17, 17);
            this.newProfilePicture.Name = "newProfilePicture";
            this.newProfilePicture.Size = new System.Drawing.Size(300, 300);
            this.newProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newProfilePicture.TabIndex = 0;
            this.newProfilePicture.TabStop = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Depth = 0;
            this.resultLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.resultLabel.Location = new System.Drawing.Point(440, 423);
            this.resultLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(1, 0);
            this.resultLabel.TabIndex = 3;
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.tabsControl);
            this.DrawerTabControl = this.tabsControl;
            this.Name = "Contacts";
            this.Text = "ContactsUI";
            this.tabsControl.ResumeLayout(false);
            this.contactsTab.ResumeLayout(false);
            this.contactsTab.PerformLayout();
            this.contactCard.ResumeLayout(false);
            this.contactCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactPicture)).EndInit();
            this.newContactTab.ResumeLayout(false);
            this.newContactTab.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tabsControl;
        private System.Windows.Forms.TabPage contactsTab;
        private MaterialSkin.Controls.MaterialCard contactCard;
        private System.Windows.Forms.TabPage newContactTab;
        private MaterialSkin.Controls.MaterialLabel nameLabel;
        private System.Windows.Forms.PictureBox contactPicture;
        private MaterialSkin.Controls.MaterialLabel ageLabel;
        private MaterialSkin.Controls.MaterialLabel addressLabel;
        private MaterialSkin.Controls.MaterialLabel phoneNumberLabel;
        private MaterialSkin.Controls.MaterialLabel addressText;
        private MaterialSkin.Controls.MaterialLabel phoneText;
        private MaterialSkin.Controls.MaterialLabel ageText;
        private MaterialSkin.Controls.MaterialLabel nameText;
        private MaterialSkin.Controls.MaterialButton nextProfileButton;
        private MaterialSkin.Controls.MaterialButton previousProfileButton;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox firstNameInput;
        private System.Windows.Forms.PictureBox newProfilePicture;
        private MaterialSkin.Controls.MaterialTextBox phoneInput;
        private MaterialSkin.Controls.MaterialTextBox lastNameInput;
        private MaterialSkin.Controls.MaterialButton saveProfileButton;
        private MaterialSkin.Controls.MaterialTextBox addressInput;
        private MaterialSkin.Controls.MaterialButton chooseFileButton;
        private MaterialSkin.Controls.MaterialLabel profilePictureFilenameLabel;
        private MaterialSkin.Controls.MaterialLabel resultLabel;
    }
}

