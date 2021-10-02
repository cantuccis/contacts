
namespace ContactsUI
{
    partial class BookList
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
            this.containerCard = new MaterialSkin.Controls.MaterialCard();
            this.removeBookButton = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.editBookButton = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.addBookButton = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.booksList = new MaterialSkin.Controls.MaterialListBox();
            this.titleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.containerCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerCard
            // 
            this.containerCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.containerCard.Controls.Add(this.removeBookButton);
            this.containerCard.Controls.Add(this.editBookButton);
            this.containerCard.Controls.Add(this.addBookButton);
            this.containerCard.Controls.Add(this.booksList);
            this.containerCard.Controls.Add(this.titleLabel);
            this.containerCard.Depth = 0;
            this.containerCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.containerCard.Location = new System.Drawing.Point(14, 14);
            this.containerCard.Margin = new System.Windows.Forms.Padding(14);
            this.containerCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.containerCard.Name = "containerCard";
            this.containerCard.Padding = new System.Windows.Forms.Padding(14);
            this.containerCard.Size = new System.Drawing.Size(762, 440);
            this.containerCard.TabIndex = 0;
            // 
            // removeBookButton
            // 
            this.removeBookButton.Depth = 0;
            this.removeBookButton.ForeColor = System.Drawing.Color.White;
            this.removeBookButton.Icon = global::ContactsUI.Properties.Resources.delete;
            this.removeBookButton.Location = new System.Drawing.Point(461, 362);
            this.removeBookButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(61, 66);
            this.removeBookButton.TabIndex = 4;
            this.removeBookButton.Text = "materialFloatingActionButton1";
            this.removeBookButton.UseVisualStyleBackColor = true;
            // 
            // editBookButton
            // 
            this.editBookButton.Depth = 0;
            this.editBookButton.ForeColor = System.Drawing.Color.White;
            this.editBookButton.Icon = global::ContactsUI.Properties.Resources.pencil;
            this.editBookButton.Location = new System.Drawing.Point(351, 362);
            this.editBookButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.editBookButton.Name = "editBookButton";
            this.editBookButton.Size = new System.Drawing.Size(61, 66);
            this.editBookButton.TabIndex = 3;
            this.editBookButton.Text = "materialFloatingActionButton1";
            this.editBookButton.UseVisualStyleBackColor = true;
            // 
            // addBookButton
            // 
            this.addBookButton.Depth = 0;
            this.addBookButton.ForeColor = System.Drawing.Color.White;
            this.addBookButton.Icon = global::ContactsUI.Properties.Resources.add;
            this.addBookButton.Location = new System.Drawing.Point(241, 362);
            this.addBookButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(61, 66);
            this.addBookButton.TabIndex = 2;
            this.addBookButton.Text = "materialFloatingActionButton1";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // booksList
            // 
            this.booksList.BackColor = System.Drawing.Color.White;
            this.booksList.BorderColor = System.Drawing.Color.LightGray;
            this.booksList.Depth = 0;
            this.booksList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.booksList.Location = new System.Drawing.Point(17, 41);
            this.booksList.MouseState = MaterialSkin.MouseState.HOVER;
            this.booksList.Name = "booksList";
            this.booksList.SelectedIndex = -1;
            this.booksList.SelectedItem = null;
            this.booksList.Size = new System.Drawing.Size(728, 310);
            this.booksList.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Depth = 0;
            this.titleLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.titleLabel.Location = new System.Drawing.Point(17, 14);
            this.titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(56, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Books";
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.containerCard);
            this.Name = "BookList";
            this.Size = new System.Drawing.Size(790, 468);
            this.containerCard.ResumeLayout(false);
            this.containerCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard containerCard;
        private MaterialSkin.Controls.MaterialFloatingActionButton removeBookButton;
        private MaterialSkin.Controls.MaterialFloatingActionButton editBookButton;
        private MaterialSkin.Controls.MaterialFloatingActionButton addBookButton;
        private MaterialSkin.Controls.MaterialListBox booksList;
        private MaterialSkin.Controls.MaterialLabel titleLabel;
    }
}
