
namespace ContactsUI.Controls.ProfileControls
{
    partial class MiniProfile
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.label = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(3, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(64, 64);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // label
            // 
            this.label.Depth = 0;
            this.label.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.label.Location = new System.Drawing.Point(3, 70);
            this.label.MouseState = MaterialSkin.MouseState.HOVER;
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(64, 15);
            this.label.TabIndex = 1;
            this.label.Text = "text";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MiniProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.Controls.Add(this.picture);
            this.Name = "MiniProfile";
            this.Size = new System.Drawing.Size(70, 85);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private MaterialSkin.Controls.MaterialLabel label;
    }
}
