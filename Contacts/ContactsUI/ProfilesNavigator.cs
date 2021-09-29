using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace ContactsUI
{
    public partial class ProfilesNavigator : UserControl
    {
        private readonly IList<Profile> profiles;
        private int index;
        public ProfilesNavigator(IList<Profile> profiles)
        {
            InitializeComponent();
            this.profiles = profiles;
            index = 0;
            ShowProfile(index);
        }

        public void ShowProfile(int profileIndex)
        {
            if(profileIndex >= 0 && profileIndex < profiles.Count)
            {
                var profile = profiles[profileIndex];
                ShowProfilePicture(profile.PicturePath);
                nameText.Text = $"{profile.FirstName} {profile.LastName}";
                ageText.Text = $"{profile.Age} years old ({profile.Birthday.Date.ToShortDateString()})";
                phoneText.Text = profile.PhoneNumber;
                addressText.Text = profile.Address;
            }
            
        }

        public void NextProfile()
        {
            if (index < profiles.Count - 1) ShowProfile(++index);
        }

        public void PrevProfile()
        {
            if (index > 0) ShowProfile(--index);
        }

        private void ShowProfilePicture(string path)
        {
            try
            {
                profilePictureBox.Image = new Bitmap(path);
            }
            catch (Exception ex)
            {
                if (ex is FileNotFoundException)
                {
                    profilePictureBox.Image = Properties.Resources.wanted;
                }
                else
                {
                    throw;
                }
            }
        }

        private void nextProfileButton_Click(object sender, EventArgs e) => NextProfile();

        private void previousProfileButton_Click(object sender, EventArgs e) => PrevProfile();

        private void ProfilesNavigator_VisibleChanged(object sender, EventArgs e) => ShowProfile(index);
    }
}
