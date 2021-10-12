using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsUI.Controls.ProfileControls
{
    public partial class MiniProfile : UserControl
    {
        public MiniProfile(string imagePath, string text)
        {
            InitializeComponent();
            this.picture.Image = new Bitmap(imagePath);
            this.label.Text = text;
            Refresh();
        }
    }
}
