
namespace ContactsUI.Controls.BookControls
{
    partial class ExpandableBook
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
            this.card = new MaterialSkin.Controls.MaterialCard();
            this.expandButton = new MaterialSkin.Controls.MaterialButton();
            this.borderPanel = new System.Windows.Forms.Panel();
            this.containerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bookNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.card.SuspendLayout();
            this.borderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // card
            // 
            this.card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.card.Controls.Add(this.expandButton);
            this.card.Controls.Add(this.borderPanel);
            this.card.Controls.Add(this.bookNameLabel);
            this.card.Depth = 0;
            this.card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.card.Location = new System.Drawing.Point(4, 5);
            this.card.Margin = new System.Windows.Forms.Padding(14);
            this.card.MouseState = MaterialSkin.MouseState.HOVER;
            this.card.Name = "card";
            this.card.Padding = new System.Windows.Forms.Padding(14);
            this.card.Size = new System.Drawing.Size(307, 151);
            this.card.TabIndex = 0;
            // 
            // expandButton
            // 
            this.expandButton.AutoSize = false;
            this.expandButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.expandButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.expandButton.Depth = 0;
            this.expandButton.HighEmphasis = true;
            this.expandButton.Icon = global::ContactsUI.Properties.Resources.outline_expand_more_white_24dp;
            this.expandButton.Location = new System.Drawing.Point(261, 4);
            this.expandButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.expandButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(41, 33);
            this.expandButton.TabIndex = 2;
            this.expandButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.expandButton.UseAccentColor = false;
            this.expandButton.UseVisualStyleBackColor = true;
            this.expandButton.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // borderPanel
            // 
            this.borderPanel.Controls.Add(this.containerPanel);
            this.borderPanel.Location = new System.Drawing.Point(6, 43);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(296, 100);
            this.borderPanel.TabIndex = 1;
            // 
            // containerPanel
            // 
            this.containerPanel.Location = new System.Drawing.Point(3, 3);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(290, 94);
            this.containerPanel.TabIndex = 0;
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Depth = 0;
            this.bookNameLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bookNameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.bookNameLabel.Location = new System.Drawing.Point(17, 14);
            this.bookNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(37, 19);
            this.bookNameLabel.TabIndex = 0;
            this.bookNameLabel.Text = "Book";
            // 
            // ExpandableBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.card);
            this.Name = "ExpandableBook";
            this.Size = new System.Drawing.Size(317, 161);
            this.card.ResumeLayout(false);
            this.card.PerformLayout();
            this.borderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard card;
        private MaterialSkin.Controls.MaterialButton expandButton;
        private System.Windows.Forms.Panel borderPanel;
        private System.Windows.Forms.FlowLayoutPanel containerPanel;
        private MaterialSkin.Controls.MaterialLabel bookNameLabel;
    }
}
