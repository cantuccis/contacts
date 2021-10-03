
namespace ContactsUI.Controls.BookControls
{
    partial class BookProfilesNavigator
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
            this.navigatorPanel = new System.Windows.Forms.Panel();
            this.bookComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // navigatorPanel
            // 
            this.navigatorPanel.Location = new System.Drawing.Point(0, 77);
            this.navigatorPanel.Name = "navigatorPanel";
            this.navigatorPanel.Size = new System.Drawing.Size(790, 393);
            this.navigatorPanel.TabIndex = 0;
            // 
            // bookComboBox
            // 
            this.bookComboBox.AutoResize = false;
            this.bookComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookComboBox.Depth = 0;
            this.bookComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.bookComboBox.DropDownHeight = 174;
            this.bookComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookComboBox.DropDownWidth = 121;
            this.bookComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bookComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bookComboBox.FormattingEnabled = true;
            this.bookComboBox.Hint = "Book";
            this.bookComboBox.IntegralHeight = false;
            this.bookComboBox.ItemHeight = 43;
            this.bookComboBox.Location = new System.Drawing.Point(168, 22);
            this.bookComboBox.MaxDropDownItems = 4;
            this.bookComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.bookComboBox.Name = "bookComboBox";
            this.bookComboBox.Size = new System.Drawing.Size(459, 49);
            this.bookComboBox.StartIndex = 0;
            this.bookComboBox.TabIndex = 1;
            this.bookComboBox.SelectedValueChanged += new System.EventHandler(this.bookComboBox_SelectedValueChanged);
            // 
            // BookProfilesNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookComboBox);
            this.Controls.Add(this.navigatorPanel);
            this.Name = "BookProfilesNavigator";
            this.Size = new System.Drawing.Size(790, 470);
            this.VisibleChanged += new System.EventHandler(this.BookProfilesNavigator_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigatorPanel;
        private MaterialSkin.Controls.MaterialComboBox bookComboBox;
    }
}
