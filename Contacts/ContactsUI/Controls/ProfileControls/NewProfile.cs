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
using BrumCustomAlerts;
using BusinessLogic;
using BusinessLogic.Exceptions;
using MaterialSkin;
using Storage;
using Storage.Exceptions;

namespace ContactsUI.Controls.ProfileControls
{
    public partial class NewProfile : UserControl
    {
        private LocalStorage localStorage;
        private FileInfo selectedImage;
        private IList<Profile> profiles;
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public NewProfile(IList<Profile> profiles, LocalStorage localStorage)
        {
            this.localStorage = localStorage ?? throw new ArgumentNullException(nameof(localStorage));
            this.profiles = profiles ?? throw new ArgumentNullException(nameof(profiles));
            this.selectedImage = localStorage.Get(Contacts.DefaultProfileImageName);
            InitializeComponent();
        }

        private void ResetNewProfileView()
        {
            firstNameInput.Clear();
            lastNameInput.Clear();
            phoneInput.Clear();
            addressInput.Clear();
            newProfilePicture.Image = newProfilePicture.InitialImage;
            profilePictureFilenameLabel.Text = "";
        }

        private void ResetResultLabel()
        {
            resultLabel.Text = "";
        }

        private void saveProfileButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveProfile();
            }
            catch (Exception ex)
            {
                if (ex is BusinessLogicException || ex is LocalStorageException)
                {
                    resultLabel.Text = ex.Message;
                    resultLabel.ForeColor = Color.DarkRed;
                }
            }

        }

        private void SaveProfile()
        {
            ResetResultLabel();
            var newProfile = new Profile()
            {
                FirstName = firstNameInput.Text,
                LastName = lastNameInput.Text,
                PhoneNumber = phoneInput.Text,
                Address = addressInput.Text,
                PicturePath = selectedImage.FullName,
                Birthday = birthdayPicker.Value,
            };
            localStorage.AddForce(selectedImage);
            profiles.Add(newProfile);
            
            BrumAlertFactory.OpenAlert(
                $"Profile {newProfile.FirstName} {newProfile.LastName} was created", 
                materialSkinManager.TextHighEmphasisColor, 
                materialSkinManager.CardsColor, 
                new Bitmap(selectedImage.FullName), 
                5000, 
                AlertLocation.BottomMiddle);

            ResetNewProfileView();
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog pictureFileDialog = new OpenFileDialog();
            pictureFileDialog.Title = "Open Image";
            pictureFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (pictureFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImage = new FileInfo(pictureFileDialog.FileName);
                profilePictureFilenameLabel.Text = selectedImage.Name;
                newProfilePicture.Image = new Bitmap(pictureFileDialog.FileName);
            }
        }

        private void NewProfile_VisibleChanged(object sender, EventArgs e) 
        {
            ResetNewProfileView();
            ResetResultLabel();
        }

    }
}
