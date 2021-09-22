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
using MaterialSkin.Controls;
using LocalStorage;
using LocalStorage.Exceptions;
using BusinessLogic;

namespace ContactsUI
{
    public partial class Contacts : MaterialForm
    {
        private readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private readonly LocalStorage.LocalStorage localStorage;
        private const string storageDir = "ui-images";
        private FileInfo selectedImage;

        IList<Profile> profiles;

        public Contacts()
        {
            InitializeComponent();
            localStorage = new LocalStorage.LocalStorage(storageDir);
            profiles = new List<Profile>();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void RefreshNewProfileView()
        {
            firstNameInput.Clear();
            lastNameInput.Clear();
            phoneInput.Clear();
            addressInput.Clear();
            newProfilePicture.Image = null;
            profilePictureFilenameLabel.Text = "";
        }

        private void saveProfileButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newProfile = new Profile()
                {
                    FirstName = firstNameInput.Text,
                    LastName = lastNameInput.Text,
                    PhoneNumber = phoneInput.Text,
                    Address = addressInput.Text,
                };
                profiles.Add(newProfile);
                localStorage.Add(selectedImage);
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = "Success";
                RefreshNewProfileView();
            }
            catch (Exception ex)
            {
                if (ex is BusinessLogicException || ex is LocalStorageException)
                {
                    resultLabel.Text = ex.Message;
                    resultLabel.ForeColor = Color.Red;
                }
            }

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

        private void nextProfileButton_Click(object sender, EventArgs e)
        {

        }
    }
}
