
namespace ContactsUI.Controls.ProfileControls
{
    partial class NewProfile
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
            this.birthdayPickerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.chooseFileButton = new MaterialSkin.Controls.MaterialButton();
            this.addressInput = new MaterialSkin.Controls.MaterialTextBox();
            this.phoneInput = new MaterialSkin.Controls.MaterialTextBox();
            this.lastNameInput = new MaterialSkin.Controls.MaterialTextBox();
            this.firstNameInput = new MaterialSkin.Controls.MaterialTextBox();
            this.newProfilePicture = new System.Windows.Forms.PictureBox();
            this.saveProfileButton = new MaterialSkin.Controls.MaterialButton();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.resultLabel = new System.Windows.Forms.Label();
            this.profilePictureFilenameLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.newProfilePicture)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // birthdayPickerLabel
            // 
            this.birthdayPickerLabel.AutoSize = true;
            this.birthdayPickerLabel.Depth = 0;
            this.birthdayPickerLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.birthdayPickerLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.birthdayPickerLabel.Location = new System.Drawing.Point(334, 244);
            this.birthdayPickerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.birthdayPickerLabel.Name = "birthdayPickerLabel";
            this.birthdayPickerLabel.Size = new System.Drawing.Size(46, 14);
            this.birthdayPickerLabel.TabIndex = 6;
            this.birthdayPickerLabel.Text = "Birthday";
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
            this.addressInput.Size = new System.Drawing.Size(411, 50);
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
            this.phoneInput.Size = new System.Drawing.Size(411, 50);
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
            this.lastNameInput.Size = new System.Drawing.Size(411, 50);
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
            this.firstNameInput.Size = new System.Drawing.Size(411, 50);
            this.firstNameInput.TabIndex = 1;
            this.firstNameInput.Text = "";
            this.firstNameInput.TrailingIcon = null;
            // 
            // newProfilePicture
            // 
            this.newProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newProfilePicture.InitialImage = global::ContactsUI.Properties.Resources.person;
            this.newProfilePicture.Location = new System.Drawing.Point(17, 17);
            this.newProfilePicture.Name = "newProfilePicture";
            this.newProfilePicture.Size = new System.Drawing.Size(300, 300);
            this.newProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newProfilePicture.TabIndex = 0;
            this.newProfilePicture.TabStop = false;
            // 
            // saveProfileButton
            // 
            this.saveProfileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveProfileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveProfileButton.Depth = 0;
            this.saveProfileButton.HighEmphasis = true;
            this.saveProfileButton.Icon = null;
            this.saveProfileButton.Location = new System.Drawing.Point(681, 377);
            this.saveProfileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveProfileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveProfileButton.Name = "saveProfileButton";
            this.saveProfileButton.Size = new System.Drawing.Size(64, 36);
            this.saveProfileButton.TabIndex = 4;
            this.saveProfileButton.Text = "Save";
            this.saveProfileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveProfileButton.UseAccentColor = false;
            this.saveProfileButton.UseVisualStyleBackColor = true;
            this.saveProfileButton.Click += new System.EventHandler(this.saveProfileButton_Click);
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.CalendarForeColor = System.Drawing.SystemColors.GrayText;
            this.birthdayPicker.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.birthdayPicker.CalendarTitleBackColor = System.Drawing.Color.MediumSlateBlue;
            this.birthdayPicker.Location = new System.Drawing.Point(334, 261);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(411, 27);
            this.birthdayPicker.TabIndex = 5;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.resultLabel);
            this.materialCard1.Controls.Add(this.saveProfileButton);
            this.materialCard1.Controls.Add(this.birthdayPickerLabel);
            this.materialCard1.Controls.Add(this.birthdayPicker);
            this.materialCard1.Controls.Add(this.chooseFileButton);
            this.materialCard1.Controls.Add(this.profilePictureFilenameLabel);
            this.materialCard1.Controls.Add(this.addressInput);
            this.materialCard1.Controls.Add(this.phoneInput);
            this.materialCard1.Controls.Add(this.lastNameInput);
            this.materialCard1.Controls.Add(this.firstNameInput);
            this.materialCard1.Controls.Add(this.newProfilePicture);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(762, 440);
            this.materialCard1.TabIndex = 3;
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(131, 384);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(500, 22);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // NewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Name = "NewProfile";
            this.Size = new System.Drawing.Size(790, 468);
            this.VisibleChanged += new System.EventHandler(this.NewProfile_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.newProfilePicture)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel birthdayPickerLabel;
        private MaterialSkin.Controls.MaterialButton chooseFileButton;
        private MaterialSkin.Controls.MaterialTextBox addressInput;
        private MaterialSkin.Controls.MaterialTextBox phoneInput;
        private MaterialSkin.Controls.MaterialTextBox lastNameInput;
        private MaterialSkin.Controls.MaterialTextBox firstNameInput;
        private System.Windows.Forms.PictureBox newProfilePicture;
        private MaterialSkin.Controls.MaterialButton saveProfileButton;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel profilePictureFilenameLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}
