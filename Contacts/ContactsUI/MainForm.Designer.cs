
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
            this.newContactTab = new System.Windows.Forms.TabPage();
            this.contactsTab = new System.Windows.Forms.TabPage();
            this.tabsControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // newContactTab
            // 
            this.newContactTab.BackColor = System.Drawing.Color.White;
            this.newContactTab.Location = new System.Drawing.Point(4, 29);
            this.newContactTab.Name = "newContactTab";
            this.newContactTab.Padding = new System.Windows.Forms.Padding(3);
            this.newContactTab.Size = new System.Drawing.Size(786, 480);
            this.newContactTab.TabIndex = 1;
            this.newContactTab.Text = "New contact";
            // 
            // contactsTab
            // 
            this.contactsTab.BackColor = System.Drawing.Color.White;
            this.contactsTab.Location = new System.Drawing.Point(4, 29);
            this.contactsTab.Name = "contactsTab";
            this.contactsTab.Padding = new System.Windows.Forms.Padding(3);
            this.contactsTab.Size = new System.Drawing.Size(786, 480);
            this.contactsTab.TabIndex = 0;
            this.contactsTab.Text = "Contacts";
            this.contactsTab.ToolTipText = "Contacts navigation";
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
            this.tabsControl.Size = new System.Drawing.Size(794, 513);
            this.tabsControl.TabIndex = 3;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage newContactTab;
        private System.Windows.Forms.TabPage contactsTab;
        private MaterialSkin.Controls.MaterialTabControl tabsControl;
    }
}

